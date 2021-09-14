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
The current PlaybackRate is set to the value of [DefaultPlaybackRate](mediaelement_defaultplaybackrate.md) whenever [Play](mediaelement_play_848564459.md) is called. So setting [DefaultPlaybackRate](mediaelement_defaultplaybackrate.md) to a different value has no effect until [Play](mediaelement_play_848564459.md) is called.

To set a rate that will persist throughout the lifetime of the [MediaElement](mediaelement.md), use [DefaultPlaybackRate](mediaelement_defaultplaybackrate.md). Once playback ends, due to the [MediaEnded](mediaelement_mediaended.md) event being raised or if [Pause](mediaelement_pause_1953642114.md) or [Stop](mediaelement_stop_1201535524.md) are called, the PlaybackRate will be effectively lost.

## -examples

## -see-also
