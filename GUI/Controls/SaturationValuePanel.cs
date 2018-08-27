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
	internal class SaturationValuePanel : Panel
	{
		public const int UNIT = 101;
		private const int TRACKBAR_HEIGHT = 45;

		private TrackBar saturationTrackBar;
		private TrackBar valueTrackBar;
		private SaturationValueGradientPanel gradientPanel;

		public event EventHandler ColorChanged;

		public int Saturation {
			get {
				return saturationTrackBar.Value;
			}
			set {
				saturationTrackBar.Value = value;
			}
		}

		public int Value {
			get {
				return valueTrackBar.Value;
			}
			set {
				valueTrackBar.Value = value;
			}
		}

		public Color Color {
			set {
				HSV hsv = ConvertColors.ToHSV(value);
				Saturation = (int)(hsv.Saturation * 100);
				Value = (int)(hsv.Value * 100);
			}
		}

		private int hue;
		public int Hue {
			get {
				return hue;
			}
			set {
				hue = value;
				gradientPanel.Hue = hue;
			}
		}

		public SaturationValuePanel(Color? startColor = null)
		{
			int totalColorHeight = UNIT * 3;

			this.Height = TRACKBAR_HEIGHT + totalColorHeight;
			this.Width = TRACKBAR_HEIGHT + totalColorHeight;
			this.BorderStyle = BorderStyle.Fixed3D;

			saturationTrackBar = new TrackBar();
			saturationTrackBar.Location = new Point(TRACKBAR_HEIGHT, 0);
			saturationTrackBar.Size = new Size(totalColorHeight, TRACKBAR_HEIGHT);
			saturationTrackBar.Minimum = 0;
			saturationTrackBar.Maximum = 100;
			saturationTrackBar.ValueChanged += new EventHandler(Saturation_OnValueChanged);
			this.Controls.Add(saturationTrackBar);

			valueTrackBar = new TrackBar();
			valueTrackBar.Location = new Point(0, TRACKBAR_HEIGHT);
			valueTrackBar.Size = new Size(TRACKBAR_HEIGHT, totalColorHeight);
			valueTrackBar.Minimum = 0;
			valueTrackBar.Maximum = 100;
			valueTrackBar.Orientation = Orientation.Vertical;
			valueTrackBar.ValueChanged += new EventHandler(Value_OnValueChanged);
			this.Controls.Add(valueTrackBar);

			gradientPanel = new SaturationValueGradientPanel(totalColorHeight);
			gradientPanel.Location = new Point(TRACKBAR_HEIGHT, TRACKBAR_HEIGHT);
			gradientPanel.ColorChanged += new EventHandler(Gradient_OnColorChange);
			this.Controls.Add(gradientPanel);

			if(startColor.HasValue)
			{
				HSV hsv = ConvertColors.ToHSV(startColor.Value);
				Hue = (int)hsv.Hue;
				Saturation = (int)(hsv.Saturation * 100);
				Value = (int)(hsv.Value * 100);
			}
		}

		private void Gradient_OnColorChange(object sender, EventArgs e)
		{
			Saturation = gradientPanel.Saturation;
			Value = gradientPanel.Value;
		}

		private void Saturation_OnValueChanged(object sender, EventArgs e)
		{
			if(ColorChanged != null)
			{
				ColorChanged(this, new EventArgs());
			}
		}

		private void Value_OnValueChanged(object sender, EventArgs e)
		{
			if(ColorChanged != null)
			{
				ColorChanged(this, new EventArgs());
			}
		}
	}
}
