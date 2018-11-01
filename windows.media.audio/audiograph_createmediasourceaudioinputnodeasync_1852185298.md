---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateMediaSourceAudioInputNodeAsync(Windows.Media.Core.MediaSource,Windows.Media.Audio.AudioNodeEmitter)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<CreateMediaSourceAudioInputNodeResult> AudioGraph.CreateMediaSourceAudioInputNodeAsync(MediaSource mediaSource, AudioNodeEmitter emitter)
-->

# Windows.Media.Audio.AudioGraph.CreateMediaSourceAudioInputNodeAsync

## -description
Creates a spatial audio-enabled [MediaSourceAudioInputNode](mediasourceaudioinputnode.md) that inputs audio data into the audio graph from the provided [MediaSource](../windows.media.core/mediasource.md) object.

## -parameters
### -param mediaSource
The [MediaSource](../windows.media.core/mediasource.md) object from which audio data is input into the audio graph.

### -param emitter
An [AudioNodeEmitter](audionodeemitter.md) object that describes the position and other physical characteristics of the emitter from which the node's audio is emitted when spatial audio processing is used.

## -returns
An [IAsyncOperation](../windows.foundation/iasyncoperation_1.md) object that returns a [CreateMediaSourceAudioInputNodeResult](createmediasourceaudioinputnoderesult.md) on completion. This object exposes a [Status](createmediasourceaudioinputnoderesult_status.md) property, that indicates either that the operation was successful or the reason why the operation failed. The  [Node](createmediasourceaudioinputnoderesult_node.md) property provides a reference to the created input node on success.

## -remarks
The [MediaSource](../windows.media.core/mediasource.md) class provides a common representation of media content from different kinds of sources, such as files or network streams. For more information on working with **MediaSource**, see [Media items, playlists, and tracks](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -see-also
[MediaSourceAudioInputNode](mediasourceaudioinputnode.md)
[MediaSource](../windows.media.core/mediasource.md)
[Media items, playlists, and tracks](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-playback-with-mediasource)

## -examples

