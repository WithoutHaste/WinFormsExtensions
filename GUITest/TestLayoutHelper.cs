using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithoutHaste.Windows.GUI;

namespace GUITest
{
	[TestClass]
	public class TestLayoutHelper
	{
		[TestMethod]
		public void LayoutHelper_StretchVerticalBelowToolstrip()
		{
			//assemble
			Form form = new Form() {
				Width = 800,
				Height = 600,
			};
			ToolStrip toolStrip = new ToolStrip();
			toolStrip.Dock = DockStyle.Top;
			form.Controls.Add(toolStrip);
			Panel panel = new Panel();
			LayoutOptions options = LayoutHelper.Below(toolStrip).Left(form).Bottom(form).Width(20);
			//act
			options.Apply(panel);
			//assert

		}
	}
}
