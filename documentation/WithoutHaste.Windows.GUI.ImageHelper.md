# [WithoutHaste.Windows.GUI](TableOfContents.WithoutHaste.Windows.GUI.md).ImageHelper

**Static**  
**Inheritance:** object  

Utilities related to image processing.  

# Static Methods

## GetThumbnail([System.Drawing.Bitmap](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.bitmap) bitmap, int maxWidth, int maxHeight)

**static [System.Drawing.Bitmap](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.bitmap)**  

Shrinks an image to fit within _maxWidth_ and _maxHeight_.  
Keeps aspect ratio the same.  

**Returns:**  
Returns a new Bitmap object, even if the image did not need to be resized.  

## SafeLoadBitmap(string fullFilename)

**static [System.Drawing.Bitmap](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.bitmap)**  

To avoid "A generic error occurred in GDI+" exception.  

GDI+ expects the original MemoryStream used to load an image to remain open for the full life of the image. If you close the MemoryStream and then try to save the image to the same location as it was loaded from, you'll get this exception.  

Opening images with this method will avoid that error.  

**Parameters:**  
* **string fullFilename**: Full path and filename to image.  

