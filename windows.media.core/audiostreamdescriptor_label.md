---
-api-id: P:Windows.Media.Core.AudioStreamDescriptor.Label
-api-type: winrt property
---

<!-- Property syntax.
public string Label { get;  set; }
-->

# Windows.Media.Core.AudioStreamDescriptor.Label

## -description
Gets or sets an app-defined label that identifies an audio stream in a [MediaEncodingProfile](/uwp/api/Windows.Media.MediaProperties.MediaEncodingProfile) that contains multiple streams.

## -property-value
An app-defined label that identifies an audio stream

## -remarks
The label for each stream in a single **MediaEncodingProfile** must be unique. Calling [SetAudioTracks](/uwp/api/windows.media.mediaproperties.mediaencodingprofile#Windows_Media_MediaProperties_MediaEncodingProfile_SetAudioTracks_Windows_Foundation_Collections_IIterable_Windows_Media_Core_AudioStreamDescriptor__) to add a stream descriptor containing a duplicate label will result in an invalid argument error. 

## -see-also

## -examples

