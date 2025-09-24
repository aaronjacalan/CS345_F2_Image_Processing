using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using WebCamLib;

namespace CS345___Image_Processing
{
	public partial class Form1 : Form
	{
		private bool isDragging = false;
		private Point lastCursor;
		private Point lastForm;
		private string originalImagePath = "";
		private Button[] filterButtons;
		Bitmap image;
		private ImageFilter imageFilter;

		private WebcamIntegrations webcamIntegrations;

		public Form1()
		{
			InitializeComponent();

			filterButtons = new Button[]
			{
				CopyButton,
				colorInverseButton,
				greyscaleButton,
				histogramButton,
				sepiaButton
			};

			InitializeButtonBackgrounds(filterButtons);
			imageFilter = new ImageFilter();
			webcamIntegrations = new WebcamIntegrations(pictureBox1, useWebcamToolStripMenuItem);

			timer1.Interval = 33;
			timer1.Enabled = false;
		}



		// DRAG FORM
		private void TitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = true;
				lastCursor = Cursor.Position;
				lastForm = this.Location;
			}
		}

		private void TitleBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDragging && e.Button == MouseButtons.Left)
			{
				Point currentCursor = Cursor.Position;
				Point offset = new Point(currentCursor.X - lastCursor.X, currentCursor.Y - lastCursor.Y);
				this.Location = new Point(lastForm.X + offset.X, lastForm.Y + offset.Y);
			}
		}

		private void TitleBar_MouseUp(object sender, MouseEventArgs e)
		{
			isDragging = false;
		}



		// MOUSE BUTTONS
		private void MouseEnter_Color(object sender, EventArgs e)
		{
			if (sender is Button btn)
			{
				btn.BackColor = Color.FromArgb(255, 0, 0);
				btn.ForeColor = Color.White;
			}
		}

		private void MouseLeave_Color(object sender, EventArgs e)
		{
			if (sender is Button btn)
			{
				btn.BackColor = Color.Transparent;
				btn.ForeColor = Color.Black;
			}
		}



		// CUSTOM BUTTON DESIGNS
		private void InitializeButtonBackgrounds(params Button[] buttons)
		{
			foreach (var btn in buttons)
			{
				btn.BackColor = SystemColors.ControlLight;
				btn.Tag = btn.BackColor;
			}
		}

		private void SetSelectedButton(Button selectedButton, params Button[] allButtons)
		{
			foreach (var btn in allButtons)
			{
				if (btn.Tag != null && btn != selectedButton)
					btn.BackColor = (Color)btn.Tag;
			}
			selectedButton.BackColor = Color.FromArgb(0, 184, 255);
		}



		// WINDOW CONTROL BUTTONS
		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}



		// FILE MENU
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "Open Image";
			openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
			openFileDialog1.RestoreDirectory = true;

			openFileDialog1.ShowDialog();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				webcamIntegrations.StopWebcam();
				timer1.Stop(); // Stop the timer when loading an image

				image = new Bitmap(openFileDialog1.FileName);
				pictureBox1.Image = image;

				originalImagePath = openFileDialog1.FileName;
				InitializeButtonBackgrounds(filterButtons);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			if (pictureBox2.Image != null)
			{
				string fileName = saveFileDialog1.FileName;
				pictureBox2.Image.Save(fileName, ImageFormat.Png);
				MessageBox.Show("Image saved!");
			}
			else
			{
				MessageBox.Show("No image to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (pictureBox2.Image == null)
			{
				MessageBox.Show("No image to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string originalFileName = "image";
			if (!string.IsNullOrEmpty(originalImagePath))
			{
				originalFileName = Path.GetFileNameWithoutExtension(originalImagePath);
			}

			string editedFileName = originalFileName + " - edited";

			saveFileDialog1.Filter = "PNG Images|*.png";
			saveFileDialog1.DefaultExt = "png";
			saveFileDialog1.AddExtension = true;
			saveFileDialog1.FileName = editedFileName;

			saveFileDialog1.ShowDialog();
		}

		private void switchToSubtractionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 subForm = new Form2();
			subForm.StartPosition = FormStartPosition.Manual;
			subForm.Location = this.Location;

			subForm.Show();
			this.Hide();
		}



		// IMAGE PROCESSING FILTERS
		private void CopyButton_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image available to copy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Button clickedButton = sender as Button;
			SetSelectedButton(clickedButton, filterButtons);

			Bitmap original = new Bitmap(pictureBox1.Image);
			pictureBox2.Image = imageFilter.Copy(original, usePointersCheckBox.Checked);
		}

		private void greyscaleButton_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image available to convert to greyscale!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Button clickedButton = sender as Button;
			SetSelectedButton(clickedButton, filterButtons);

			Bitmap original = new Bitmap(pictureBox1.Image);
			pictureBox2.Image = imageFilter.Grayscale(original, usePointersCheckBox.Checked);
		}

		private void colorInverseButton_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image available to apply the invertion of colors!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Button clickedButton = sender as Button;
			SetSelectedButton(clickedButton, filterButtons);

			Bitmap original = new Bitmap(pictureBox1.Image);
			pictureBox2.Image = imageFilter.ColorInverse(original, usePointersCheckBox.Checked);
		}

		private void histogramButton_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image available to create histogram!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Button clickedButton = sender as Button;
			SetSelectedButton(clickedButton, filterButtons);

			Bitmap original = new Bitmap(pictureBox1.Image);
			pictureBox2.Image = imageFilter.Histogram(original, usePointersCheckBox.Checked);
		}

		private void sepiaButton_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image available to apply sepia effect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Button clickedButton = sender as Button;
			SetSelectedButton(clickedButton, filterButtons);

			Bitmap original = new Bitmap(pictureBox1.Image);
			pictureBox2.Image = imageFilter.Sepia(original, usePointersCheckBox.Checked);
		}



		// WEBCAM INTEGRATION
		private void useWebcamToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webcamIntegrations.ToggleWebcam();

			if (webcamIntegrations.IsWebcamMode)
			{
				usePointersCheckBox.Checked = true;
				timer1.Start();
				pictureBox2.Image = null;
			}
			else
			{
				usePointersCheckBox.Checked = false;
				timer1.Stop();
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			timer1.Stop();
			webcamIntegrations.CleanupResources();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			webcamIntegrations.CaptureFrame();
		}


	}
}