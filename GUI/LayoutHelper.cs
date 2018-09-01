using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithoutHaste.Windows.GUI
{
	/// <summary>
	/// Helper for placing and sizing controls in a Form relative to each other.
	/// </summary>
	/// <remarks>
	/// <para>Uses method chaining for a fluent writing style. Location and sizing methods can be chained in any order. Apply must be the last command.</para>
	/// <para>Add the control to its parent after using LayoutHelper.</para>
	/// <para>All methods in <see cref="LayoutOptions"/> can also be called on LayoutHelper.</para>
	/// </remarks>
	/// <example>
	///  <code>
	///form.Controls.Add(toolStrip);
	///form.Controls.Add(otherControl);
	///LayoutHelper.Below(toolStrip).MatchLeft(otherControl).Right(form).Height(25).Apply(control);
	///form.Controls.Add(control);
	///  </code>
	/// </example>
	public static partial class LayoutHelper
    {
		/// <summary>Control.Anchor setting for anchoring in all directions.</summary>
		public const AnchorStyles AnchorAll = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

		//todo: check for nulls on all Control arguments

		/// <summary>Place control directly to the right of the reference, aligned to the top of the reference.</summary>
		public static void PlaceRightOf(Control control, Control reference)
		{
			control.Location = new Point(reference.Location.X + reference.Width, reference.Location.Y);
		}

		/// <summary>Place control directly to the right of the reference, aligned to the top of the reference, with margin in between.</summary>
		public static void PlaceRightOf(Control control, Control reference, int margin)
		{
			control.Location = new Point(reference.Location.X + reference.Width + margin, reference.Location.Y);
		}

		/// <summary>Place control directly to the left of the reference, aligned to the top of the reference.</summary>
		public static void PlaceLeftOf(Control control, Control reference)
		{
			control.Location = new Point(reference.Location.X - control.Width, reference.Location.Y);
		}

		/// <summary>Place control directly to the left of the reference, aligned to the top of the reference, with margin in between.</summary>
		public static void PlaceLeftOf(Control control, Control reference, int margin)
		{
			control.Location = new Point(reference.Location.X - control.Width - margin, reference.Location.Y);
		}

		/// <summary>Center control vertically inside reference.</summary>
		public static void CenterVertically(Control control, Control reference)
		{
			control.Location = new Point(control.Location.X, (reference.Height - control.Height) / 2);
		}

		/// <summary>Center control horizontally inside reference.</summary>
		public static void CenterHorizontally(Control control, Control reference)
		{
			control.Location = new Point((reference.Width - control.Width) / 2, control.Location.Y);
		}

		/// <summary>Center control horizontally and vertically inside reference.</summary>
		public static void CenterBoth(Control control, Control reference)
		{
			control.Location = new Point((reference.Width - control.Width) / 2, (reference.Height - control.Height) / 2);
		}

		/// <summary>Center control horizontally and vertically inside reference, within the screen.</summary>
		public static void CenterBothInScreen(Control control, Control reference)
		{
			control.Location = new Point(reference.Location.X + (reference.Width - control.Width) / 2, reference.Location.Y + (reference.Height - control.Height) / 2);
		}
	}
}
