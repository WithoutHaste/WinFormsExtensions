# LayoutOptions

These operations are intended to be used from [LayoutHelper](LayoutHelper.md).

This object will collect commands for how to position and size a control, and then apply those commands all at once.

Base Type: System.Object

## Constructors

### LayoutOptions()

## Methods

### LayoutOptions Top(System.Windows.Forms.Control reference, System.Int32 margin)

Place at top of reference with this margin.

### LayoutOptions Top(System.Windows.Forms.Control reference)

Place at top of reference.

### LayoutOptions FloatTop(System.Windows.Forms.Control reference, System.Int32 margin)

Float towards top of reference with this margin.

### LayoutOptions FloatTop(System.Windows.Forms.Control reference)

Float towards top of reference.

### LayoutOptions MatchTop(System.Windows.Forms.Control reference, System.Int32 margin)

Align with top of reference with this margin.

### LayoutOptions MatchTop(System.Windows.Forms.Control reference)

Align with top of reference.

### LayoutOptions Below(System.Windows.Forms.Control reference, System.Int32 margin)

Place below reference with this margin.

### LayoutOptions Below(System.Windows.Forms.Control reference)

Place below reference.

### LayoutOptions Bottom(System.Windows.Forms.Control reference, System.Int32 margin)

Place at bottom of reference with this margin.

### LayoutOptions Bottom(System.Windows.Forms.Control reference)

Place at bottom of reference.

### LayoutOptions FloatBottom(System.Windows.Forms.Control reference, System.Int32 margin)

Float towards bottom of reference with this margin.

### LayoutOptions FloatBottom(System.Windows.Forms.Control reference)

Float towards bottom of reference.

### LayoutOptions MatchBottom(System.Windows.Forms.Control reference, System.Int32 margin)

Align with bottom of reference with this margin.

### LayoutOptions MatchBottom(System.Windows.Forms.Control reference)

Align with bottom of reference.

### LayoutOptions Above(System.Windows.Forms.Control reference, System.Int32 margin)

Place above reference with this margin.

### LayoutOptions Above(System.Windows.Forms.Control reference)

Place above reference.

### LayoutOptions Left(System.Windows.Forms.Control reference, System.Int32 margin)

Place at left-side of reference with this margin.

### LayoutOptions Left(System.Windows.Forms.Control reference)

Place at left-side of reference.

### LayoutOptions FloatLeft(System.Windows.Forms.Control reference, System.Int32 margin)

Float towards left-side of reference with this margin.

### LayoutOptions FloatLeft(System.Windows.Forms.Control reference)

Float towards left-side of reference.

### LayoutOptions MatchLeft(System.Windows.Forms.Control reference, System.Int32 margin)

Align with left of reference with this margin.

### LayoutOptions MatchLeft(System.Windows.Forms.Control reference)

Align with left of reference.

### LayoutOptions RightOf(System.Windows.Forms.Control reference, System.Int32 margin)

Place to the right of the reference with this margin.

### LayoutOptions RightOf(System.Windows.Forms.Control reference)

Place to the right of the reference.

### LayoutOptions Right(System.Windows.Forms.Control reference, System.Int32 margin)

Place at right-side of reference with this margin.

### LayoutOptions Right(System.Windows.Forms.Control reference)

Place at right-side of reference.

### LayoutOptions FloatRight(System.Windows.Forms.Control reference, System.Int32 margin)

Float towards right-side of reference with this margin.

### LayoutOptions FloatRight(System.Windows.Forms.Control reference)

Float towards right-side of reference.

### LayoutOptions MatchRight(System.Windows.Forms.Control reference, System.Int32 margin)

Align with right of reference with this margin.

### LayoutOptions MatchRight(System.Windows.Forms.Control reference)

Align with right of reference.

### LayoutOptions LeftOf(System.Windows.Forms.Control reference, System.Int32 margin)

Place to the left of the reference with this margin.

### LayoutOptions LeftOf(System.Windows.Forms.Control reference)

Place to the left of the reference.

### LayoutOptions Fill(System.Windows.Forms.Control reference, System.Int32 margin)

Fill reference to the left, right, top, and bottom, with this margin.

### LayoutOptions Fill(System.Windows.Forms.Control reference)

Fill reference to the left, right, top, and bottom.

### LayoutOptions Width(System.Int32 width)

Set the width of the control directly.

### LayoutOptions CenterWidth(System.Windows.Forms.Control reference, System.Int32 width)

Set the width of the control directly and specify that it should be horizontal-centered in its parent.

### LayoutOptions Height(System.Int32 height)

Set the height of the control directly.

### LayoutOptions CenterHeight(System.Windows.Forms.Control reference, System.Int32 height)

Set the height of the control directly and specify that it should be vertical-centered in its parent.

### Void Apply(System.Windows.Forms.Control control)

Apply settings to control.

