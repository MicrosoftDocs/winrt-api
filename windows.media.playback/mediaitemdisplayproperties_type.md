---
-api-id: P:Windows.Media.Playback.MediaItemDisplayProperties.Type
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.MediaPlaybackType Type { get;  set; }
-->

# Windows.Media.Playback.MediaItemDisplayProperties.Type

## -description
Gets or sets a value indicating the type of media that is represented by the [MediaPlaybackItem](mediaplaybackitem.md), such as audio or video.

## -property-value
A value indicating the type of media that is represented by the [MediaPlaybackItem](mediaplaybackitem.md).

## -remarks

Apps should set a value for the **Type** property even if they aren't supplying other media metadata to be displayed by the System Media Transport Controls. This value helps the system handle your media content correctly, including preventing the screen saver from activating during playback.

## -examples

## -see-also
