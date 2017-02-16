---
-api-id: E:Windows.Media.Playback.MediaPlayer.SourceChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SourceChanged<Windows.Media.Playback.MediaPlayer,  object>
-->

# Windows.Media.Playback.MediaPlayer.SourceChanged

## -description
Occurs when the media source for the [MediaPlayer](mediaplayer.md) changes.

## -remarks
A typical use of this event is if you are implementing your own transport controls. You can respond to this event by checking to see whether the source is a [MediaSource](../windows.media.core/mediasource.md), [MediaPlaybackItem](mediaplaybackitem.md), or [MediaPlaybackList](mediaplaybacklist.md) and then update your UI accordingly. For example, if the source is a [MediaPlaybackItem](mediaplaybackitem.md), you could subscribe to the list of audio and caption tracks and update the list in your UI so that the user can select the active track.

## -examples

## -see-also
