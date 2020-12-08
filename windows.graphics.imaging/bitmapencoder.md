---
-api-id: T:Windows.Graphics.Imaging.BitmapEncoder
-api-type: winrt class
---

<!-- Class syntax.
public class BitmapEncoder : Windows.Graphics.Imaging.IBitmapEncoder, Windows.Graphics.Imaging.IBitmapEncoderWithSoftwareBitmap
-->

# Windows.Graphics.Imaging.BitmapEncoder

## -description

Contains methods to create, edit and save images.

## -remarks

### Image formats

BitmapEncoder can encode the following formats.

+ JPEG
+ PNG
+ GIF
+ TIFF
+ BMP
+ JPEG-XR

For a list of decoding formats, see the [BitmapDecoder](bitmapdecoder.md) topic.

BitmapEncoder behaves differently from [BitmapDecoder](bitmapdecoder.md) in that it doesn't provide random access to the frames in an image. Instead, you need to perform actions on the encoder in a specific order.

When you create a BitmapEncoder, it provides access to data on the container and the first frame. When you are done setting data on the first frame and container, if you don't want to encode any additional frames, then call [FlushAsync](bitmapencoder_flushasync_491532439.md) to complete the encoding operation.

If you want to encode an additional frame, call [GoToNextFrameAsync](bitmapencoder_gotonextframeasync_1063265177.md). This commits the data in the container and the first frame so you can't edit them anymore. At this point any actions you perform on the encoder will affect the second frame. After you are done with each frame, you can call [GoToNextFrameAsync](bitmapencoder_gotonextframeasync_1063265177.md) to commit and append a new frame, or call [FlushAsync](bitmapencoder_flushasync_491532439.md) to finish.Bitmap encoders may expose various encoding options that affect the quality, size and other properties of the encoded output file. For more info, see [Imaging](/windows/uwp/audio-video-camera/imaging).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | HeifEncoderId |

## -examples

Here's a partial example of creating an encoder object. This example assumes you selected a file with [Windows.Storage.Pickers.FileSavePicker](../windows.storage.pickers/filesavepicker.md). For full instructions on selecting a file, creating an encoder, and encoding an image see [Imaging](/windows/uwp/audio-video-camera/imaging)

```csharp
private async void SaveSoftwareBitmapToFile(SoftwareBitmap softwareBitmap, StorageFile outputFile)
{
    using (IRandomAccessStream stream = await outputFile.OpenAsync(FileAccessMode.ReadWrite))
    {
        // Create an encoder with the desired format
        BitmapEncoder encoder = await BitmapEncoder.CreateAsync(BitmapEncoder.JpegEncoderId, stream);

        // Set the software bitmap
        encoder.SetSoftwareBitmap(softwareBitmap);

        // Set additional encoding parameters, if needed
        encoder.BitmapTransform.ScaledWidth = 320;
        encoder.BitmapTransform.ScaledHeight = 240;
        encoder.BitmapTransform.Rotation = Windows.Graphics.Imaging.BitmapRotation.Clockwise90Degrees;
        encoder.BitmapTransform.InterpolationMode = BitmapInterpolationMode.Fant;
        encoder.IsThumbnailGenerated = true;

        try
        {
            await encoder.FlushAsync();
        }
        catch (Exception err)
        {
            const int WINCODEC_ERR_UNSUPPORTEDOPERATION = unchecked((int)0x88982F81);
            switch (err.HResult)
            {
                case WINCODEC_ERR_UNSUPPORTEDOPERATION: 
                    // If the encoder does not support writing a thumbnail, then try again
                    // but disable thumbnail generation.
                    encoder.IsThumbnailGenerated = false;
                    break;
                default:
                    throw;
            }
        }

        if (encoder.IsThumbnailGenerated == false)
        {
            await encoder.FlushAsync();
        }


    }
}
```

## -see-also

[Imaging](/windows/uwp/audio-video-camera/imaging), [Camera resolution sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CameraResolution), [Basic camera app sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=619479), [Video stabilization sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620519), [Camera face detection sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=619486), [Manual camera controls sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=627611), [High dynamic range sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620517), [Camera Advanced Capture sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/CameraAdvancedCapture)
