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
The current [PlaybackRate](mediaelement_playbackrate.md) is set to the value of DefaultPlaybackRate whenever [Play](mediaelement_play_848564459.md) is called. So setting DefaultPlaybackRate to a different value has no effect until [Play](mediaelement_play_848564459.md) is called.

To set a rate that will persist throughout the lifetime of the [MediaElement](mediaelement.md), use DefaultPlaybackRate. Once playback ends, due to the [MediaEnded](mediaelement_mediaended.md) event being raised or if [Pause](mediaelement_pause_1953642114.md) or [Stop](mediaelement_stop_1201535524.md) are called, the [PlaybackRate](mediaelement_playbackrate.md) will be effectively lost.

## -examples

## -see-also
