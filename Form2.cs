using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
		Bitmap imageB, imageA, chromaBackground, resultImage;
		private Color chromaKeyColor = Color.FromArgb(0, 255, 0);
		private int defaultThreshold = 5;

		private Button[] subtractButtons;

		public Form2()
		{
			InitializeComponent();
			thresholdNumber.Text = defaultThreshold.ToString();
			updateChromaKeyColorDisplay(chromaKeyColor);

			subtractButtons = new Button[]
			{
				subtractGrayscaleButton,
				subtractRGBButton
			};

			InitializeButtonBackgrounds(subtractButtons);
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

		private void switchToFiltersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form1 mainForm = new Form1();
			mainForm.StartPosition = FormStartPosition.Manual;
			mainForm.Location = this.Location;

			mainForm.Show();
			this.Hide();
		}


		// CHOOSE IMAGES TO SUBTRACT
		private void chooseBackgroundButton_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "Open Background Image";
			openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
			openFileDialog1.RestoreDirectory = true;

			openFileDialog1.ShowDialog();
		}

		private void chooseImageButton_Click(object sender, EventArgs e)
		{
			openFileDialog2.Title = "Open Foreground Image";
			openFileDialog2.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
			openFileDialog2.RestoreDirectory = true;

			openFileDialog2.ShowDialog();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				imageB = new Bitmap(openFileDialog1.FileName);
				pictureBox1.Image = imageB;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading background image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				imageA = new Bitmap(openFileDialog2.FileName);
				pictureBox2.Image = imageA;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading foreground image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		// FILE SAVE
		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			if (pictureBox3.Image != null)
			{
				string fileName = saveFileDialog1.FileName;
				pictureBox3.Image.Save(fileName, ImageFormat.Png);
				MessageBox.Show("Image saved!");
			}
			else
			{
				MessageBox.Show("No image to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (pictureBox3.Image == null)
			{
				MessageBox.Show("No image to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			string editedFileName = "chroma_keyed_image";

			saveFileDialog1.Filter = "PNG Images|*.png";
			saveFileDialog1.DefaultExt = "png";
			saveFileDialog1.AddExtension = true;
			saveFileDialog1.FileName = editedFileName;

			saveFileDialog1.ShowDialog();
		}



		// SUBTRACTION CODE
		private void chromaKeyThreshold_Scroll(object sender, EventArgs e)
		{
			if (sender is TrackBar trackBar)
			{
				defaultThreshold = trackBar.Value;
				thresholdNumber.Text = defaultThreshold.ToString();
			}
		}

		private void chooseChromaKeyColorButton_Click(object sender, EventArgs e)
		{
			using (ColorDialog colorDialog1 = new ColorDialog())
			{
				colorDialog1.Color = chromaKeyColor;
				colorDialog1.AllowFullOpen = true;

				if (colorDialog1.ShowDialog() == DialogResult.OK)
				{
					updateChromaKeyColorDisplay(colorDialog1.Color);
				}
			}
		}

		private void updateChromaKeyColorDisplay(Color newColor)
		{
			chromaKeyColor = newColor;
			chooseChromaKeyColorButton.BackColor = chromaKeyColor;
			chooseChromaKeyColorButton.Text = $"Chroma Key Color\n\nRGB({chromaKeyColor.R}, {chromaKeyColor.G}, {chromaKeyColor.B})";
		}

		// Difference between Grayscale Subtraction and RGB Subtraction:

		// Grayscale Subtraction:
		//    - Converts each pixel into a single brightness value (average of R, G, B).
		//    - Subtraction is then done on these single values.
		//    - Simpler and faster, but less accurate since color information is lost.
		//    - Good for detecting light/dark differences regardless of color.

		// RGB Subtraction:
		//    - Subtracts each channel (R, G, and B) separately between pixels.
		//    - Preserves full color information, giving more precise differences.
		//    - More computationally expensive but better at detecting color-based changes.
		//

		// Same code sa gibutang sa Notebook pero gi optimize gamay
		private void subtractButton_Click(object sender, EventArgs e)
		{
			if (imageB == null || imageA == null)
			{
				MessageBox.Show("Please load both background and foreground images first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Button clickedButton = sender as Button;
			SetSelectedButton(clickedButton, subtractButtons);

			int targetWidth = 400;
			int targetHeight = 300;
			Bitmap resizedImageB = new Bitmap(imageB, targetWidth, targetHeight);
			Bitmap resizedImageA = new Bitmap(imageA, targetWidth, targetHeight);

			resultImage = new Bitmap(targetWidth, targetHeight);
			int chromaGrey = (chromaKeyColor.R + chromaKeyColor.G + chromaKeyColor.B) / 3;

			for (int x = 0; x < targetWidth; x++)
			{
				for (int y = 0; y < targetHeight; y++)
				{
					Color foregroundPixel = resizedImageA.GetPixel(x, y);
					Color backgroundPixel = resizedImageB.GetPixel(x, y);

					int pixelGrey = (foregroundPixel.R + foregroundPixel.G + foregroundPixel.B) / 3;
					int greyDiff = Math.Abs(pixelGrey - chromaGrey);

					if (greyDiff <= defaultThreshold)
					{
						resultImage.SetPixel(x, y, backgroundPixel);
					}
					else
					{
						resultImage.SetPixel(x, y, foregroundPixel);
					}
				}
			}

			pictureBox3.Image = resultImage;
			resizedImageB.Dispose();
			resizedImageA.Dispose();
		}

		// Uses direct pixel manipulation for better performance
		private void subtractRGBButton_Click(object sender, EventArgs e)
		{
			if (imageB == null || imageA == null)
			{
				MessageBox.Show("Please load both background and foreground images first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Button clickedButton = sender as Button;
			SetSelectedButton(clickedButton, subtractButtons);

			int targetWidth = 400;
			int targetHeight = 300;
			Bitmap resizedImageB = new Bitmap(imageB, targetWidth, targetHeight);
			Bitmap resizedImageA = new Bitmap(imageA, targetWidth, targetHeight);

			resultImage = new Bitmap(targetWidth, targetHeight);

			BitmapData foregroundData = resizedImageA.LockBits(new Rectangle(0, 0, targetWidth, targetHeight), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
			BitmapData backgroundData = resizedImageB.LockBits(new Rectangle(0, 0, targetWidth, targetHeight), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
			BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, targetWidth, targetHeight), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

			unsafe
			{
				byte* foregroundPtr = (byte*)foregroundData.Scan0;
				byte* backgroundPtr = (byte*)backgroundData.Scan0;
				byte* resultPtr = (byte*)resultData.Scan0;

				int stride = foregroundData.Stride;

				int chromaR = chromaKeyColor.R;
				int chromaG = chromaKeyColor.G;
				int chromaB = chromaKeyColor.B;

				for (int y = 0; y < targetHeight; y++)
				{
					for (int x = 0; x < targetWidth; x++)
					{
						int offset = y * stride + x * 3;

						int foregroundB = foregroundPtr[offset];
						int foregroundG = foregroundPtr[offset + 1];
						int foregroundR = foregroundPtr[offset + 2];

						int rDiff = foregroundR - chromaR;
						int gDiff = foregroundG - chromaG;
						int bDiff = foregroundB - chromaB;

						double colorDistance = Math.Sqrt(rDiff * rDiff + gDiff * gDiff + bDiff * bDiff);

						if (colorDistance <= defaultThreshold * 8)
						{
							resultPtr[offset] = backgroundPtr[offset];			// Blue
							resultPtr[offset + 1] = backgroundPtr[offset + 1];  // Green
							resultPtr[offset + 2] = backgroundPtr[offset + 2];  // Red
						}
						else
						{
							resultPtr[offset] = foregroundPtr[offset];          // Blue
							resultPtr[offset + 1] = foregroundPtr[offset + 1];  // Green
							resultPtr[offset + 2] = foregroundPtr[offset + 2];  // Red
						}
					}
				}
			}

			resizedImageA.UnlockBits(foregroundData);
			resizedImageB.UnlockBits(backgroundData);
			resultImage.UnlockBits(resultData);

			pictureBox3.Image = resultImage;
			resizedImageB.Dispose();
			resizedImageA.Dispose();
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

	}
}