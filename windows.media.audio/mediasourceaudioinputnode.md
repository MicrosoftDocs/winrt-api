---
-api-id: T:Windows.Media.Audio.MediaSourceAudioInputNode
-api-type: winrt class
---

<!-- Class syntax.
public class MediaSourceAudioInputNode : IClosable, IAudioInputNode, IAudioInputNode2, IAudioNode
-->

# Windows.Media.Audio.MediaSourceAudioInputNode

## -description
Represents a node in an audio graph that inputs audio data into the graph from a [MediaSource](../windows.media.core/mediasource.md) object.

## -remarks
The [MediaSource](../windows.media.core/mediasource.md) class provides a common representation of media content from different kinds of sources, such as files or network streams. For more information on working with **MediaSource**, see [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource).

Get an instance of this class by calling [AudioGraph.CreateMediaSourceAudioInputNode](audiograph_createmediasourceaudioinputnodeasync_989225096.md) and then accessing the [CreateFileInputNodeResult.FileInputNode](createaudiofileinputnoderesult_fileinputnode.md) property.

## -see-also
MediaSourceAudioInputNode
[MediaSource](../windows.media.core/mediasource.md)
[Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource)

## -examples

