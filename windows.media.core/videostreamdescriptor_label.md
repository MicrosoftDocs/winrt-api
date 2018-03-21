---
-api-id: P:Windows.Media.Core.VideoStreamDescriptor.Label
-api-type: winrt property
---

<!-- Property syntax.
public string Label { get;  set; }
-->

# Windows.Media.Core.VideoStreamDescriptor.Label

## -description
Gets or sets an app-defined label that identifies a video stream in a [MediaEncodingProfile](https://docs.microsoft.com/uwp/api/Windows.Media.MediaProperties.MediaEncodingProfile) that contains multiple streams.

## -property-value
An app-defined label that identifies a video stream.

## -remarks
The label for each stream in a single **MediaEncodingProfile** must be unique. Calling [SetVideoTracks](https://docs.microsoft.com/uwp/api/windows.media.mediaproperties.mediaencodingprofile#Windows_Media_MediaProperties_MediaEncodingProfile_SetVideoTracks_Windows_Foundation_Collections_IIterable_Windows_Media_Core_VideoStreamDescriptor__) to add a stream descriptor containing a duplicate label will result in an invalid argument error.

If you use a [MediaFrameSourceGroup](https://docs.microsoft.com/uwp/api/windows.media.capture.frames.mediaframesourcegroup) to capture multiple video streams at once, the system will attempt to match the **Label** property of each **VideoStreamDescriptor** with the [Id](https://docs.microsoft.com/uwp/api/windows.media.capture.frames.mediaframesourceinfo.Id) property of each [Media​Frame​Source​Info](https://docs.microsoft.com/uwp/api/windows.media.capture.frames.mediaframesourceinfo) in the group in order to match the capture device with the approproate stream descriptor.

## -see-also

## -examples

