---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.PlaybackRate
-api-type: winrt property
---

<!-- Property syntax
public double PlaybackRate { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaElement.PlaybackRate

## -description
Gets or sets the playback rate ratio for the media engine.

## -xaml-syntax
```xaml
<MediaElement PlaybackRate="double"/>
```


## -property-value
The playback rate ratio for the media. A value of 1.0 is the normal playback speed. Value can be negative to play backwards.

## -remarks
The current [PlaybackRate](mediaelement_playbackrate.md) is set to the value of [DefaultPlaybackRate](mediaelement_defaultplaybackrate.md) whenever [Play](mediaelement_play.md) is called. So setting [DefaultPlaybackRate](mediaelement_defaultplaybackrate.md) to a different value has no effect until [Play](mediaelement_play.md) is called.

To set a rate that will persist throughout the lifetime of the [MediaElement](mediaelement.md), use [DefaultPlaybackRate](mediaelement_defaultplaybackrate.md). Once playback ends, due to the [MediaEnded](mediaelement_mediaended.md) event being raised or if [Pause](mediaelement_pause.md) or [Stop](mediaelement_stop.md) are called, the [PlaybackRate](mediaelement_playbackrate.md) will be effectively lost.

## -examples

## -see-also
