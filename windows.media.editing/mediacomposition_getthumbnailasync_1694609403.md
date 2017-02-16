---
-api-id: M:Windows.Media.Editing.MediaComposition.GetThumbnailAsync(Windows.Foundation.TimeSpan,System.Int32,System.Int32,Windows.Media.Editing.VideoFramePrecision)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.ImageStream> GetThumbnailAsync(Windows.Foundation.TimeSpan timeFromStart, System.Int32 scaledWidth, System.Int32 scaledHeight, Windows.Media.Editing.VideoFramePrecision framePrecision)
-->

# Windows.Media.Editing.MediaComposition.GetThumbnailAsync

## -description
Asynchronously gets an image stream that represents a thumbnail of the media composition.

## -parameters
### -param timeFromStart
Specifies the point in the timeline of the [MediaComposition](mediacomposition.md) from which to render the thumbnail, offset from the start of the [MediaComposition](mediacomposition.md).

### -param scaledWidth
Specifies the target width at which to render. The default is 0. *scaledWidth* and/or *scaledHeight* can be optional; see Remarks.

### -param scaledHeight
Specifies the target height at which to render. The default is 0. *scaledWidth* and/or *scaledHeight* can be optional; see Remarks.

### -param framePrecision
Specifies the frame precision algorithm to use when retrieving the thumbnail.

## -returns
An image stream representing resulting thumbnail.

## -remarks
If *scaledWidth* and *scaledHeight* are both set, the aspect ratio of the original [MediaComposition](mediacomposition.md) is ignored, and your values can alter the aspect ratio.

If either *scaledWidth* or *scaledHeight* but not both is specified, the value you provide controls that dimension but the aspect ratio is preserved (the other dimension is calculated based on factoring the original aspect ratio of the [MediaComposition](mediacomposition.md)).

## -examples

## -see-also
