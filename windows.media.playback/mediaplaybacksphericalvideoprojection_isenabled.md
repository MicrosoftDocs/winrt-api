---
-api-id: P:Windows.Media.Playback.MediaPlaybackSphericalVideoProjection.IsEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsEnabled { get;  set; }
-->

# Windows.Media.Playback.MediaPlaybackSphericalVideoProjection.IsEnabled

## -description
Gets or sets a value indicating whether spherical video projection is enabled.

## -property-value
True if spherical video projection is enabled. Otherwise, false.

## -remarks

The value of this property is not guaranteed to be correct until after the [MediaPlayer.MediaOpened](mediaplayer_mediaopened.md) event has been raised for the associated media item.

If you attempt to set this property to true when the value of the [FrameFormat](mediaplaybacksphericalvideoprojection_frameformat.md) is [None](/uwp/api/windows.media.mediaproperties.sphericalvideoframeformat) or [Unsupported](/uwp/api/windows.media.mediaproperties.sphericalvideoframeformat) an error will be raised.


## -see-also

## -examples

