---
-api-id: P:Windows.Media.Core.VideoStreamDescriptor.EncodingProperties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.MediaProperties.VideoEncodingProperties EncodingProperties { get; }
-->

# Windows.Media.Core.VideoStreamDescriptor.EncodingProperties

## -description
Gets an object describing the encoding properties for the video stream. These properties include the resolution and frame rate of the video.

## -property-value
The encoding properties on the video stream.

## -remarks
If the media pipeline cannot handle the encoding properties, a [MediaStreamSource](mediastreamsource.md) will raise the [Closed](mediastreamsource_closed.md) event which provides information regarding the error.

## -examples

## -see-also
