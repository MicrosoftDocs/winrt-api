---
-api-id: T:Windows.Media.Audio.AudioGraph
-api-type: winrt class
---

<!-- Class syntax.
public class AudioGraph : Windows.Foundation.IClosable, Windows.Media.Audio.IAudioGraph, Windows.Media.Audio.IAudioGraph2
-->

# Windows.Media.Audio.AudioGraph

## -description

Represents an audio graph of connected input, output, and submix nodes that manipulate and route audio.

## -remarks

The audio graph is made up of input nodes, output nodes, and submix nodes. Input nodes include audio files, audio devices, and code that generates audio data. Output nodes also include audio files, audio devices, and code that processes audio data. When the graph is started, audio data flows through the graph from the input nodes, through any submix nodes, to the output nodes. Each node can have zero or more audio effects that are applied to the audio data before it is passed to the next node. This class and related APIs enable you to develop audio applications more quickly and easily than the low-level COM XAudio2 APIs. For how-to guidance on using audio graphs, see [Audio graphs](/windows/uwp/audio-video-camera/audio-graphs).

Get an instance of this class by calling [AudioGraph.CreateAsync](audiograph_createasync_145006550.md).

The entire audio graph must operate at the same sample rate. Sources can have different sample rates, but are resampled immediately.

> [!NOTE]
> If no audio devices are available, the audio graph cannot be instantiated.

> AudioGraph cannot be instantiated on the N and KN editions of Windows 8 and Windows 10, unless the optional Media Feature Pack has been installed.
For more information, see [Media Feature Pack for Windows N editions](https://support.microsoft.com/help/3145500/media-feature-pack-list-for-windows-n-editions).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | CreateBatchUpdater |
| 1607 | 14393 | CreateDeviceInputNodeAsync(MediaCategory,AudioEncodingProperties,DeviceInformation,AudioNodeEmitter) |
| 1607 | 14393 | CreateFileInputNodeAsync(IStorageFile,AudioNodeEmitter) |
| 1607 | 14393 | CreateFrameInputNode(AudioEncodingProperties,AudioNodeEmitter) |
| 1607 | 14393 | CreateSubmixNode(AudioEncodingProperties,AudioNodeEmitter) |
| 1803 | 17134 | CreateMediaSourceAudioInputNodeAsync(MediaSource) |
| 1803 | 17134 | CreateMediaSourceAudioInputNodeAsync(MediaSource,AudioNodeEmitter) |

## -examples

## -see-also

[IClosable](../windows.foundation/iclosable.md), [Audio graphs](/windows/uwp/audio-video-camera/audio-graphs), [AudioGraph sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/AudioCreation)

## -capabilities

backgroundMediaRecording
