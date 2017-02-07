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

[BitmapDecoder](bitmapdecoder.md) can decode the following formats.

+ JPEG
+ PNG
+ GIF
+ TIFF
+ BMP
+ ICO
+ JPEG-XR
+ Any installed Camera raw formats by using the Microsoft Camera Codec Pack.
For a list of decoding formats, see the [BitmapEncoder](bitmapencoder.md) topic.

The [BitmapDecoder](bitmapdecoder.md) class implements [IBitmapFrame](ibitmapframe.md). It provides access to container data as well as data from the first frame. This allows applications to accomplish most common scenarios without needing to retrieve a separate [BitmapFrame](bitmapframe.md).

## -examples
Here's a partial example of creating a decoder object. This example assumes you selected a file with [Windows.Storage.Pickers.FileOpenPicker](../windows.storage.pickers/fileopenpicker.md). For full instructions on selecting a file, creating an decoder, and decoding an image see [Imaging](http://msdn.microsoft.com/library/3fd2aa71-ef67-47b2-9332-3ffa5d3703ea)

```javascript
file.openAsync(Windows.Storage.FileAccessMode.readWrite).then(function (_stream) {
        stream = _stream;

        var encoderId;
        switch (fileType) {
            case ".jpg":
                encoderId = Windows.Graphics.Imaging.BitmapEncoder.jpegEncoderId;
                break;
        }
        return Windows.Graphics.Imaging.BitmapEncoder.createAsync(encoderId, stream);
        }).then(function (encoder) {

              // Your code here.
        }

```



## -see-also
[Animated GIF playback (XAML) sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=624046), [OCR sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620579), [Camera resolution sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=624252), [Basic camera app sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619479), [Video stabilization sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620519), [Camera face detection sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619486), [Manual camera controls sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=627611), [High dynamic range sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620517)