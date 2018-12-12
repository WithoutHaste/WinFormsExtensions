# [WithoutHaste.Windows.GUI](TableOfContents.WithoutHaste.Windows.GUI.md).NewColorDialog

**Inheritance:** object → [MarshalByRefObject](https://docs.microsoft.com/en-us/dotnet/api/system.marshalbyrefobject) → [System.ComponentModel.Component](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.component) → [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) → [System.Windows.Forms.ScrollableControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.scrollablecontrol) → [System.Windows.Forms.ContainerControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.containercontrol) → [System.Windows.Forms.Form](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form)  
**Implements:** [System.ComponentModel.IComponent](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.icomponent), [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable), [System.Windows.Forms.UnsafeNativeMethods.IOleControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iolecontrol), [System.Windows.Forms.UnsafeNativeMethods.IOleObject](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ioleobject), [System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceObject](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ioleinplaceobject), [System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ioleinplaceactiveobject), [System.Windows.Forms.UnsafeNativeMethods.IOleWindow](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iolewindow), [System.Windows.Forms.UnsafeNativeMethods.IViewObject](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iviewobject), [System.Windows.Forms.UnsafeNativeMethods.IViewObject2](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iviewobject2), [System.Windows.Forms.UnsafeNativeMethods.IPersist](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ipersist), [System.Windows.Forms.UnsafeNativeMethods.IPersistStreamInit](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ipersiststreaminit), [System.Windows.Forms.UnsafeNativeMethods.IPersistPropertyBag](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ipersistpropertybag), [System.Windows.Forms.UnsafeNativeMethods.IPersistStorage](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ipersiststorage), [System.Windows.Forms.UnsafeNativeMethods.IQuickActivate](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iquickactivate), [System.Windows.Forms.ISupportOleDropSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.isupportoledropsource), [System.Windows.Forms.IDropTarget](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.idroptarget), [System.ComponentModel.ISynchronizeInvoke](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.isynchronizeinvoke), [System.Windows.Forms.IWin32Window](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.iwin32window), [System.Windows.Forms.Layout.IArrangedElement](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.layout.iarrangedelement), [System.Windows.Forms.IBindableComponent](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.ibindablecomponent), [System.Windows.Forms.IContainerControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.icontainercontrol)  

Color picker dialog for selecting a System.Drawing.Color.  

# Examples

## Example A:


```
using(NewColorDialog form = new NewColorDialog(color))
{
	if(form.ShowDialog() != DialogResult.OK)
		return;
}
  
```  

# Properties

## Color

**[System.Drawing.Color](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.color) { public get; protected set; }**  

Selected color.  

# Constructors

## NewColorDialog()

## NewColorDialog([System.Drawing.Color](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.color) color)

Open dialog with this color selected.  

