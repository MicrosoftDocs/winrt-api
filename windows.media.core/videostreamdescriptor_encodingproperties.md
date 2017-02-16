---
-api-id: P:Windows.Media.Core.VideoStreamDescriptor.EncodingProperties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.MediaProperties.VideoEncodingProperties EncodingProperties { get; }
-->

# Windows.Media.Core.VideoStreamDescriptor.EncodingProperties

## -description
Gets the encoding properties on the video stream.

## -property-value
The encoding properties on the video stream.

## -remarks
If the media pipeline cannot handle the new encoding properties, the [MediaStreamSource](mediastreamsource.md) will raise the [Closed](mediastreamsource_closed.md) event which provides information regarding the error.

## -examples

## -see-also
