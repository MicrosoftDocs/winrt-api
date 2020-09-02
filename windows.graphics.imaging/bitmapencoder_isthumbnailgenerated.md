---
-api-id: P:Windows.Graphics.Imaging.BitmapEncoder.IsThumbnailGenerated
-api-type: winrt property
---

<!-- Property syntax
public bool IsThumbnailGenerated { get;  set; }
-->

# Windows.Graphics.Imaging.BitmapEncoder.IsThumbnailGenerated

## -description
Indicates whether or not a new thumbnail is automatically generated.

## -property-value
A value that indicates whether or not the bitmap encoder will automatically generate a new thumbnail. The default value is False.

## -remarks
When this value is true, the bitmap encoder will generate a new thumbnail by downscaling the frame bitmap. The thumbnail size is determined by the [GeneratedThumbnailWidth](bitmapencoder_generatedthumbnailwidth.md) and [GeneratedThumbnailHeight](bitmapencoder_generatedthumbnailheight.md) properties. When this value is false, no thumbnail is written to the file.

If the [BitmapEncoder](bitmapencoder.md) was created using the [CreateForTranscodingAsync](bitmapencoder_createfortranscodingasync_1673967352.md) method and **IsThumbnailGenerated** is false, the bitmap encoder will leave any existing thumbnail data untouched. In this case, if the bitmap was modified before encoding, it's possible for the output file to have a thumbnail that does not match the new contents of the image.

Only JPEG, TIFF and JPEG-XR image types support encoding thumbnails. If the image format being encoded does not support thumbnails and you set **IsThumbnailGenerated** to true, then the call to [FlushAsync](bitmapencoder_flushasync_491532439.md) will fail with HRESULT [WINCODEC_ERR_UNSUPPORTEDOPERATION](/windows/desktop/wic/-wic-codec-error-codes). You should catch this exception and retry encoding with thumbnail generation disabled. If your app only encodes image formats that support thumbnails, you can skip this step.



```csharp

   try
    {
        await encoder.FlushAsync();
    }
    catch (Exception err)
    {
        switch (err.HResult)
        {
            case unchecked ((int) 0x88982F81): //WINCODEC_ERR_UNSUPPORTEDOPERATION
                // If the encoder does not support writing a thumbnail, then try again
                // but disable thumbnail generation.
                encoder.IsThumbnailGenerated = false;
                break;
            default:
                throw err;
        }
    }

    if (encoder.IsThumbnailGenerated == false)
    {
        await encoder.FlushAsync();
    }

```



## -examples

## -see-also
