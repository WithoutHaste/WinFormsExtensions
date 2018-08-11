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

		/// <summary>
		/// Control size must be set first.
		/// </summary>
		/// <param name="margin">Left and bottom margin</param>
		public static Point PlaceBottomLeft(Control parentContainer, Control control, int margin)
		{
			return new Point(margin, parentContainer.Height - margin - control.Height);
		}

		/// <summary>
		/// Control size must be set first.
		/// </summary>
		/// <param name="margin">Right and bottom margin</param>
		public static Point PlaceBottomRight(Control parentContainer, Control control, int margin)
		{
			return new Point(parentContainer.Width - margin - control.Width, parentContainer.Height - margin - control.Height);
		}

		public static Point PlaceBelow(Control above)
		{
			return new Point(above.Location.X, above.Location.Y + above.Height);
		}

		public static Point PlaceRight(Control left)
		{
			return new Point(left.Location.X + left.Width, left.Location.Y);
		}

		#endregion

		#region Fill

		public static Size FillFromLocation(Control parentContainer, Point location)
		{
			return new Size(parentContainer.ClientSize.Width - location.X, parentContainer.ClientSize.Height - location.Y);
		}

		public static Size FillBelow(Control parentContainer, Control above)
		{
			return new Size(parentContainer.ClientSize.Width, parentContainer.ClientSize.Height - (above.Location.Y + above.Height));
		}

		public static Size FillBelow(Control parentContainer, Control above, int width)
		{
			return new Size(width, parentContainer.ClientSize.Height - (above.Location.Y + above.Height));
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
