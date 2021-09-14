---
-api-id: M:Windows.UI.Xaml.Controls.MediaPlayerElement.SetMediaPlayer(Windows.Media.Playback.MediaPlayer)
-api-type: winrt method
---

<!-- Method syntax
public void SetMediaPlayer(Windows.Media.Playback.MediaPlayer mediaPlayer)
-->

# Windows.UI.Xaml.Controls.MediaPlayerElement.SetMediaPlayer

## -description
Sets the [MediaPlayer](../windows.media.playback/mediaplayer.md) instance used to render media.


## -parameters
### -param mediaPlayer
The new [MediaPlayer](../windows.media.playback/mediaplayer.md) instance used to render media.

## -remarks
You can use the SetMediaPlayer method to change the underlying [MediaPlayer](../windows.media.playback/mediaplayer.md) instance. Calling this method to change the [MediaPlayer](../windows.media.playback/mediaplayer.md) can cause non-trivial side effects because it can change other properties of the [MediaPlayerElement](mediaplayerelement.md).

Use the [MediaPlayer](mediaplayerelement_mediaplayer.md) property to get the current instance of [MediaPlayer](../windows.media.playback/mediaplayer.md).

## -examples

## -see-also
