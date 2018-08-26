using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Windows.GUI
{
	public static class ImageHelper
	{
		/// <summary>
		/// GDI+ expects the original MemoryStream used to load an image to remain open for the full life of the Image. If you close the MemoryStream and then try to save the Image to the same location as it was loaded from, you'll get a "A generic error occurred in GDI+" exception.
		/// 
		/// Opening images with this method will avoid that error.
		/// </summary>
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
