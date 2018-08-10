using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsExtensions
{
    public static class LayoutHelper
    {
		public const AnchorStyles AnchorAll = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

		#region Place

		public static Point PlaceBelow(Control above)
		{
			return new Point(above.Location.X, above.Location.Y + above.Height);
		}

		#endregion

		#region Fill

		public static Size FillBelow(Control parentContainer, Control above)
		{
			return new Size(parentContainer.ClientSize.Width, parentContainer.ClientSize.Height - (above.Location.Y + above.Height));
		}

		public static Size FillAbove(Control parentContainer, Control above)
		{
			return new Size(parentContainer.ClientSize.Width, parentContainer.ClientSize.Height - (above.Location.Y));
		}

		public static Size FillAbove(Control parentContainer, Control above, int margin)
		{
			return new Size(parentContainer.ClientSize.Width - (2 * margin), parentContainer.ClientSize.Height - (above.Height) - (2 * margin));
		}

		#endregion
	}
}
