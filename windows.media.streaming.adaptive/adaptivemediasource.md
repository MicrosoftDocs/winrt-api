---
-api-id: T:Windows.Media.Streaming.Adaptive.AdaptiveMediaSource
-api-type: winrt class
---

<!-- Class syntax.
public class AdaptiveMediaSource : Windows.Foundation.IClosable, Windows.Media.Core.IMediaSource, Windows.Media.Streaming.Adaptive.IAdaptiveMediaSource, Windows.Media.Streaming.Adaptive.IAdaptiveMediaSource2, Windows.Media.Streaming.Adaptive.IAdaptiveMediaSource3
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSource

## -description

Represents the source of adaptive streaming content.

## -remarks

Call one of the [CreateFromStreamAsync](adaptivemediasource_createfromstreamasync_337009516.md) or [CreateFromUriAsync](adaptivemediasource_createfromuriasync_832683104.md) methods to create a AdaptiveMediaSource object with a specific adaptive streaming manifest source.

For how-to guidance for using adaptive streaming in your app, see [Adaptive streaming](/windows/uwp/audio-video-camera/adaptive-streaming).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | AdvancedSettings |
| 1703 | 15063 | DesiredSeekableWindowSize |
| 1703 | 15063 | Diagnostics |
| 1703 | 15063 | GetCorrelatedTimes |
| 1703 | 15063 | MaxSeekableWindowSize |
| 1703 | 15063 | MinLiveOffset |

## -examples

## -see-also

[IMediaSource](../windows.media.core/imediasource.md), [Adaptive streaming](/windows/uwp/audio-video-camera/adaptive-streaming), [Adaptive streaming sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/AdaptiveStreaming)
