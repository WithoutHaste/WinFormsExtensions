# [WithoutHaste.Windows.GUI](TableOfContents.WithoutHaste.Windows.GUI.md).LayoutHelper

**Static**  
**Inheritance:** object  

Helper for placing and sizing controls in a Form relative to each other.  

**Remarks:**  
Uses method chaining for a fluent writing style. Location and sizing methods can be chained in any order. Apply must be the last command.  

Add the control to its parent after using LayoutHelper.  

All methods in [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md) can also be called on LayoutHelper.  

# Examples

## Example A:


```
form.Controls.Add(toolStrip);
form.Controls.Add(otherControl);
LayoutHelper.Below(toolStrip).MatchLeft(otherControl).Right(form).Height(25).Apply(control);
form.Controls.Add(control);
  
```  

# Fields

## AnchorAll

**const [System.Windows.Forms.AnchorStyles](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.anchorstyles)**  

Control.Anchor setting for anchoring in all directions.  

# Static Methods

## Above([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place above reference with this margin.  

## Above([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place above reference.  

## Below([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place below reference with this margin.  

## Below([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place below reference.  

## Bottom([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place at bottom of reference with this margin.  

## Bottom([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place at bottom of reference.  

## CenterBoth([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) control, [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static void**  

Center control horizontally and vertically inside reference.  

## CenterBothInScreen([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) control, [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static void**  

Center control horizontally and vertically inside reference, within the screen.  

## CenterHeight([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int height)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Set the height of the control directly and specify that it should be vertical-centered in its parent.  

## CenterHorizontally([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) control, [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static void**  

Center control horizontally inside reference.  

## CenterVertically([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) control, [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static void**  

Center control vertically inside reference.  

## CenterWidth([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int width)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Set the width of the control directly and specify that it should be horizontal-centered in its parent.  

## Fill([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Fill reference to the left, right, top, and bottom, with this margin.  

## Fill([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Fill reference to the left, right, top, and bottom.  

## FloatBottom([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Float towards bottom of reference with this margin.  

## FloatBottom([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Float towards bottom of reference.  

## FloatLeft([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Float towards left-side of reference with this margin.  

## FloatLeft([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Float towards left-side of reference.  

## FloatRight([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Float towards right-side of reference with this margin.  

## FloatRight([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Float towards right-side of reference.  

## FloatTop([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Float towards top of reference with this margin.  

## FloatTop([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Float towards top of reference.  

## Height(int height)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Set the height of the control directly.  

## Left([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place at left-side of reference with this margin.  

## Left([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place at left-side of reference.  

## LeftOf([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place to the left of the reference with this margin.  

## LeftOf([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place to the left of the reference.  

## MatchBottom([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Align with bottom of reference with this margin.  

## MatchBottom([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Align with bottom of reference.  

## MatchLeft([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Align with left of reference with this margin.  

## MatchLeft([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Align with left of reference.  

## MatchRight([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Align with right of reference with this margin.  

## MatchRight([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Align with right of reference.  

## MatchTop([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Align with top of reference with this margin.  

## MatchTop([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Align with top of reference.  

## PlaceLeftOf([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) control, [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static void**  

Place control directly to the left of the reference, aligned to the top of the reference.  

## PlaceLeftOf([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) control, [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static void**  

Place control directly to the left of the reference, aligned to the top of the reference, with margin in between.  

## PlaceRightOf([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) control, [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static void**  

Place control directly to the right of the reference, aligned to the top of the reference.  

## PlaceRightOf([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) control, [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static void**  

Place control directly to the right of the reference, aligned to the top of the reference, with margin in between.  

## Right([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place at right-side of reference with this margin.  

## Right([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place at right-side of reference.  

## RightOf([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place to the right of the reference with this margin.  

## RightOf([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place to the right of the reference.  

## Top([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference, int margin)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place at top of reference with this margin.  

## Top([System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) reference)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Place at top of reference.  

## Width(int width)

**static [LayoutOptions](WithoutHaste.Windows.GUI.LayoutOptions.md)**  

Set the width of the control directly.  

