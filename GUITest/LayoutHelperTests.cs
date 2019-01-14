using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithoutHaste.Windows.GUI;

namespace GUITest
{
	[TestClass]
	public class LayoutHelperTests
	{
		[TestMethod]
		public void LayoutHelper_CenterWidth()
		{
			//assemble
			Form form = new Form() {
				Width = 300,
				Height = 150,
			};
			int margin = 10;
			int buttonWidth = 50;
			LayoutOptions options = LayoutHelper.Bottom(form, margin).CenterWidth(form, buttonWidth).Height(20);
			Button button = new Button();
			//act
			options.Apply(button);
			//assert
			Assert.AreEqual((form.ClientSize.Width - buttonWidth) / 2, button.Location.X);
		}
	}
}
