---
-api-id: P:Windows.UI.Xaml.Media.Imaging.WriteableBitmap.PixelBuffer
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer PixelBuffer { get; }
-->

# Windows.UI.Xaml.Media.Imaging.WriteableBitmap.PixelBuffer

## -description
Gets an access for the direct buffer where each pixel of the [WriteableBitmap](writeablebitmap.md) is written to.

## -property-value
A reference to the pixel buffer.

## -remarks
[PixelBuffer](writeablebitmap_pixelbuffer.md) cannot be written to directly, however, you can use language-specific techniques to access the buffer and change its contents.
+ To access the pixel content from C# or Microsoft Visual Basic, you can use the **AsStream** extension method to access the underlying buffer as a stream.
+ To access the pixel content from C++, you can query for the **IBufferByteAccess** type (defined in Robuffer.h) and directly access its **Buffer** property.


## -examples
This example writes to the [PixelBuffer](writeablebitmap_pixelbuffer.md) property of [WriteableBitmap](writeablebitmap.md) as part of a transcoding scenario that will eventually use the [WriteableBitmap](writeablebitmap.md) as an [Image.Source](../windows.ui.xaml.controls/image_source.md) value and display the image. The code shown here comes from a larger code sample, the SDK [XAML images sample](http://go.microsoft.com/fwlink/p/?linkid=238575).

```csharp
using (IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read)) 
{
    BitmapDecoder decoder = await BitmapDecoder.CreateAsync(fileStream); 
    // Scale image to appropriate size 
    BitmapTransform transform = new BitmapTransform() {  
        ScaledWidth = Convert.ToUInt32(Scenario4WriteableBitmap.PixelWidth), 
        ScaledHeight = Convert.ToUInt32(Scenario4WriteableBitmap.PixelHeight)
    }; 
    PixelDataProvider pixelData = await decoder.GetPixelDataAsync( 
        BitmapPixelFormat.Bgra8, // WriteableBitmap uses BGRA format 
        BitmapAlphaMode.Straight, 
        transform, 
        ExifOrientationMode.IgnoreExifOrientation, // This sample ignores Exif orientation 
        ColorManagementMode.DoNotColorManage
    ); 
 
    // An array containing the decoded image data, which could be modified before being displayed 
    byte[] sourcePixels = pixelData.DetachPixelData(); 
 
    // Open a stream to copy the image contents to the WriteableBitmap's pixel buffer 
    using (Stream stream = Scenario4WriteableBitmap.PixelBuffer.AsStream()) 
    { 
        await stream.WriteAsync(sourcePixels, 0, sourcePixels.Length); 
    }                     
}
```



## -see-also
[BitmapSource](bitmapsource.md), [BitmapDecoder](../windows.graphics.imaging/bitmapdecoder.md), [Windows.Graphics.Imaging namespace](../windows.graphics.imaging/windows_graphics_imaging.md), [XAML images sample](http://go.microsoft.com/fwlink/p/?linkid=238575)