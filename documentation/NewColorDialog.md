# NewColorDialog

Windows Forms color picker dialog for selecting a System.Drawing.Color.

## Requirements

System.Drawing.dll

## Usage

Opens like a normal dialog.

```
using(NewColorDialog form = new NewColorDialog())
{
	if(form.ShowDialog() != DialogResult.OK)
		return;
}
```

This dialog presents several ways of selecting a color:  
- point-and-click color selector
- hexadecimal
- red/green/blue values
- hue/saturation/value values

## Properties

`Color`: the selected color

## Constructors

Parameterless: `new NewColorDialog();`  
Select a color, starting with black.

Existing file: `new NewColorDialog(System.Drawing.Color);`  
Select a color, starting with the specified color.

