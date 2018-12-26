using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Windows.GUI
{
	/// <summary>
	/// Utilities related to image processing.
	/// </summary>
	public static class ImageHelper
	{
		/// <summary>
		/// <para>To avoid "A generic error occurred in GDI+" exception.</para>
		/// <para>GDI+ expects the original MemoryStream used to load an image to remain open for the full life of the image. If you close the MemoryStream and then try to save the image to the same location as it was loaded from, you'll get this exception.</para>
		/// <para>Opening images with this method will avoid that error.</para>
		/// </summary>
		/// <param name="fullFilename">Full path and filename to image.</param>
		public static Bitmap SafeLoadBitmap(string fullFilename)
		{
			byte[] imageBytes = File.ReadAllBytes(fullFilename);
			Image image;
			using(MemoryStream stream = new MemoryStream(imageBytes))
			{
				using(image = Image.FromStream(stream, false, true))
				{
					return new Bitmap(image);
				}
			}
		}

		/// <summary>
		/// Shrinks an image to fit within <paramref name='maxWidth'/> and <paramref name='maxHeight'/>.
		/// Keeps aspect ratio the same.
		/// </summary>
		/// <returns>Returns a new Bitmap object, even if the image did not need to be resized.</returns>
		public static Bitmap GetThumbnail(Bitmap bitmap, int maxWidth, int maxHeight)
		{
			int width = bitmap.Width;
			int height = bitmap.Height;
			if(width <= maxWidth && height <= maxHeight)
				return new Bitmap(bitmap);

			if(width > maxWidth)
			{
				// widthA/heightA = widthB/heightB
				// heightB = heightA*widthB/widthA
				height = (height * maxWidth) / width;
				width = maxWidth;
			}
			if(height > maxHeight)
			{
				// widthA/heightA = widthB/heightB
				// widthB = widthA*heightB/heightA
				width = (width * maxHeight) / height;
				height = maxHeight;
			}
			Bitmap result = new Bitmap(width, height);
			using(Graphics graphics = Graphics.FromImage(result))
			{
				graphics.DrawImage(bitmap, 0, 0, width, height);
			}
			return result;
		}
	}
}
