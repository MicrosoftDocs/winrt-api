---
-api-id: P:Windows.Media.Playback.MediaPlaybackItem.AutoLoadedDisplayProperties
-api-type: winrt property
---

<!-- Property syntax.
public AutoLoadedDisplayPropertyKind AutoLoadedDisplayProperties { get;  set; }
-->

# Windows.Media.Playback.MediaPlaybackItem.AutoLoadedDisplayProperties

## -description
Gets or sets a value that specifies for which types of media content, if any, the system should automatically load metadata to display in the System Media Transport Controls.

## -property-value
A value that specifies for which types of media content the system should automatically load and display metadata.

## -remarks
You can programmatically provide metadata for media items, instead of having the system dynamically load the metadata in the content, by calling [GetDisplayProperties](mediaplaybackitem_getdisplayproperties_103236454.md), setting the data of the returned [MediaItemDisplayProperties] (mediaitemdisplayproperties.md), and then calling [ApplyDisplayProperties](mediaplaybackitem_applydisplayproperties_1634192028.md). For more information, see [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -see-also

## -examples

