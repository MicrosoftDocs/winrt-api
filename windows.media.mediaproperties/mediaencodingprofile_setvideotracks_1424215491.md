---
-api-id: M:Windows.Media.MediaProperties.MediaEncodingProfile.SetVideoTracks(Windows.Foundation.Collections.IIterable{Windows.Media.Core.VideoStreamDescriptor})
-api-type: winrt method
---

<!-- Method syntax.
public void MediaEncodingProfile.SetVideoTracks(IIterable<VideoStreamDescriptor> value)
-->

# Windows.Media.MediaProperties.MediaEncodingProfile.SetVideoTracks

## -description
Sets the list of [**VideoStreamDescriptor**](https://docs.microsoft.com/uwp/api/windows.media.core.videostreamdescriptor) objects describing the video streams included in the **MediaEncodingProfile**.

## -parameters
### -param value
A collection of [**VideoStreamDescriptor**](https://docs.microsoft.com/uwp/api/windows.media.core.videostreamdescriptor) objects.

## -remarks
The  [**Label**](https://docs.microsoft.com/uwp/api/windows.media.core.videostreamdescriptor#Windows_Media_Core_VideoStreamDescriptor_Label) field for each [**VideoStreamDescriptor**](https://docs.microsoft.com/en-us/uwp/api/windows.media.core.videostreamdescriptor) in the collection must be unique. If you attempt to add more than one stream descriptor with the same label, an invalid argument error will occur.

If you set the [**Video**](https://docs.microsoft.com/uwp/api/windows.media.mediaproperties.mediaencodingprofile#Windows_Media_MediaProperties_MediaEncodingProfile_Video) property, the list of video tracks is reset to a list with a single **VideoStreamDescriptor** entry. If you retrieve the **Video** property after calling **SetVideoTracks**, the property will return the first entry in the provided list.

## -see-also

## -examples

