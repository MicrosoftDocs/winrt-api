---
-api-id: T:Windows.Media.Core.VideoStreamDescriptor
-api-type: winrt class
---

<!-- Class syntax.
public class VideoStreamDescriptor : Windows.Media.Core.IMediaStreamDescriptor, Windows.Media.Core.IVideoStreamDescriptor
-->

# Windows.Media.Core.VideoStreamDescriptor

## -description
Represents a description a video media stream.

## -remarks
When creating a [MediaEncodingProfile](../windows.media.mediaproperties/mediaencodingprofile.md), call [SetVideoTracks](../windows.media.mediaproperties/mediaencodingprofile_setvideotracks_1424215491.md), passing in one or more **VideoStreamDescriptor** objects to provide information about the video tracks to be encoded.

See the [MediaStreamSource Sample](http://go.microsoft.com/fwlink/p/?LinkID=309021) for an example of using Media Stream Source in a UWP app.

## -examples

## -see-also
[IMediaStreamDescriptor](imediastreamdescriptor.md), [MediaStreamSource Sample](http://go.microsoft.com/fwlink/p/?LinkID=309021)