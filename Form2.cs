using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS345___Image_Processing
{
	public partial class Form2 : Form
	{

		private bool isDragging = false;
		private Point lastCursor;
		private Point lastForm;
		private string originalImagePath = "";

		public Form2()
		{
			InitializeComponent();
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
				Image img = Image.FromFile(openFileDialog1.FileName);
				pictureBox1.Image = img;

				originalImagePath = openFileDialog1.FileName;
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

		private void switchToFiltersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form1 mainForm = new Form1();
			mainForm.StartPosition = FormStartPosition.Manual;
			mainForm.Location = this.Location;

			mainForm.Show();
			this.Hide();
		}
	}
}
