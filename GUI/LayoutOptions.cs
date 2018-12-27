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
	/// These operations are intended to be used from <see cref="LayoutHelper"/>.
	/// </summary>
	/// <remarks>This object will collect commands for how to position and size a control, and then apply those commands all at once.</remarks>
	/// <layout methods="keep_order"/>
	public class LayoutOptions
	{
		/// <summary>Ways of defining a measurement.</summary>
		public enum MeasureType {
			/// <summary></summary>
			None = 0,
			/// <summary>Measurement is exact.</summary>
			Absolute,
			/// <summary>Measurement matches a reference value.</summary>
			Match,
		};

		/// <summary>Ways of defining a position relative to another item.</summary>
		public enum PositionType {
			/// <summary></summary>
			None=0,
			/// <summary>Position is based on ReferenceControl.ClientSize edges.</summary>
			InAbsolute,
			/// <summary>
			/// Works Like HTML float. Position is based on Controls already in ReferenceControl.
			/// </summary>
			/// <example>Float left means place this to the right of the left-most control in the reference.</example>
			InFloat,
			/// <summary>
			/// Exactly match the position of the reference.
			/// </summary>
			/// <example>MatchLeft means use same Left location as the reference control.</example>
			Match,
			/// <summary>
			/// Place this control next to the reference.
			/// </summary>
			NextTo
		};

		private const int DEFAULT_MIN_DIMENSION = 20;

		/// <summary></summary>
		public Control TopReference { get; protected set; }
		/// <summary></summary>
		public PositionType TopPosition { get; protected set; }
		/// <summary></summary>
		public int TopMargin { get; protected set; }

		/// <summary></summary>
		public Control BottomReference { get; protected set; }
		/// <summary></summary>
		public PositionType BottomPosition { get; protected set; }
		/// <summary></summary>
		public int BottomMargin { get; protected set; }

		/// <summary></summary>
		public Control LeftReference { get; protected set; }
		/// <summary></summary>
		public PositionType LeftPosition { get; protected set; }
		/// <summary></summary>
		public int LeftMargin { get; protected set; }

		/// <summary></summary>
		public Control RightReference { get; protected set; }
		/// <summary></summary>
		public PositionType RightPosition { get; protected set; }
		/// <summary></summary>
		public int RightMargin { get; protected set; }

		/// <summary></summary>
		public Control WidthReference { get; protected set; }
		/// <summary></summary>
		public MeasureType WidthType { get; protected set; }
		/// <summary></summary>
		public int? WidthMeasure { get; protected set; }
		/// <summary></summary>
		public bool WidthCentered { get; protected set; }

		/// <summary></summary>
		public Control HeightReference { get; protected set; }
		/// <summary></summary>
		public MeasureType HeightType { get; protected set; }
		/// <summary></summary>
		public int? HeightMeasure { get; protected set; }
		/// <summary></summary>
		public bool HeightCentered { get; protected set; }

		/// <summary></summary>
		public LayoutOptions()
		{
		}

		/// <summary>Place at top of reference with this margin.</summary>
		public LayoutOptions Top(Control reference, int margin)
		{
			SetTop(reference, PositionType.InAbsolute, margin);
			return this;
		}

		/// <summary>Place at top of reference.</summary>
		public LayoutOptions Top(Control reference)
		{
			SetTop(reference, PositionType.InAbsolute, 0);
			return this;
		}

		/// <summary>Float towards top of reference with this margin.</summary>
		public LayoutOptions FloatTop(Control reference, int margin)
		{
			SetTop(reference, PositionType.InFloat, margin);
			return this;
		}

		/// <summary>Float towards top of reference.</summary>
		public LayoutOptions FloatTop(Control reference)
		{
			SetTop(reference, PositionType.InFloat, 0);
			return this;
		}

		/// <summary>Align with top of reference with this margin.</summary>
		public LayoutOptions MatchTop(Control reference, int margin)
		{
			SetTop(reference, PositionType.Match, margin);
			return this;
		}

		/// <summary>Align with top of reference.</summary>
		public LayoutOptions MatchTop(Control reference)
		{
			SetTop(reference, PositionType.Match, 0);
			return this;
		}

		/// <summary>Place below reference with this margin.</summary>
		public LayoutOptions Below(Control reference, int margin)
		{
			SetTop(reference, PositionType.NextTo, margin);
			return this;
		}

		/// <summary>Place directly below reference.</summary>
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

		/// <summary>Place at bottom of reference with this margin.</summary>
		public LayoutOptions Bottom(Control reference, int margin)
		{
			SetBottom(reference, PositionType.InAbsolute, margin);
			return this;
		}

		/// <summary>Place at bottom of reference.</summary>
		public LayoutOptions Bottom(Control reference)
		{
			SetBottom(reference, PositionType.InAbsolute, 0);
			return this;
		}

		/// <summary>Float towards bottom of reference with this margin.</summary>
		public LayoutOptions FloatBottom(Control reference, int margin)
		{
			SetBottom(reference, PositionType.InFloat, margin);
			return this;
		}

		/// <summary>Float towards bottom of reference.</summary>
		public LayoutOptions FloatBottom(Control reference)
		{
			SetBottom(reference, PositionType.InFloat, 0);
			return this;
		}

		/// <summary>Align with bottom of reference with this margin.</summary>
		public LayoutOptions MatchBottom(Control reference, int margin)
		{
			SetBottom(reference, PositionType.Match, margin);
			return this;
		}

		/// <summary>Align with bottom of reference.</summary>
		public LayoutOptions MatchBottom(Control reference)
		{
			SetBottom(reference, PositionType.Match, 0);
			return this;
		}

		/// <summary>Place above reference with this margin.</summary>
		public LayoutOptions Above(Control reference, int margin)
		{
			SetBottom(reference, PositionType.NextTo, margin);
			return this;
		}

		/// <summary>Place directly above reference.</summary>
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

		/// <summary>Place at left-side of reference with this margin.</summary>
		public LayoutOptions Left(Control reference, int margin)
		{
			SetLeft(reference, PositionType.InAbsolute, margin);
			return this;
		}

		/// <summary>Place at left-side of reference.</summary>
		public LayoutOptions Left(Control reference)
		{
			SetLeft(reference, PositionType.InAbsolute, 0);
			return this;
		}

		/// <summary>Float towards left-side of reference with this margin.</summary>
		public LayoutOptions FloatLeft(Control reference, int margin)
		{
			SetLeft(reference, PositionType.InFloat, margin);
			return this;
		}

		/// <summary>Float towards left-side of reference.</summary>
		public LayoutOptions FloatLeft(Control reference)
		{
			SetLeft(reference, PositionType.InFloat, 0);
			return this;
		}

		/// <summary>Align with left of reference with this margin.</summary>
		public LayoutOptions MatchLeft(Control reference, int margin)
		{
			SetLeft(reference, PositionType.Match, margin);
			return this;
		}

		/// <summary>Align with left of reference.</summary>
		public LayoutOptions MatchLeft(Control reference)
		{
			SetLeft(reference, PositionType.Match, 0);
			return this;
		}

		/// <summary>Place to the right of the reference with this margin.</summary>
		public LayoutOptions RightOf(Control reference, int margin)
		{
			SetLeft(reference, PositionType.NextTo, margin);
			return this;
		}

		/// <summary>Place to the right of the reference.</summary>
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

		/// <summary>Place at right-side of reference with this margin.</summary>
		public LayoutOptions Right(Control reference, int margin)
		{
			SetRight(reference, PositionType.InAbsolute, margin);
			return this;
		}

		/// <summary>Place at right-side of reference.</summary>
		public LayoutOptions Right(Control reference)
		{
			SetRight(reference, PositionType.InAbsolute, 0);
			return this;
		}

		/// <summary>Float towards right-side of reference with this margin.</summary>
		public LayoutOptions FloatRight(Control reference, int margin)
		{
			SetRight(reference, PositionType.InFloat, margin);
			return this;
		}

		/// <summary>Float towards right-side of reference.</summary>
		public LayoutOptions FloatRight(Control reference)
		{
			SetRight(reference, PositionType.InFloat, 0);
			return this;
		}

		/// <summary>Align with right of reference with this margin.</summary>
		public LayoutOptions MatchRight(Control reference, int margin)
		{
			SetRight(reference, PositionType.Match, margin);
			return this;
		}

		/// <summary>Align with right of reference.</summary>
		public LayoutOptions MatchRight(Control reference)
		{
			SetRight(reference, PositionType.Match, 0);
			return this;
		}

		/// <summary>Place to the left of the reference with this margin.</summary>
		public LayoutOptions LeftOf(Control reference, int margin)
		{
			SetRight(reference, PositionType.NextTo, margin);
			return this;
		}

		/// <summary>Place to the left of the reference.</summary>
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

		/// <summary>Fill reference to the left, right, top, and bottom, with this margin.</summary>
		public LayoutOptions Fill(Control reference, int margin)
		{
			SetTop(reference, PositionType.InAbsolute, margin);
			SetBottom(reference, PositionType.InAbsolute, margin);
			SetLeft(reference, PositionType.InAbsolute, margin);
			SetRight(reference, PositionType.InAbsolute, margin);
			return this;
		}

		/// <summary>Fill reference to the left, right, top, and bottom.</summary>
		public LayoutOptions Fill(Control reference)
		{
			SetTop(reference, PositionType.InAbsolute, 0);
			SetBottom(reference, PositionType.InAbsolute, 0);
			SetLeft(reference, PositionType.InAbsolute, 0);
			SetRight(reference, PositionType.InAbsolute, 0);
			return this;
		}

		/// <summary>Set the width of the control directly.</summary>
		public LayoutOptions Width(int width)
		{
			WidthReference = null;
			WidthType = MeasureType.Absolute;
			WidthMeasure = width;
			WidthCentered = false;
			return this;
		}

		/// <summary>Set the width of the control directly and specify that it should be horizontal-centered in its parent.</summary>
		public LayoutOptions CenterWidth(Control reference, int width)
		{
			WidthReference = reference;
			WidthType = MeasureType.Absolute;
			WidthMeasure = width;
			WidthCentered = true;
			return this;
		}

		/// <summary>Set the width of the control to match the reference.</summary>
		public LayoutOptions MatchWidth(Control reference)
		{
			WidthReference = reference;
			WidthType = MeasureType.Match;
			WidthCentered = false;
			return this;
		}

		/// <summary>Set the height of the control directly.</summary>
		public LayoutOptions Height(int height)
		{
			HeightReference = null;
			HeightType = MeasureType.Absolute;
			HeightMeasure = height;
			HeightCentered = false;
			return this;
		}

		/// <summary>Set the height of the control directly and specify that it should be vertical-centered in its parent.</summary>
		public LayoutOptions CenterHeight(Control reference, int height)
		{
			HeightReference = reference;
			HeightType = MeasureType.Absolute;
			HeightMeasure = height;
			HeightCentered = true;
			return this;
		}

		/// <summary>Set the height of the control to match the reference.</summary>
		public LayoutOptions MatchHeight(Control reference)
		{
			HeightReference = reference;
			HeightType = MeasureType.Match;
			HeightCentered = false;
			return this;
		}

		/// <summary>Apply settings to control.</summary>
		public void Apply(Control control)
		{
			if(WidthType == MeasureType.Match)
				WidthMeasure = WidthReference.Width;
			if(HeightType == MeasureType.Match)
				HeightMeasure = HeightReference.Height;

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

			if(WidthCentered)
			{
				x = (WidthReference.ClientSize.Width / 2) - (width / 2);
			}
			if(HeightCentered)
			{
				y = (HeightReference.ClientSize.Height / 2) - (height / 2);
			}

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
