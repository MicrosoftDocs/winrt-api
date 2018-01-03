---
-api-id: T:Windows.Media.Core.TimedMetadataStreamDescriptor
-api-type: winrt class
---

<!-- Class syntax.
public class TimedMetadataStreamDescriptor : IMediaStreamDescriptor, IMediaStreamDescriptor2
-->

# Windows.Media.Core.TimedMetadataStreamDescriptor

## -description
Represents a description a timed metada media stream. 

## -remarks
This object is the parallel to [VideoStreamDescriptor](videostreamdescriptor.md) and [AudioStreamDescriptor](audiostreamdescriptor.md), but is used for streams that contain arbitrary data. An example usage of this type of stream would be to encode a stream of GPS coordinates that are captured simulataneously with a video stream.

When creating a [MediaEncodingProfile](../windows.media.mediaproperties/mediaencodingprofile.md), call [SetVideoTracks](../windows.media.mediaproperties/mediaencodingprofile_setvideotracks_1424215491.md), passing in one or more **VideoStreamDescriptor** objects to provide information about the video tracks to be encoded.


## -see-also

## -examples

