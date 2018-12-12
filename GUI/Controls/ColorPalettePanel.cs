using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithoutHaste.Drawing.Colors;

namespace WithoutHaste.Windows.GUI
{
	/// <summary>
	/// Control for displaying a <see cref="WithoutHaste.Drawing.Colors.ColorPalette" url="https://github.com/WithoutHaste/WithoutHaste.Drawing.Colors/blob/master/"/>.
	/// </summary>
	/// <remarks>
	/// <para>The palette is displayed as a series of color swatches. Swatches auto-fill available space left-to-right and top-to-bottom. The swatches will auto-scroll as needed.</para>
	/// <para>The user can click on a color swatch to select its color.</para>
	/// </remarks>
	/// <example>
	///  <code>
	///ColorPalettePanel panel = new ColorPalettePanel(myColorPalette) {
	///	Location = new Point(10, 10),
	///	Size = new Size(150, 200)
	///};
	///form.Controls.Add(panel);
	///  </code>
	/// </example>
	public class ColorPalettePanel : FlowLayoutPanel
	{
		/// <summary>Width of vertical scroll bar.</summary>
		public static readonly int SCROLLBAR_WIDTH = System.Windows.Forms.SystemInformation.VerticalScrollBarWidth + 5;
		/// <summary>Width and height of each color swatch.</summary>
		public static readonly int SWATCH_WIDTH = 25;

		private ContextMenu colorContextMenu;

		/// <summary>Triggers when the user selects a color.</summary>
		public event EventHandler ColorChanged;

		private Color? selectedColor = null;
		/// <summary></summary>
		public Color? SelectedColor {
			get {
				return selectedColor;
			}
			set {
				if(value == null)
				{
					selectedColor = null;
					UpdateDisplay();
				}
				else if(ColorIsInPalette(value.Value))
				{
					selectedColor = value;
					UpdateDisplay();
				}
			}
		}

		/// <summary></summary>
		public ColorPalettePanel()
		{
			Init();
		}

		/// <summary></summary>
		/// <param name="colorPalette">Color palette to display.</param>
		/// <param name="colorContextMenu">Optional context menu to apply to each color swatch.</param>
		public ColorPalettePanel(ColorPalette colorPalette, ContextMenu colorContextMenu = null)
		{
			Init();
			this.colorContextMenu = colorContextMenu;
			DisplayColors(colorPalette);
		}

		private void Init()
		{
			this.AutoScroll = true;
			this.BorderStyle = BorderStyle.Fixed3D;
		}

		/// <summary>Set the color palette to display in the panel.</summary>
		public void DisplayColors(ColorPalette colorPalette)
		{
			this.SuspendLayout();

			this.Controls.Clear();
			int count = 0;
			foreach(Color color in colorPalette.Colors)
			{
				if(selectedColor == null)
				{
					selectedColor = color;
				}

				Panel colorPanel = new Panel();
				colorPanel.TabIndex = count; //corresponds to index in color palette
				colorPanel.Size = new Size(SWATCH_WIDTH, SWATCH_WIDTH);
				colorPanel.Padding = new Padding(0);
				colorPanel.Margin = new Padding(0);
				colorPanel.BackColor = color;
				if(color == selectedColor)
				{
					colorPanel.BackgroundImage = IconManager.SWATCH_SELECTOR;
					colorPanel.BackgroundImageLayout = ImageLayout.Stretch;
				}
				colorPanel.Cursor = Cursors.Hand;
				colorPanel.Click += new EventHandler(Color_OnClick);
				if(colorContextMenu != null)
				{
					colorPanel.ContextMenu = colorContextMenu;
				}
				this.Controls.Add(colorPanel);
				count++;
			}

			this.ResumeLayout();
		}

		private void Color_OnClick(object sender, EventArgs e)
		{
			selectedColor = (sender as Panel).BackColor;
			UpdateDisplay();
			if(ColorChanged != null)
			{
				ColorChanged(this, new EventArgs());
			}
		}

		private void UpdateDisplay()
		{
			Control selectedControl = null;
			foreach(Control child in this.Controls)
			{
				if(child.BackColor == selectedColor)
				{
					child.BackgroundImage = IconManager.SWATCH_SELECTOR;
					selectedControl = child;
				}
				else
				{
					child.BackgroundImage = null;
				}
			}
			if(selectedControl != null)
			{
				this.ScrollControlIntoView(selectedControl);
			}
		}

		private bool ColorIsInPalette(Color color)
		{
			foreach(Control child in this.Controls)
			{
				if(child.BackColor == selectedColor)
				{
					return true;
				}
			}
			return false;
		}
	}
}
