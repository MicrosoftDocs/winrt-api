---
-api-id: P:Windows.Media.Core.MediaStreamSource.VideoProperties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.FileProperties.VideoProperties VideoProperties { get; }
-->

# Windows.Media.Core.MediaStreamSource.VideoProperties

## -description
Gets the video properties which are used for video related metadata.

## -property-value
The video properties.

## -remarks
VideoProperties is a video-oriented view of the [MediaStreamSource](mediastreamsource.md) properties.

Applications are allowed to modify the properties of VideoProperties at any time.

Applications should be aware that there is overlap with [MusicProperties](mediastreamsource_musicproperties.md). A change to the VideoProperties may modify a similar property in the [MusicProperties](mediastreamsource_musicproperties.md) property, and vice versa.

## -examples

## -see-also
