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
	/// Various utilities related to image processing.
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
	}
}
