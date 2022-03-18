---
-api-id: N:Windows.Media.Streaming.Adaptive
-api-type: winrt namespace
---

# Windows.Media.Streaming.Adaptive

## -description

Provides the ability to playback multimedia content that is delivered using various adaptive streaming protocols. You can playback Http Live Streaming (HLS) or Dynamic Adaptive Streaming over HTTP (DASH) content.

## -remarks

In addition to basic playback, this namespace provides for the control of these aspects of the adaptive streaming algorithm:

+ Ability to create an instance of the [AdaptiveMediaSource](adaptivemediasource.md) object for playing adaptive streaming content, which can be bound to either XAML or HTML media elements.
+ Ability to query for the available adaptive bit rates that are described by the adaptive streaming manifest.
+ Ability to select the initial bit rate to use for playback.
+ Ability to limit the set of bit rates to use during playback.
+ Ability to get events when the bit rate has changed.
+ Ability to determine if playback is live.
+ Ability to set the starting offset for live playback.

All other functionality typically required by multimedia apps, such as playback controls, stream selection, and so on, are performed on the media element after you bind the [AdaptiveMediaSource](adaptivemediasource.md) object to that media element.

For how-to guidance for using adaptive streaming in your app, see [Adaptive streaming](/windows/uwp/audio-video-camera/adaptive-streaming).

## -examples

## -see-also

[Adaptive streaming sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/AdaptiveStreaming), [Adaptive streaming](/windows/uwp/audio-video-camera/adaptive-streaming), [PlayReady sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/PlayReady)
