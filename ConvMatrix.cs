using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace CS345___Image_Processing
{
	public class ConvMatrix
	{
		public int TopLeft = 0, TopMid = 0, TopRight = 0;
		public int MidLeft = 0, Pixel = 1, MidRight = 0;
		public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;
		public int Factor = 1;
		public int Offset = 0;

		public static bool Smooth(Bitmap b)
		{
			ConvMatrix m = new ConvMatrix();
			m.TopLeft = m.TopMid = m.TopRight = m.MidLeft = m.MidRight = m.BottomLeft = m.BottomMid = m.BottomRight = 1;

			m.Factor = 9;
			m.Offset = 0;
			return BitmapFilters.Conv3x3(b, m);
		}

		public static bool Sharpen(Bitmap b)
		{
			ConvMatrix m = new ConvMatrix();
			m.TopLeft = 0;		m.TopMid = -2;		m.TopRight = 0;
			m.MidLeft = -2;		m.Pixel = 11;		m.MidRight = -2;
			m.BottomLeft = 0;	m.BottomMid = -2;	m.BottomRight = 0;

			m.Factor = 3;
			m.Offset = 0;
			return BitmapFilters.Conv3x3(b, m);
		}

		public static bool GaussianBlur(Bitmap b)
		{
			ConvMatrix m = new ConvMatrix();
			m.TopLeft = 1;		m.TopMid = 2;		m.TopRight = 1;
			m.MidLeft = 2;		m.Pixel = 4;		m.MidRight = 2;
			m.BottomLeft = 1;	m.BottomMid = 2;	m.BottomRight = 1;

			m.Factor = 16;
			m.Offset = 0;
			return BitmapFilters.Conv3x3(b, m);
		}

		public static bool MeanRemoval(Bitmap b)
		{
			ConvMatrix m = new ConvMatrix();
			m.TopLeft = -1;		m.TopMid = -1;		m.TopRight = -1;
			m.MidLeft = -1;		m.Pixel = 9;		m.MidRight = -1;
			m.BottomLeft = -1;	m.BottomMid = -1;	m.BottomRight = -1;

			m.Factor = 1;
			m.Offset = 0;
			return BitmapFilters.Conv3x3(b, m);
		}

		public static bool Embossing(Bitmap b)
		{
			ConvMatrix m = new ConvMatrix();
			m.TopLeft = -2;		m.TopMid = -1;		m.TopRight = 0;
			m.MidLeft = -1;		m.Pixel = 1;		m.MidRight = 1;
			m.BottomLeft = 0;	m.BottomMid = 1;	m.BottomRight = 2;

			m.Factor = 1;
			m.Offset = 128;
			return BitmapFilters.Conv3x3(b, m);
		}

		public static bool SobelEdgeDetection(Bitmap b, bool vertical = true)
		{
			ConvMatrix m = new ConvMatrix();
			m.TopLeft = 1; m.TopMid = 0; m.TopRight = -1;
			m.MidLeft = 2; m.Pixel = 0; m.MidRight = -2;
			m.BottomLeft = 1; m.BottomMid = 0; m.BottomRight = -1;

			m.Factor = 1;
			m.Offset = 0;
			return BitmapFilters.Conv3x3(b, m);
		}

		public static bool PrewittEdgeDetect(Bitmap b, bool vertical = true)
		{
			ConvMatrix m = new ConvMatrix();
			m.TopLeft = -1; m.TopMid = 0; m.TopRight = 1;
			m.MidLeft = -1; m.Pixel = 0; m.MidRight = 1;
			m.BottomLeft = -1; m.BottomMid = 0; m.BottomRight = 1;

			m.Factor = 1;
			m.Offset = 0;
			return BitmapFilters.Conv3x3(b, m);
		}
	}
}