using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Windows.GUI
{
	internal delegate void PaletteEventHandler(object sender, PaletteEventArgs e);

	internal class PaletteEventArgs : EventArgs
	{
		public Color Color { get; set; }
		public int Index { get; set; }

		public PaletteEventArgs(Color color, int index) : base()
		{
			Color = color;
			Index = index;
		}
	}
}
