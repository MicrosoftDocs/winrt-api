---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.DefaultPlaybackRate
-api-type: winrt property
---

<!-- Property syntax
public double DefaultPlaybackRate { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaElement.DefaultPlaybackRate

## -description
Gets or sets the default playback rate for the media engine. The playback rate applies when the user isn't using fast forward or reverse.

## -xaml-syntax
```xaml
<MediaElement DefaultPlaybackRate="double"/>
```


## -property-value
The default playback rate. The default is 1.0, which indicates normal playback speed.

## -remarks
The current [PlaybackRate](mediaelement_playbackrate.md) is set to the value of [DefaultPlaybackRate](mediaelement_defaultplaybackrate.md) whenever [Play](mediaelement_play.md) is called. So setting [DefaultPlaybackRate](mediaelement_defaultplaybackrate.md) to a different value has no effect until [Play](mediaelement_play.md) is called.

To set a rate that will persist throughout the lifetime of the [MediaElement](mediaelement.md), use [DefaultPlaybackRate](mediaelement_defaultplaybackrate.md). Once playback ends, due to the [MediaEnded](mediaelement_mediaended.md) event being raised or if [Pause](mediaelement_pause.md) or [Stop](mediaelement_stop.md) are called, the [PlaybackRate](mediaelement_playbackrate.md) will be effectively lost.

## -examples

## -see-also
