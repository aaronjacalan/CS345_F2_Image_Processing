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
	public partial class Form1 : Form
	{
		private bool isDragging = false;
		private Point lastCursor;
		private Point lastForm;
		private string originalImagePath = "";

		public Form1()
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
			this.Close();
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



		// FILTERS AND EFFECTS
		private void normalSpeedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image to copy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Bitmap original = new Bitmap(pictureBox1.Image);
			Bitmap copy = new Bitmap(original.Width, original.Height);

			for (int x = 0; x < original.Width; x++)
			{
				for (int y = 0; y < original.Height; y++)
				{
					Color pixelColor = original.GetPixel(x, y);
					copy.SetPixel(x, y, pixelColor);
				}
			}

			pictureBox2.Image = copy;
		}

		private void highSpeedCopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image to copy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Bitmap original = new Bitmap(pictureBox1.Image);
			Bitmap copy = new Bitmap(original.Width, original.Height, original.PixelFormat);

			var rect = new Rectangle(0, 0, original.Width, original.Height);
			var originalData = original.LockBits(rect, ImageLockMode.ReadOnly, original.PixelFormat);
			var copyData = copy.LockBits(rect, ImageLockMode.WriteOnly, copy.PixelFormat);

			unsafe
			{
				byte* srcPtr = (byte*)originalData.Scan0;
				byte* dstPtr = (byte*)copyData.Scan0;
				int totalBytes = Math.Abs(originalData.Stride) * original.Height;

				for (int i = 0; i < totalBytes; i++)
				{
					dstPtr[i] = srcPtr[i];
				}
			}

			original.UnlockBits(originalData);
			copy.UnlockBits(copyData);
			pictureBox2.Image = copy;
		}

		private void normalSpeedGreyscaleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image to convert to greyscale!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Bitmap original = new Bitmap(pictureBox1.Image);
			Bitmap greyscale = new Bitmap(original.Width, original.Height);

			for (int x = 0; x < original.Width; x++)
			{
				for (int y = 0; y < original.Height; y++)
				{
					Color pixelColor = original.GetPixel(x, y);
					int greyValue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
					Color greyColor = Color.FromArgb(greyValue, greyValue, greyValue);
					greyscale.SetPixel(x, y, greyColor);
				}
			}

			pictureBox2.Image = greyscale;
		}

		private void hiSpeedGreyscaleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image to convert to greyscale!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Bitmap original = new Bitmap(pictureBox1.Image);
			Bitmap grayscale = new Bitmap(original.Width, original.Height, PixelFormat.Format24bppRgb);

			var rect = new Rectangle(0, 0, original.Width, original.Height);
			var originalData = original.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
			var grayscaleData = grayscale.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

			unsafe
			{
				byte* srcPtr = (byte*)originalData.Scan0;
				byte* dstPtr = (byte*)grayscaleData.Scan0;

				int bytesPerPixel = 3;
				int totalPixels = original.Width * original.Height;

				for (int i = 0; i < totalPixels; i++)
				{
					int pixelOffset = i * bytesPerPixel;

					byte blue = srcPtr[pixelOffset];
					byte green = srcPtr[pixelOffset + 1];
					byte red = srcPtr[pixelOffset + 2];

					byte grayValue = (byte)((red + green + blue) / 3);

					dstPtr[pixelOffset] = grayValue;
					dstPtr[pixelOffset + 1] = grayValue;
					dstPtr[pixelOffset + 2] = grayValue;
				}
			}

			original.UnlockBits(originalData);
			grayscale.UnlockBits(grayscaleData);
			pictureBox2.Image = grayscale;
		}

		private void normalSpeedInversionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image to invert!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Bitmap original = new Bitmap(pictureBox1.Image);
			Bitmap inverted = new Bitmap(original.Width, original.Height);

			for (int x = 0; x < original.Width; x++)
			{
				for (int y = 0; y < original.Height; y++)
				{
					Color pixelColor = original.GetPixel(x, y);

					int invertedRed = 255 - pixelColor.R;
					int invertedGreen = 255 - pixelColor.G;
					int invertedBlue = 255 - pixelColor.B;

					Color invertedColor = Color.FromArgb(invertedRed, invertedGreen, invertedBlue);
					inverted.SetPixel(x, y, invertedColor);
				}
			}

			pictureBox2.Image = inverted;
		}

		private void hiSpeedInversionToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image to invert!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Bitmap original = new Bitmap(pictureBox1.Image);
			Bitmap inverse = new Bitmap(original.Width, original.Height, PixelFormat.Format24bppRgb);

			var rect = new Rectangle(0, 0, original.Width, original.Height);
			var originalData = original.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
			var inverseData = inverse.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

			unsafe
			{
				byte* srcPtr = (byte*)originalData.Scan0;
				byte* dstPtr = (byte*)inverseData.Scan0;

				int bytesPerPixel = 3;
				int totalPixels = original.Width * original.Height;

				for (int i = 0; i < totalPixels; i++)
				{
					int pixelOffset = i * bytesPerPixel;

					byte blue = srcPtr[pixelOffset];
					byte green = srcPtr[pixelOffset + 1];
					byte red = srcPtr[pixelOffset + 2];

					byte inverseBlue = (byte)(255 - blue);
					byte inverseGreen = (byte)(255 - green);
					byte inverseRed = (byte)(255 - red);

					dstPtr[pixelOffset] = inverseBlue;
					dstPtr[pixelOffset + 1] = inverseGreen;
					dstPtr[pixelOffset + 2] = inverseRed;
				}
			}

			original.UnlockBits(originalData);
			inverse.UnlockBits(inverseData);
			pictureBox2.Image = inverse;
		}

		private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image to create histogram!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Bitmap original = new Bitmap(pictureBox1.Image);
			int[] counts = new int[256];

			for (int x = 0; x < original.Width; x++)
			{
				for (int y = 0; y < original.Height; y++)
				{
					Color pixel = original.GetPixel(x, y);
					int gray = (pixel.R + pixel.G + pixel.B) / 3;
					counts[gray]++;
				}
			}
			Bitmap histogram = new Bitmap(256, 100);

			int max = 0;
			for (int i = 0; i < 256; i++) if (counts[i] > max) max = counts[i];

			for (int x = 0; x < 256; x++)
			{
				int height = max > 0 ? (counts[x] * 90) / max : 0;

				for (int y = 0; y < 100; y++)
				{
					if (y >= (99 - height))
						histogram.SetPixel(x, y, Color.Black);
					else
						histogram.SetPixel(x, y, Color.White);
				}
			}

			pictureBox2.Image = histogram;
		}

		private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("No image to apply sepia effect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Bitmap original = new Bitmap(pictureBox1.Image);
			Bitmap sepia = new Bitmap(original.Width, original.Height);

			for (int x = 0; x < original.Width; x++)
			{
				for (int y = 0; y < original.Height; y++)
				{
					Color pixelColor = original.GetPixel(x, y);

					int sepiaRed = (int)((pixelColor.R * 0.45) + (pixelColor.G * 0.85) + (pixelColor.B * 0.20));
					int sepiaGreen = (int)((pixelColor.R * 0.40) + (pixelColor.G * 0.75) + (pixelColor.B * 0.15));
					int sepiaBlue = (int)((pixelColor.R * 0.25) + (pixelColor.G * 0.55) + (pixelColor.B * 0.10));

					if (sepiaRed > 255) sepiaRed = 255;
					if (sepiaGreen > 255) sepiaGreen = 255;
					if (sepiaBlue > 255) sepiaBlue = 255;

					Color sepiaColor = Color.FromArgb(sepiaRed, sepiaGreen, sepiaBlue);
					sepia.SetPixel(x, y, sepiaColor);
				}
			}

			pictureBox2.Image = sepia;
		}

	}
}