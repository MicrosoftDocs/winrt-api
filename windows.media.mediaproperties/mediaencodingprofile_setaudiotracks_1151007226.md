---
-api-id: M:Windows.Media.MediaProperties.MediaEncodingProfile.SetAudioTracks(Windows.Foundation.Collections.IIterable{Windows.Media.Core.AudioStreamDescriptor})
-api-type: winrt method
---

<!-- Method syntax.
public void MediaEncodingProfile.SetAudioTracks(IIterable<AudioStreamDescriptor> value)
-->

# Windows.Media.MediaProperties.MediaEncodingProfile.SetAudioTracks

## -description
Sets the list of [AudioStreamDescriptor](/uwp/api/Windows.Media.Core.AudioStreamDescriptor) objects describing the audio streams included in the **MediaEncodingProfile**.

## -parameters
### -param value
A list of [VideoStreamDescriptor](/uwp/api/windows.media.core.videostreamdescriptor) objects.

## -remarks
The  [Label](/uwp/api/windows.media.core.audiostreamdescriptor.Label) field for each [AudioStreamDescriptor](/uwp/api/windows.media.core.audiostreamdescriptor) in the collection must be unique. If you attempt to add more than one stream descriptor with the same label, an invalid argument error will occur.

If you set the [Audio](/uwp/api/windows.media.mediaproperties.mediaencodingprofile.Audio) property, the list of video tracks is reset to a list with a single **AudioStreamDescriptor** entry. If you retrieve the **Audio** property after calling **SetVideoTracks**, the property will return the first entry in the provided list.

## -see-also

## -examples

