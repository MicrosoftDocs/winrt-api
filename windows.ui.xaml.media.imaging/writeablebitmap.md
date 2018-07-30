---
-api-id: T:Windows.UI.Xaml.Media.Imaging.WriteableBitmap
-api-type: winrt class
---

<!-- Class syntax.
public class WriteableBitmap : Windows.UI.Xaml.Media.Imaging.BitmapSource, Windows.UI.Xaml.Media.Imaging.IWriteableBitmap
-->

# Windows.UI.Xaml.Media.Imaging.WriteableBitmap

## -description

Provides a [BitmapSource](bitmapsource.md) that can be written to and updated.

## -remarks

The image source data of a [WriteableBitmap](writeablebitmap.md) is an underlying pixel buffer. [WriteableBitmap.PixelBuffer](writeablebitmap_pixelbuffer.md) cannot be written to directly, however, you can use language-specific techniques to access the buffer and change its contents.

+ To access the pixel content from C# or Microsoft Visual Basic, you can use the **AsStream** extension method to access the underlying buffer as a stream.
<!--Not linking AsStream because not sure which one to link, it's an interop/projection thing ...-->
+ To access the pixel content from C++, you can query for the **IBufferByteAccess** type (defined in Robuffer.h) and directly access its **Buffer** property.

Some of the scenarios where you might have used a **WriteableBitmap** class in previous XAML frameworks can be accomplished in the Windows Runtime by using the [RenderTargetBitmap](rendertargetbitmap.md) class instead. For more info see [RenderTargetBitmap](rendertargetbitmap.md).

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

[BitmapSource](bitmapsource.md), [Image](../windows.ui.xaml.controls/image.md), [BitmapDecoder](../windows.graphics.imaging/bitmapdecoder.md), [Windows.Graphics.Imaging namespace](../windows.graphics.imaging/windows_graphics_imaging.md), [XAML images sample](http://go.microsoft.com/fwlink/p/?linkid=238575), [Camera preview frame sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620516)