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
	class NewColorDialog : Form
	{
		private HuePanel huePanel;
		private SaturationValuePanel saturationValuePanel;
		private ColorDataPanel colorDataPanel;
		private Panel selectedColorPanel;

		public Color Color { get; protected set; }

		public NewColorDialog(Color? startColor = null)
		{
			int margin = 10;
			if(startColor.HasValue)
			{
				Color = startColor.Value;
			}

			this.Width = (HuePanel.UNIT + margin + margin/*why second margin needed?*/) * 2;
			this.Height = 500 + margin;
			this.Text = "New Color";
			this.FormBorderStyle = FormBorderStyle.FixedSingle; //disable resize
			this.MinimizeBox = false;
			this.MaximizeBox = false;

			huePanel = new HuePanel(Color);
			huePanel.Location = new Point(margin, margin);
			huePanel.ColorChanged += new EventHandler(Hue_OnChange);
			this.Controls.Add(huePanel);

			saturationValuePanel = new SaturationValuePanel(Color);
			saturationValuePanel.Location = new Point(margin, huePanel.Location.Y + huePanel.Height + margin);
			saturationValuePanel.ColorChanged += new EventHandler(SaturationValue_OnChange);
			this.Controls.Add(saturationValuePanel);

			Button okButton = new Button();
			LayoutHelper.RightOf(saturationValuePanel, margin).Bottom(this, margin).Width(100).Height(25).Apply(okButton);
			okButton.Text = "Ok";
			okButton.Click += new EventHandler(Ok_OnClick);
			this.Controls.Add(okButton);

			Button cancelButton = new Button();
			LayoutHelper.RightOf(okButton, margin).Bottom(this, margin).Width(100).Height(25).Apply(cancelButton);
			cancelButton.Text = "Cancel";
			cancelButton.Click += new EventHandler(Cancel_OnClick);
			this.Controls.Add(cancelButton);

			colorDataPanel = new ColorDataPanel(readOnly: false);
			LayoutHelper.Above(okButton, margin).Right(this, margin).Below(huePanel).Width(150).Apply(colorDataPanel);
			colorDataPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			colorDataPanel.ColorChanged += new ColorEventHandler(ColorData_OnChange);
			this.Controls.Add(colorDataPanel);

			selectedColorPanel = new Panel();
			LayoutHelper.RightOf(saturationValuePanel, margin).Below(huePanel, margin).LeftOf(colorDataPanel).Above(okButton, margin).Apply(selectedColorPanel);
			UpdateSelectedColor();
			this.Controls.Add(selectedColorPanel);
		}

		private void Ok_OnClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Cancel_OnClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void Hue_OnChange(object sender, EventArgs e)
		{
			saturationValuePanel.Hue = huePanel.Hue;
			UpdateSelectedColor();
		}

		private void SaturationValue_OnChange(object sender, EventArgs e)
		{
			UpdateSelectedColor();
		}

		private void ColorData_OnChange(object sender, ColorEventArgs e)
		{
			colorDataPanel.IgnoreChanges = true;

			Color = e.Color;
			selectedColorPanel.BackColor = e.Color;
			huePanel.Color = e.Color;
			saturationValuePanel.Color = e.Color;

			colorDataPanel.IgnoreChanges = false;
		}

		private void UpdateSelectedColor()
		{
			Color = ConvertColors.ColorFromHSV(new HSV(huePanel.Hue, saturationValuePanel.Saturation / 100f, saturationValuePanel.Value / 100f));
			selectedColorPanel.BackColor = Color;
			colorDataPanel.Color = Color;
		}
	}
}
