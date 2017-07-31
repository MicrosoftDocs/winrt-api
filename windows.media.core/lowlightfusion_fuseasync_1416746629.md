---
-api-id: M:Windows.Media.Core.LowLightFusion.FuseAsync(Windows.Foundation.Collections.IIterable{Windows.Graphics.Imaging.SoftwareBitmap})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<LowLightFusionResult, double> LowLightFusion.FuseAsync(IIterable<SoftwareBitmap> frameSet)
-->

# Windows.Media.Core.LowLightFusion.FuseAsync

## -description
Asynchronously fuses a set of images into a single image that has been computed to improve image lighting and fidelity.

## -parameters
### -param frameSet
The collection of image frames to be processed.

## -returns
An asynchronous operation that returns a **LowLightFusionResult** upon successful completion. The app should call **Close** on the returned object to free up the allocated resources.

## -remarks
This method will return in an error in the following cases:

* The number of images in the provided collection exceeds the specified by **MaxSupportedFrameCount** property.
* The images in the provided collection have different pixel formats.
* The images in the provided collection have different resolutions.
* The images in the provided collection are in an unsupported pixel format.  Supported formats can be determined by checking the **SupportedBitmapPixelFormats** property.

## -see-also

## -examples

