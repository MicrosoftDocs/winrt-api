---
-api-id: T:Windows.Graphics.Imaging.BitmapDecoder
-api-type: winrt class
---

<!-- Class syntax.
public class BitmapDecoder : Windows.Graphics.Imaging.IBitmapDecoder, Windows.Graphics.Imaging.IBitmapFrame, Windows.Graphics.Imaging.IBitmapFrameWithSoftwareBitmap
-->

# Windows.Graphics.Imaging.BitmapDecoder

## -description

Provides read access to bitmap container data as well as data from the first frame.

## -remarks

### Image formats

BitmapDecoder can decode the following formats.

+ JPEG
+ PNG
+ GIF
+ TIFF
+ BMP
+ ICO
+ JPEG-XR
+ Any installed Camera raw formats by using the Microsoft Camera Codec Pack.

For a list of decoding formats, see the [BitmapEncoder](bitmapencoder.md) topic.

The BitmapDecoder class implements [IBitmapFrame](ibitmapframe.md). It provides access to container data as well as data from the first frame. This allows applications to accomplish most common scenarios without needing to retrieve a separate [BitmapFrame](bitmapframe.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | HeifDecoderId |
| 1809 | 17763 | WebpDecoderId |

## -examples

Here's a partial example of creating a decoder object. This example assumes you selected a file with [Windows.Storage.Pickers.FileOpenPicker](../windows.storage.pickers/fileopenpicker.md). For full instructions on selecting a file, creating an decoder, and decoding an image see [Imaging](/windows/uwp/audio-video-camera/imaging)

```csharp
FileOpenPicker fileOpenPicker = new FileOpenPicker();
fileOpenPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
fileOpenPicker.FileTypeFilter.Add(".jpg");
fileOpenPicker.ViewMode = PickerViewMode.Thumbnail;

var inputFile = await fileOpenPicker.PickSingleFileAsync();

if (inputFile == null)
{
    // The user cancelled the picking operation
    return;
}

SoftwareBitmap softwareBitmap;

using (IRandomAccessStream stream = await inputFile.OpenAsync(FileAccessMode.Read))
{
    // Create the decoder from the stream
    BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);

    // Get the SoftwareBitmap representation of the file
    softwareBitmap = await decoder.GetSoftwareBitmapAsync();
}
```

## -see-also

[Animated GIF playback (XAML) sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlAnimatedGif), [OCR sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620579), [Camera resolution sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=624252), [Basic camera app sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=619479), [Video stabilization sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620519), [Camera face detection sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=619486), [Manual camera controls sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=627611), [High dynamic range sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620517), [Camera Advanced Capture sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/CameraAdvancedCapture)
