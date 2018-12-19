# [WithoutHaste.Windows.GUI](TableOfContents.WithoutHaste.Windows.GUI.md).EditPaletteDialog

**Inheritance:** object → [MarshalByRefObject](https://docs.microsoft.com/en-us/dotnet/api/system.marshalbyrefobject) → [System.ComponentModel.Component](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.component) → [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) → [System.Windows.Forms.ScrollableControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.scrollablecontrol) → [System.Windows.Forms.ContainerControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.containercontrol) → [System.Windows.Forms.Form](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form)  
**Implements:** [System.ComponentModel.IComponent](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.icomponent), [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable), [System.Windows.Forms.UnsafeNativeMethods.IOleControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iolecontrol), [System.Windows.Forms.UnsafeNativeMethods.IOleObject](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ioleobject), [System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceObject](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ioleinplaceobject), [System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ioleinplaceactiveobject), [System.Windows.Forms.UnsafeNativeMethods.IOleWindow](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iolewindow), [System.Windows.Forms.UnsafeNativeMethods.IViewObject](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iviewobject), [System.Windows.Forms.UnsafeNativeMethods.IViewObject2](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iviewobject2), [System.Windows.Forms.UnsafeNativeMethods.IPersist](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ipersist), [System.Windows.Forms.UnsafeNativeMethods.IPersistStreamInit](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ipersiststreaminit), [System.Windows.Forms.UnsafeNativeMethods.IPersistPropertyBag](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ipersistpropertybag), [System.Windows.Forms.UnsafeNativeMethods.IPersistStorage](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ipersiststorage), [System.Windows.Forms.UnsafeNativeMethods.IQuickActivate](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iquickactivate), [System.Windows.Forms.ISupportOleDropSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.isupportoledropsource), [System.Windows.Forms.IDropTarget](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.idroptarget), [System.ComponentModel.ISynchronizeInvoke](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.isynchronizeinvoke), [System.Windows.Forms.IWin32Window](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.iwin32window), [System.Windows.Forms.Layout.IArrangedElement](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.layout.iarrangedelement), [System.Windows.Forms.IBindableComponent](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.ibindablecomponent), [System.Windows.Forms.IContainerControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.icontainercontrol)  

Control for editing a Drawing.Colors.ColorPalette.  

**Remarks:**  
This dialog will open an existing palette file (or create an empty palette), let the user edit the palette, and save the changes before closing.  

# Examples

## Example A:


```
using(EditPaletteDialog form = new EditPaletteDialog(paletteFilename))
{
	if(form.ShowDialog() != DialogResult.OK)
		return;
}
  
```  

# Properties

## ColorPalette

**Drawing.Colors.ColorPalette { public get; }**  

The full palette object.  

## FullFilename

**string { public get; }**  

Location of color palette file, including full path + filename + extension.  

**Remarks:**  
If palette is saved to a new location, this property will have the new location after the dialog closes.  

# Constructors

## EditPaletteDialog()

Start a new palette.  

## EditPaletteDialog(string fullFilename)

Load and edit palette from file.  

**Parameters:**  
* **string fullFilename**: Location of color palette file, including full path + filename + extension.  

## EditPaletteDialog(Drawing.Colors.ColorPalette colorPalette)

Edit the provided palette.  

**Remarks:**  
The provided palette object will be updated directly.  
The user will not be prompted to save the palette to a file.  

