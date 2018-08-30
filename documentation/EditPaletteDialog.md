# EditPaletteDialog

Control for editing a [ColorPalette](https://github.com/WithoutHaste/WithoutHaste.Drawing.Colors/blob/master/documentation/ColorPalette.md).

This dialog will open an existing palette file (or create an empty palette), let the user edit the palette, and save the changes before closing.

Base Type: System.Windows.Forms.Form

## Examples

```
using(EditPaletteDialog form = new EditPaletteDialog(paletteFilename))
{
	if(form.ShowDialog() != DialogResult.OK)
		return;
}
```

## Properties

### String FullFilename

Location of color palette file, including full path + filename + extension.

If palette is saved to a new location, this property will have the new location after the dialog closes.

## Constructors

### EditPaletteDialog()

### EditPaletteDialog(System.String fullFilename)

Parameter fullFilename: Location of color palette file, including full path + filename + extension.  

