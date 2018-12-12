# [WithoutHaste.Windows.GUI](TableOfContents.WithoutHaste.Windows.GUI.md).ColorPalettePanel

**Inheritance:** object → [MarshalByRefObject](https://docs.microsoft.com/en-us/dotnet/api/system.marshalbyrefobject) → [System.ComponentModel.Component](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.component) → [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) → [System.Windows.Forms.ScrollableControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.scrollablecontrol) → [System.Windows.Forms.Panel](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.panel) → [System.Windows.Forms.FlowLayoutPanel](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.flowlayoutpanel)  
**Implements:** [System.ComponentModel.IComponent](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.icomponent), [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable), [System.Windows.Forms.UnsafeNativeMethods.IOleControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iolecontrol), [System.Windows.Forms.UnsafeNativeMethods.IOleObject](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ioleobject), [System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceObject](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ioleinplaceobject), [System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ioleinplaceactiveobject), [System.Windows.Forms.UnsafeNativeMethods.IOleWindow](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iolewindow), [System.Windows.Forms.UnsafeNativeMethods.IViewObject](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iviewobject), [System.Windows.Forms.UnsafeNativeMethods.IViewObject2](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iviewobject2), [System.Windows.Forms.UnsafeNativeMethods.IPersist](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ipersist), [System.Windows.Forms.UnsafeNativeMethods.IPersistStreamInit](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ipersiststreaminit), [System.Windows.Forms.UnsafeNativeMethods.IPersistPropertyBag](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ipersistpropertybag), [System.Windows.Forms.UnsafeNativeMethods.IPersistStorage](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.ipersiststorage), [System.Windows.Forms.UnsafeNativeMethods.IQuickActivate](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.unsafenativemethods.iquickactivate), [System.Windows.Forms.ISupportOleDropSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.isupportoledropsource), [System.Windows.Forms.IDropTarget](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.idroptarget), [System.ComponentModel.ISynchronizeInvoke](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.isynchronizeinvoke), [System.Windows.Forms.IWin32Window](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.iwin32window), [System.Windows.Forms.Layout.IArrangedElement](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.layout.iarrangedelement), [System.Windows.Forms.IBindableComponent](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.ibindablecomponent), [System.ComponentModel.IExtenderProvider](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.iextenderprovider)  

Control for displaying a Drawing.Colors.ColorPalette.  

**Remarks:**  
The palette is displayed as a series of color swatches. Swatches auto-fill available space left-to-right and top-to-bottom. The swatches will auto-scroll as needed.  

The user can click on a color swatch to select its color.  

# Examples

## Example A:


```
ColorPalettePanel panel = new ColorPalettePanel(myColorPalette) {
	Location = new Point(10, 10),
	Size = new Size(150, 200)
};
form.Controls.Add(panel);
  
```  

# Fields

## SCROLLBAR_WIDTH

**const int**  

Width of vertical scroll bar.  

## SWATCH_WIDTH

**const int**  

Width and height of each color swatch.  

# Properties

## SelectedColor

**[Nullable&lt;System.Drawing.Color&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) { public get; public set; }**  

# Events

## ColorChanged

**[EventHandler](https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler)**  

Triggers when the user selects a color.  

# Constructors

## ColorPalettePanel()

## ColorPalettePanel(Drawing.Colors.ColorPalette colorPalette, [System.Windows.Forms.ContextMenu](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.contextmenu) colorContextMenu = null)

**Misc:**  
  

**Parameters:**  
* **Drawing.Colors.ColorPalette colorPalette**: Color palette to display.  
* **[System.Windows.Forms.ContextMenu](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.contextmenu) colorContextMenu**: Optional context menu to apply to each color swatch.  

# Methods

## DisplayColors(Drawing.Colors.ColorPalette colorPalette)

**void**  

Set the color palette to display in the panel.  

