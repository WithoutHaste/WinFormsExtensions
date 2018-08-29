# ColorPalettePanel

`System.Windows.Forms.Panel` for displaying a `WithoutHaste.Drawing.Colors.ColorPalette` and to select colors from it.

## Requirements

System.Drawing.dll

[WithoutHaste.Drawing.Colors.dll](https://github.com/WithoutHaste/WithoutHaste.Drawing.Colors)

## Usage

ColorPalettePanel is derived from `System.Windows.Forms.FlowLayoutPanel`.

```
ColorPalettePanel panel = new ColorPalettePanel() {
	Location = new Point(10, 10),
	Size = new Size(150, 200)
};
form.Controls.Add(panel);
```

The panel displays color swatches from a `ColorPalette` in a flow layout (swatches will rearrange to fill the panel from left-to-right, top-to-bottom) with auto-scrolling.

The user can click on a swatch to select its color.

## Constants

`int SCROLLBAR_WIDTH`: width of the scroll bar, whether or not it is visible.

`int SWATCH_WIDTH`: the width and height of a color swatch.

## Events

`System.EventHandler ColorChanged`: triggers when user selects a color swatch.

## Properties

`System.Drawing.Color? SelectedColor`: get or set the selected color.

## Constructors

Parameterless: `new ColorPalettePanel()`  
Create an empty panel.

Open file: `new ColorPalettePanel(ColorPalette, ContextMenu = null)`  
Open an existing color palette file and display it. See the `Colors.dll` documentation for supported file formats.  
Optional: specify a `ContextMenu` to be used for each color swatch.

## Methods

### DisplayColors

Display a specific `ColorPalette`.

`panel.DisplayColors(ColorPalette);`