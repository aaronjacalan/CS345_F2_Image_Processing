using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS345___Image_Processing
{
	public class BitmapFilters
	{
		public static bool Conv3x3(Bitmap b, ConvMatrix m)
		{
			if (m.Factor == 0)
			{
				MessageBox.Show("Conv3x3: Factor must not be zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			Bitmap bSrc = (Bitmap)b.Clone();
			BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int stride = bmData.Stride;
			int stride2 = stride * 2;

			IntPtr scan0 = bmData.Scan0;
			IntPtr srcScan0 = bmSrc.Scan0;

			unsafe
			{
				byte* p = (byte*)scan0;
				byte* pSrc = (byte*)srcScan0;

				int nOffset = stride - b.Width * 3;
				int nWidth = b.Width - 2;
				int nHeight = b.Height - 2;

				for (int y = 0; y < nHeight; ++y)
				{
					for (int x = 0; x < nWidth; ++x)
					{
						int nPixel;

						nPixel = (
							(pSrc[2] * m.TopLeft) +
							(pSrc[5] * m.TopMid) +
							(pSrc[8] * m.TopRight) +
							(pSrc[2 + stride] * m.MidLeft) +
							(pSrc[5 + stride] * m.Pixel) +
							(pSrc[8 + stride] * m.MidRight) +
							(pSrc[2 + stride2] * m.BottomLeft) +
							(pSrc[5 + stride2] * m.BottomMid) +
							(pSrc[8 + stride2] * m.BottomRight)
						) / m.Factor + m.Offset;

						if (nPixel < 0) nPixel = 0;
						if (nPixel > 255) nPixel = 255;
						p[5 + stride] = (byte)nPixel;

						nPixel = (
							(pSrc[1] * m.TopLeft) +
							(pSrc[4] * m.TopMid) +
							(pSrc[7] * m.TopRight) +
							(pSrc[1 + stride] * m.MidLeft) +
							(pSrc[4 + stride] * m.Pixel) +
							(pSrc[7 + stride] * m.MidRight) +
							(pSrc[1 + stride2] * m.BottomLeft) +
							(pSrc[4 + stride2] * m.BottomMid) +
							(pSrc[7 + stride2] * m.BottomRight)
						) / m.Factor + m.Offset;

						if (nPixel < 0) nPixel = 0;
						if (nPixel > 255) nPixel = 255;
						p[4 + stride] = (byte)nPixel;

						nPixel = (
							(pSrc[0] * m.TopLeft) +
							(pSrc[3] * m.TopMid) +
							(pSrc[6] * m.TopRight) +
							(pSrc[0 + stride] * m.MidLeft) +
							(pSrc[3 + stride] * m.Pixel) +
							(pSrc[6 + stride] * m.MidRight) +
							(pSrc[0 + stride2] * m.BottomLeft) +
							(pSrc[3 + stride2] * m.BottomMid) +
							(pSrc[6 + stride2] * m.BottomRight)
						) / m.Factor + m.Offset;

						if (nPixel < 0) nPixel = 0;
						if (nPixel > 255) nPixel = 255;
						p[3 + stride] = (byte)nPixel;

						p += 3;
						pSrc += 3;
					}

					p += nOffset;
					pSrc += nOffset;
				}
			}

			b.UnlockBits(bmData);
			bSrc.UnlockBits(bmSrc);

			return true;
		}

	}
}
