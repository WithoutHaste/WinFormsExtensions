using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Windows.GUI
{
	internal delegate void ColorEventHandler(object sender, ColorEventArgs e);

	internal class ColorEventArgs : EventArgs
	{
		public Color Color { get; set; }

		public ColorEventArgs(Color color) : base()
		{
			Color = color;
		}
	}
}
