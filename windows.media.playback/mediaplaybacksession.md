---
-api-id: T:Windows.Media.Playback.MediaPlaybackSession
-api-type: winrt class
---

<!-- Class syntax.
public class MediaPlaybackSession : Windows.Media.Playback.IMediaPlaybackSession, Windows.Media.Playback.IMediaPlaybackSession2
-->

# Windows.Media.Playback.MediaPlaybackSession

## -description
Provides information about the state of the current playback session of a [MediaPlayer](mediaplayer.md) and provides events for responding to changes in playback session state.

## -remarks
Get an instance of this class by accessing the [PlaybackSession](mediaplayer_playbacksession.md) property of a [MediaPlayer](mediaplayer.md) or the [PlaybackSession](mediabreakmanager_playbacksession.md) property of a [MediaBreakManager](mediabreakmanager.md).

For how-to guidance for working with **MediaPlayer** and playback sessions, see [Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | BufferedRangesChanged |
| 1703 | 15063 | GetBufferedRanges |
| 1703 | 15063 | GetPlayedRanges |
| 1703 | 15063 | GetSeekableRanges |
| 1703 | 15063 | IsMirroring |
| 1703 | 15063 | IsSupportedPlaybackRateRange |
| 1703 | 15063 | PlayedRangesChanged |
| 1703 | 15063 | SeekableRangesChanged |
| 1703 | 15063 | SphericalVideoProjection |
| 1703 | 15063 | SupportedPlaybackRatesChanged |
| 1803 | 17134 | GetOutputDegradationPolicyState |
| 1803 | 17134 | PlaybackRotation |

## -examples

## -see-also
[Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer)
