# NewColorDialog

Color picker dialog for selecting a System.Drawing.Color.

Base Type: System.Windows.Forms.Form

## Examples

```
using(NewColorDialog form = new NewColorDialog(color))
{
	if(form.ShowDialog() != DialogResult.OK)
		return;
}
```

## Properties

### Color Color

Selected color.

## Constructors

### NewColorDialog()

### NewColorDialog(System.Drawing.Color color)

Open dialog with this color selected.

