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
	internal class HuePanel : Panel
	{
		public const int UNIT = 360;
		private const int TRACKBAR_HEIGHT = 45;

		private TrackBar trackBar;

		public int Hue {
			get {
				return trackBar.Value;
			}
			set {
				trackBar.Value = value;
			}
		}

		public Color Color {
			set {
				Hue = (int)ConvertColors.HSVFromColor(value).Hue;
			}
		}

		public event EventHandler ColorChanged;

		public HuePanel(Color? startColor = null)
		{
			this.Height = TRACKBAR_HEIGHT + 50;
			this.Width = UNIT * 2;
			this.BorderStyle = BorderStyle.Fixed3D;

			trackBar = new TrackBar();
			trackBar.Location = new Point(0, 0);
			trackBar.Size = new Size(this.Width, TRACKBAR_HEIGHT);
			trackBar.Minimum = 0;
			trackBar.Maximum = 359;
			trackBar.ValueChanged += new EventHandler(TrackBar_OnValueChanged);
			this.Controls.Add(trackBar);

			int swatchWidth = this.Width / UNIT;
			int swatchY = trackBar.Location.Y + trackBar.Height;
			for(int hue = 0; hue < 360; hue++)
			{
				Panel colorPanel = new Panel();
				colorPanel.Location = new Point(hue * swatchWidth, swatchY);
				colorPanel.Size = new Size(swatchWidth, this.Height);
				colorPanel.BackColor = ConvertColors.ColorFromHSV(new HSV(hue, 1, 1));
				colorPanel.Click += new EventHandler(Color_OnClick);
				this.Controls.Add(colorPanel);
			}

			if(startColor.HasValue)
			{
				Hue = (int)ConvertColors.HSVFromColor(startColor.Value).Hue;
			}
		}

		private void Color_OnClick(object sender, EventArgs e)
		{
			Panel panel = sender as Panel;
			HSV hsv = ConvertColors.HSVFromColor(panel.BackColor);
			Hue = (int)hsv.Hue;
		}

		private void TrackBar_OnValueChanged(object sender, EventArgs e)
		{
			if(ColorChanged != null)
			{
				ColorChanged(this, new EventArgs());
			}
		}
	}
}
