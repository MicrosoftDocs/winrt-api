---
-api-id: T:Windows.Media.Core.TimedTextSource
-api-type: winrt class
---

<!-- Class syntax.
public class TimedTextSource : Windows.Media.Core.ITimedTextSource
-->

# Windows.Media.Core.TimedTextSource

## -description
Represents a source of timed text data.

## -remarks
Get an instance of **TimedTextSource** from one of the factory methods, [CreateFromStream](timedtextsource_createfromstream_1985521886.md) or [CreateFromUri](timedtextsource_createfromuri_1421797945.md). After obtaining an instance, you can use it to set the [MediaSource.ExternalTimedTextSources](mediasource_externaltimedtextsources.md) property of a [MediaSource](mediasource.md) object to initialize its [ExternalTimedMetadataTracks](mediasource_externaltimedmetadatatracks.md) collection.

For how-to guidance for working with external timed text sources, see [Media items, playlists, and tracks](https://msdn.microsoft.com/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -examples

## -see-also
[ITimedTextSource](itimedtextsource.md), [Media items, playlists, and tracks](https://msdn.microsoft.com/windows/uwp/audio-video-camera/media-playback-with-mediasource)