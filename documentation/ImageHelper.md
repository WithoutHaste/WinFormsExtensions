# ImageHelper

Static type.

Various utilities related to image processing.

Base Type: System.Object

## Static Methods

### Bitmap SafeLoadBitmap(System.String fullFilename)

To avoid "A generic error occurred in GDI+" exception.

GDI+ expects the original MemoryStream used to load an image to remain open for the full life of the image. If you close the MemoryStream and then try to save the image to the same location as it was loaded from, you'll get this exception.

Opening images with this method will avoid that error.

Parameter fullFilename: Full path and filename to image.  

