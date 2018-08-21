using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithoutHaste.Windows.GUI
{
	public class LayoutOptions
	{
		public enum PositionType {
			None=0,
			/// <summary>
			/// Position is based on ReferenceControl.ClientSize edges.
			/// </summary>
			InAbsolute,
			/// <summary>
			/// Works Like HTML float.
			/// Position is based on Controls already in ReferenceControl.
			/// Ex: Float left means place this to the right of the left-most control in the reference.
			/// </summary>
			InFloat,
			/// <summary>
			/// Exactly match the position of the reference.
			/// Ex: MatchLeft == use same Left location.
			/// </summary>
			Match,
			/// <summary>
			/// Place this control next to the reference.
			/// </summary>
			NextTo
		};

		private const int DEFAULT_MIN_DIMENSION = 20;

		public Control TopReference { get; protected set; }
		public PositionType TopPosition { get; protected set; }
		public int TopMargin { get; protected set; }
		public Control BottomReference { get; protected set; }
		public PositionType BottomPosition { get; protected set; }
		public int BottomMargin { get; protected set; }
		public Control LeftReference { get; protected set; }
		public PositionType LeftPosition { get; protected set; }
		public int LeftMargin { get; protected set; }
		public Control RightReference { get; protected set; }
		public PositionType RightPosition { get; protected set; }
		public int RightMargin { get; protected set; }
		public int? WidthMeasure { get; protected set; }
		public int? HeightMeasure { get; protected set; }

		public LayoutOptions()
		{
		}

		public LayoutOptions Top(Control reference, int margin)
		{
			SetTop(reference, PositionType.InAbsolute, margin);
			return this;
		}

		public LayoutOptions Top(Control reference)
		{
			SetTop(reference, PositionType.InAbsolute, 0);
			return this;
		}

		public LayoutOptions FloatTop(Control reference, int margin)
		{
			SetTop(reference, PositionType.InFloat, margin);
			return this;
		}

		public LayoutOptions FloatTop(Control reference)
		{
			SetTop(reference, PositionType.InFloat, 0);
			return this;
		}

		public LayoutOptions MatchTop(Control reference, int margin)
		{
			SetTop(reference, PositionType.Match, margin);
			return this;
		}

		public LayoutOptions MatchTop(Control reference)
		{
			SetTop(reference, PositionType.Match, 0);
			return this;
		}

		public LayoutOptions Below(Control reference, int margin)
		{
			SetTop(reference, PositionType.NextTo, margin);
			return this;
		}

		public LayoutOptions Below(Control reference)
		{
			SetTop(reference, PositionType.NextTo, 0);
			return this;
		}

		private void SetTop(Control reference, PositionType position, int margin)
		{
			TopReference = reference;
			TopPosition = position;
			TopMargin = margin;
		}

		public LayoutOptions Bottom(Control reference, int margin)
		{
			SetBottom(reference, PositionType.InAbsolute, margin);
			return this;
		}

		public LayoutOptions Bottom(Control reference)
		{
			SetBottom(reference, PositionType.InAbsolute, 0);
			return this;
		}

		public LayoutOptions FloatBottom(Control reference, int margin)
		{
			SetBottom(reference, PositionType.InFloat, margin);
			return this;
		}

		public LayoutOptions FloatBottom(Control reference)
		{
			SetBottom(reference, PositionType.InFloat, 0);
			return this;
		}

		public LayoutOptions MatchBottom(Control reference, int margin)
		{
			SetBottom(reference, PositionType.Match, margin);
			return this;
		}

		public LayoutOptions MatchBottom(Control reference)
		{
			SetBottom(reference, PositionType.Match, 0);
			return this;
		}

		public LayoutOptions Above(Control reference, int margin)
		{
			SetBottom(reference, PositionType.NextTo, margin);
			return this;
		}

		public LayoutOptions Above(Control reference)
		{
			SetBottom(reference, PositionType.NextTo, 0);
			return this;
		}

		private void SetBottom(Control reference, PositionType position, int margin)
		{
			BottomReference = reference;
			BottomPosition = position;
			BottomMargin = margin;
		}

		public LayoutOptions Left(Control reference, int margin)
		{
			SetLeft(reference, PositionType.InAbsolute, margin);
			return this;
		}

		public LayoutOptions Left(Control reference)
		{
			SetLeft(reference, PositionType.InAbsolute, 0);
			return this;
		}

		public LayoutOptions FloatLeft(Control reference, int margin)
		{
			SetLeft(reference, PositionType.InFloat, margin);
			return this;
		}

		public LayoutOptions FloatLeft(Control reference)
		{
			SetLeft(reference, PositionType.InFloat, 0);
			return this;
		}

		public LayoutOptions MatchLeft(Control reference, int margin)
		{
			SetLeft(reference, PositionType.Match, margin);
			return this;
		}

		public LayoutOptions MatchLeft(Control reference)
		{
			SetLeft(reference, PositionType.Match, 0);
			return this;
		}

		public LayoutOptions RightOf(Control reference, int margin)
		{
			SetLeft(reference, PositionType.NextTo, margin);
			return this;
		}

		public LayoutOptions RightOf(Control reference)
		{
			SetLeft(reference, PositionType.NextTo, 0);
			return this;
		}

		private void SetLeft(Control reference, PositionType position, int margin)
		{
			LeftReference = reference;
			LeftPosition = position;
			LeftMargin = margin;
		}

		public LayoutOptions Right(Control reference, int margin)
		{
			SetRight(reference, PositionType.InAbsolute, margin);
			return this;
		}

		public LayoutOptions Right(Control reference)
		{
			SetRight(reference, PositionType.InAbsolute, 0);
			return this;
		}

		public LayoutOptions FloatRight(Control reference, int margin)
		{
			SetRight(reference, PositionType.InFloat, margin);
			return this;
		}

		public LayoutOptions FloatRight(Control reference)
		{
			SetRight(reference, PositionType.InFloat, 0);
			return this;
		}

		public LayoutOptions MatchRight(Control reference, int margin)
		{
			SetRight(reference, PositionType.Match, margin);
			return this;
		}

		public LayoutOptions MatchRight(Control reference)
		{
			SetRight(reference, PositionType.Match, 0);
			return this;
		}

		public LayoutOptions LeftOf(Control reference, int margin)
		{
			SetRight(reference, PositionType.NextTo, margin);
			return this;
		}

		public LayoutOptions LeftOf(Control reference)
		{
			SetRight(reference, PositionType.NextTo, 0);
			return this;
		}

		private void SetRight(Control reference, PositionType position, int margin)
		{
			RightReference = reference;
			RightPosition = position;
			RightMargin = margin;
		}

		public LayoutOptions Width(int width)
		{
			WidthMeasure = width;
			return this;
		}

		public LayoutOptions Height(int height)
		{
			HeightMeasure = height;
			return this;
		}

		public void Apply(Control control)
		{
			int x = 0;
			int y = 0;
			switch(TopPosition)
			{
				case PositionType.None: break; 
				case PositionType.InAbsolute: y = TopMargin; break;
				case PositionType.InFloat: y = TopMargin + MaxChildY(TopReference); break;
				case PositionType.Match: y = TopMargin + TopReference.Location.Y; break;
				case PositionType.NextTo: y = TopReference.Location.Y + TopReference.Height + TopMargin; break;
				default: throw new Exception("Unknown Top position type: " + TopPosition); //todo specific exception
			}
			switch(LeftPosition)
			{
				case PositionType.None: break;
				case PositionType.InAbsolute: x = LeftMargin; break;
				case PositionType.InFloat: x = LeftMargin + MaxChildX(LeftReference); break;
				case PositionType.Match: x = LeftMargin + LeftReference.Location.X; break;
				case PositionType.NextTo: x = LeftReference.Location.X + LeftReference.Width + LeftMargin; break;
				default: throw new Exception("Unknown Left position type: " + LeftPosition); //todo specific exception
			}

			int width = WidthMeasure ?? DEFAULT_MIN_DIMENSION;
			int height = HeightMeasure ?? DEFAULT_MIN_DIMENSION;
			switch(BottomPosition)
			{
				case PositionType.None: break;
				case PositionType.InAbsolute:
					if(TopPosition == PositionType.None)
					{
						y = BottomReference.ClientSize.Height - BottomMargin - height;
					}
					else
					{
						height = BottomReference.ClientSize.Height - BottomMargin - y;
					}
					break;
				case PositionType.InFloat:
					if(TopPosition == PositionType.None)
					{
						y = MinChildY(BottomReference) - BottomMargin - height;
					}
					else
					{
						height = MinChildY(BottomReference) - BottomMargin - y;
					}
					break;
				case PositionType.Match:
					if(TopPosition == PositionType.None)
					{
						y = BottomReference.Location.Y + BottomReference.Height - BottomMargin - height;
					}
					else
					{
						height = BottomReference.Location.Y + BottomReference.Height - BottomMargin - y;
					}
					break;
				case PositionType.NextTo:
					if(TopPosition == PositionType.None)
					{
						y = BottomReference.Location.Y - BottomMargin - height;
					}
					else
					{
						height = BottomReference.Location.Y - BottomMargin - y;
					}
					break;
				default: throw new Exception("Unknown Bottom position type: " + BottomPosition); //todo specific exception
			}
			switch(RightPosition)
			{
				case PositionType.None: break;
				case PositionType.InAbsolute:
					if(LeftPosition == PositionType.None)
					{
						x = RightReference.ClientSize.Width - RightMargin - width;
					}
					else
					{
						width = RightReference.ClientSize.Width - RightMargin - x;
					}
					break;
				case PositionType.InFloat:
					if(LeftPosition == PositionType.None)
					{
						x = MinChildX(RightReference) - RightMargin - width;
					}
					else
					{
						width = MinChildX(RightReference) - RightMargin - x;
					}
					break;
				case PositionType.Match:
					if(LeftPosition == PositionType.None)
					{
						x = RightReference.Location.X + RightReference.Width - RightMargin - width;
					}
					else
					{
						width = RightReference.Location.X + RightReference.Width - RightMargin - x;
					}
					break;
				case PositionType.NextTo:
					if(LeftPosition == PositionType.None)
					{
						x = RightReference.Location.X - RightMargin - width;
					}
					else
					{
						width = RightReference.Location.X - RightMargin - x;
					}
					break;
				default: throw new Exception("Unknown Right position type: " + RightPosition); //todo specific exception
			}
			if(width < 0) throw new Exception("Width cannot be negative. "+width); //todo specific
			if(height < 0) throw new Exception("Height cannot be negative. "+height); //todo specific

			control.Location = new Point(x, y);
			control.Size = new Size(width, height);
		}

		private int MaxChildY(Control control)
		{
			if(control.Controls.Count == 0)
				return 0;
			return ToList(control.Controls).Max(child => child.Location.Y + child.Height);
		}

		private int MaxChildX(Control control)
		{
			if(control.Controls.Count == 0)
				return 0;
			return ToList(control.Controls).Max(child => child.Location.X + child.Width);
		}

		private int MinChildY(Control control)
		{
			if(control.Controls.Count == 0)
				return 0;
			return ToList(control.Controls).Min(child => child.Location.Y);
		}

		private int MinChildX(Control control)
		{
			if(control.Controls.Count == 0)
				return 0;
			return ToList(control.Controls).Min(child => child.Location.X);
		}

		private static List<Control> ToList(Control.ControlCollection collection)
		{
			List<Control> list = new List<Control>();
			list.AddRange(collection.OfType<Control>());
			return list;
		}
	}
}
