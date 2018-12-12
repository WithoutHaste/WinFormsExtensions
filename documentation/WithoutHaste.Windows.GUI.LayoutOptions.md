# [WithoutHaste.Windows.GUI](TableOfContents.WithoutHaste.Windows.GUI.md).LayoutOptions

**Inheritance:** object  

These operations are intended to be used from [LayoutHelper](WithoutHaste.Windows.GUI.LayoutHelper.md).  

**Remarks:**  
This object will collect commands for how to position and size a control, and then apply those commands all at once.  

# Enums

**[PositionType](WithoutHaste.Windows.GUI.LayoutOptions.PositionType.md)**  
Ways of defining a position relative to another item.  

* 0: None  
* 1: InAbsolute  
* 2: InFloat  
* 3: Match  
* 4: NextTo  

# Properties

## BottomMargin

**int { public get; protected set; }**  

## BottomPosition

**[PositionType](WithoutHaste.Windows.GUI.LayoutOptions.PositionType.md) { public get; protected set; }**  

## BottomReference

**[System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) { public get; protected set; }**  

## HeightCentered

**bool { public get; protected set; }**  

## HeightMeasure

**[Nullable&lt;int&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) { public get; protected set; }**  

## HeightReference

**[System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) { public get; protected set; }**  

## LeftMargin

**int { public get; protected set; }**  

## LeftPosition

**[PositionType](WithoutHaste.Windows.GUI.LayoutOptions.PositionType.md) { public get; protected set; }**  

## LeftReference

**[System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) { public get; protected set; }**  

## RightMargin

**int { public get; protected set; }**  

## RightPosition

**[PositionType](WithoutHaste.Windows.GUI.LayoutOptions.PositionType.md) { public get; protected set; }**  

## RightReference

**[System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) { public get; protected set; }**  

## TopMargin

**int { public get; protected set; }**  

## TopPosition

**[PositionType](WithoutHaste.Windows.GUI.LayoutOptions.PositionType.md) { public get; protected set; }**  

## TopReference

**[System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) { public get; protected set; }**  

## WidthCentered

**bool { public get; protected set; }**  

## WidthMeasure

**[Nullable&lt;int&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) { public get; protected set; }**  

## WidthReference

**[System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) { public get; protected set; }**  

# Constructors

## LayoutOptions()

# Methods

## Above([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Place above reference with this margin.  

## Above([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Place directly above reference.  

## Apply([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) control)

**void**  

Apply settings to control.  

## Below([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Place below reference with this margin.  

## Below([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Place directly below reference.  

## Bottom([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Place at bottom of reference with this margin.  

## Bottom([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Place at bottom of reference.  

## CenterHeight([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int height)

**LayoutOptions**  

Set the height of the control directly and specify that it should be vertical-centered in its parent.  

## CenterWidth([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int width)

**LayoutOptions**  

Set the width of the control directly and specify that it should be horizontal-centered in its parent.  

## Fill([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Fill reference to the left, right, top, and bottom, with this margin.  

## Fill([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Fill reference to the left, right, top, and bottom.  

## FloatBottom([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Float towards bottom of reference with this margin.  

## FloatBottom([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Float towards bottom of reference.  

## FloatLeft([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Float towards left-side of reference with this margin.  

## FloatLeft([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Float towards left-side of reference.  

## FloatRight([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Float towards right-side of reference with this margin.  

## FloatRight([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Float towards right-side of reference.  

## FloatTop([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Float towards top of reference with this margin.  

## FloatTop([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Float towards top of reference.  

## Height(int height)

**LayoutOptions**  

Set the height of the control directly.  

## Left([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Place at left-side of reference with this margin.  

## Left([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Place at left-side of reference.  

## LeftOf([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Place to the left of the reference with this margin.  

## LeftOf([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Place to the left of the reference.  

## MatchBottom([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Align with bottom of reference with this margin.  

## MatchBottom([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Align with bottom of reference.  

## MatchLeft([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Align with left of reference with this margin.  

## MatchLeft([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Align with left of reference.  

## MatchRight([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Align with right of reference with this margin.  

## MatchRight([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Align with right of reference.  

## MatchTop([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Align with top of reference with this margin.  

## MatchTop([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Align with top of reference.  

## Right([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Place at right-side of reference with this margin.  

## Right([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Place at right-side of reference.  

## RightOf([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Place to the right of the reference with this margin.  

## RightOf([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Place to the right of the reference.  

## Top([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**LayoutOptions**  

Place at top of reference with this margin.  

## Top([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**LayoutOptions**  

Place at top of reference.  

## Width(int width)

**LayoutOptions**  

Set the width of the control directly.  

# Nested Types

[PositionType](WithoutHaste.Windows.GUI.LayoutOptions.PositionType.md)  
Ways of defining a position relative to another item.  

