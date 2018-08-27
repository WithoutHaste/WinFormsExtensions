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
	internal class SaturationValueGradientPanel : Panel
	{
		private int hue;
		public int Hue {
			set {
				hue = value;
				this.Invalidate();
			}
		}

		private int saturation;
		public int Saturation {
			get {
				return saturation;
			}
			set {
				saturation = value;
			}
		}

		private int _value;
		public int Value {
			get {
				return _value;
			}
			set {
				_value = value;
			}
		}

		public event EventHandler ColorChanged;

		private int swatchWidth;
		private Bitmap graphicsBitmap;

		public SaturationValueGradientPanel(int width)
		{
			this.Width = width;
			this.Height = width;
			this.Click += new EventHandler(Gradient_OnClick);

			swatchWidth = this.Width / 101;
			hue = 0;
			saturation = 0;
			_value = 0;
		}

		private void Gradient_OnClick(object sender, EventArgs e)
		{
			Point clickPoint = this.PointToClient(new Point(MousePosition.X, MousePosition.Y));
			Color color = graphicsBitmap.GetPixel(clickPoint.X, clickPoint.Y);
			HSV hsv = ConvertColors.ToHSV(color);
			saturation = (int)(100 * hsv.Saturation);
			_value = (int)(100 * hsv.Value);
			if(ColorChanged != null)
			{
				ColorChanged(this, new EventArgs());
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			graphicsBitmap = new Bitmap(this.Width, this.Height);
			using(Graphics gBitmap = Graphics.FromImage(graphicsBitmap))
			{
				for(int saturation = 0; saturation <= 100; saturation++)
				{
					for(int value = 0; value <= 100; value++)
					{
						int reverseValue = 100 - value;
						Color color = ConvertColors.ToColor(new HSV(hue, saturation / 100f, reverseValue / 100f));
						SolidBrush brush = new SolidBrush(color);
						gBitmap.FillRectangle(brush, new Rectangle(saturation * swatchWidth, value * swatchWidth, swatchWidth, swatchWidth));
					}
				}
			}

			e.Graphics.DrawImage(graphicsBitmap, 0, 0);
		}
	}
}
