# EditPaletteDialog

Windows Forms dialog for editing `WithoutHaste.Drawing.Colors.ColorPalette` objects.

## Requirements

[WithoutHaste.Drawing.Colors.dll](https://github.com/WithoutHaste/WithoutHaste.Drawing.Colors)

## Usage

Opens like a normal dialog.

```
using(EditPaletteDialog form = new EditPaletteDialog())
{
	if(form.ShowDialog() != DialogResult.OK)
		return;
}
```

This dialog will open an existing palette file (or start a new one), let the user edit the palette, and save the changes before closing.

## Properties

`FullFilename`: location of the color palette file, including the path, filename, and extension

## Constructors

Parameterless: `new EditPaletteDialog();`  
Starts a new palette.

Existing file: `new EditPaletteDialog(filename);`  
Loads an existing color palette from file. See the `Colors.dll` documentation for supported file formats.
