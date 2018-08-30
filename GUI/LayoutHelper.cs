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
	/// <para>Helper for placing and sizing controls in a Form relative to each other.</para>
	/// <para>Uses method chaining for a fluent writing style. Location and sizing methods can be chained in any order. Apply must be the last command.</para>
	/// <para>Add the control to its parent after using LayoutHelper.</para>
	/// <para>All methods in <see cref="LayoutOptions"/> can also be called on LayoutHelper.</para>
	/// </summary>
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
	}
}
