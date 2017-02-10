---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateFileInputNodeAsync(Windows.Storage.IStorageFile,Windows.Media.Audio.AudioNodeEmitter)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Audio.CreateAudioFileInputNodeResult> CreateFileInputNodeAsync(Windows.Storage.IStorageFile file, Windows.Media.Audio.AudioNodeEmitter emitter)
-->

# Windows.Media.Audio.AudioGraph.CreateFileInputNodeAsync

## -description
Creates a file input node that supports spatial audio.

## -parameters
### -param file
A [IStorageFile](../windows.storage/istoragefile.md) object representing the file associated with the file input node.

### -param emitter
An object that describes the position and other physical characteristics of the emitter from which the node's audio is emitted when spatial audio processing is used.

## -returns
An asynchronous operation that returns a [CreateAudioFileInputNodeResult](createaudiofileinputnoderesult.md) on completion. This object exposes a [Status](createaudiofileinputnoderesult_status.md) property, that indicates either that the operation was successful or the reason why the operation failed. The [FileInputNode](createaudiofileinputnoderesult_fileinputnode.md) property provides a reference to the created input node on success.

## -remarks
To create a file input node with an emitter, the audio file must be encoded in mono at 48kHz.

## -examples

## -see-also
[CreateFileInputNodeAsync(IStorageFile)](audiograph_createfileinputnodeasync_152724062.md)