# ColorPalettePanel

Control for displaying a [ColorPalette](https://github.com/WithoutHaste/WithoutHaste.Drawing.Colors/blob/master/documentation/ColorPalette.md).

The palette is displayed as a series of color swatches. Swatches auto fill available space left-to-right and top-to-bottom. The swatches will auto-scroll as needed.

The user can click on a color swatch to select its color.

Base Type: System.Windows.Forms.FlowLayoutPanel

## Examples

```
ColorPalettePanel panel = new ColorPalettePanel(myColorPalette) {
	Location = new Point(10, 10),
	Size = new Size(150, 200)
	};
form.Controls.Add(panel);
```

## Fields

### Constant Fields

#### Int32 SCROLLBAR_WIDTH

Width of vertical scroll bar.

#### Int32 SWATCH_WIDTH

Width and height of each color swatch.

## Properties

### System.Drawing.Color? SelectedColor

## Events

###  ColorChanged

Triggers when the user selects a color.

## Constructors

### ColorPalettePanel()

### ColorPalettePanel(WithoutHaste.Drawing.Colors.ColorPalette colorPalette, System.Windows.Forms.ContextMenu colorContextMenu)

Parameter colorPalette: Color palette to display.  
Parameter colorContextMenu: Optional context menu to apply to each color swatch.  

## Methods

### Void DisplayColors(WithoutHaste.Drawing.Colors.ColorPalette colorPalette)

Set the color palette to display in the panel.

