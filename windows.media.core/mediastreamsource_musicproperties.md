---
-api-id: P:Windows.Media.Core.MediaStreamSource.MusicProperties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.FileProperties.MusicProperties MusicProperties { get; }
-->

# Windows.Media.Core.MediaStreamSource.MusicProperties

## -description
Gets the music properties which are used for music-related metadata.

## -property-value
The music properties.

## -remarks
MusicProperties is a music-oriented view of the [MediaStreamSource](mediastreamsource.md) properties.

Applications are allowed to modify the properties of MusicProperties at any time.

Applications should be aware that there is overlap with [VideoProperties](mediastreamsource_videoproperties.md). A change to the MusicProperties may modify a similar property in the [VideoProperties](mediastreamsource_videoproperties.md), and vice versa.

## -examples

## -see-also
