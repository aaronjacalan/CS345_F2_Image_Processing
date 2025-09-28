using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace CS345___Image_Processing
{
	public class ImageFilter
	{
		
		public Bitmap Copy(Bitmap original)
		{
			if (original == null) return null;

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
			return copy;
		}

		public Bitmap Grayscale(Bitmap original)
		{
			if (original == null) return null;

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

			return grayscale;
		}

		public Bitmap ColorInverse(Bitmap original)
		{
			if (original == null) return null;

			Bitmap inverted = new Bitmap(original.Width, original.Height, PixelFormat.Format24bppRgb);
			var rect = new Rectangle(0, 0, original.Width, original.Height);
			var originalData = original.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
			var inverseData = inverted.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

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
			inverted.UnlockBits(inverseData);

			return inverted;
		}

		public Bitmap Histogram(Bitmap original)
		{
			if (original == null) return null;

			Bitmap histogram = new Bitmap(256, 100);

			int[] counts = new int[256];
			var rect = new Rectangle(0, 0, original.Width, original.Height);
			var data = original.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

			unsafe
			{
				byte* ptr = (byte*)data.Scan0;
				int stride = data.Stride;
				int width = original.Width;
				int height = original.Height;

				for (int y = 0; y < height; y++)
				{
					byte* row = ptr + y * stride;
					for (int x = 0; x < width; x++)
					{
						int index = x * 3;
						byte b = row[index];
						byte g = row[index + 1];
						byte r = row[index + 2];

						int gray = (r + g + b) / 3;
						counts[gray]++;
					}
				}
			}

			original.UnlockBits(data);

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

			return histogram;
		}

		public Bitmap Sepia(Bitmap original)
		{
			if (original == null) return null;

			Bitmap sepia = new Bitmap(original.Width, original.Height, PixelFormat.Format24bppRgb);
			Rectangle rect = new Rectangle(0, 0, original.Width, original.Height);
			BitmapData originalData = original.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
			BitmapData sepiaData = sepia.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

			unsafe
			{
				byte* srcPtr = (byte*)originalData.Scan0;
				byte* dstPtr = (byte*)sepiaData.Scan0;
				int bytesPerPixel = 3;
				int stride = originalData.Stride;

				for (int y = 0; y < original.Height; y++)
				{
					for (int x = 0; x < original.Width; x++)
					{
						int pixelOffset = y * stride + x * bytesPerPixel;

						byte b = srcPtr[pixelOffset];
						byte g = srcPtr[pixelOffset + 1];
						byte r = srcPtr[pixelOffset + 2];

						int sepiaRed = (int)((r * 0.45) + (g * 0.85) + (b * 0.20));
						int sepiaGreen = (int)((r * 0.40) + (g * 0.75) + (b * 0.15));
						int sepiaBlue = (int)((r * 0.25) + (g * 0.55) + (b * 0.10));

						if (sepiaRed > 255) sepiaRed = 255;
						if (sepiaGreen > 255) sepiaGreen = 255;
						if (sepiaBlue > 255) sepiaBlue = 255;

						dstPtr[pixelOffset] = (byte)sepiaBlue;
						dstPtr[pixelOffset + 1] = (byte)sepiaGreen;
						dstPtr[pixelOffset + 2] = (byte)sepiaRed;
					}
				}
			}

			original.UnlockBits(originalData);
			sepia.UnlockBits(sepiaData);

			return sepia;
		}

	}
}