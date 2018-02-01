---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateFileInputNodeAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Audio.CreateAudioFileInputNodeResult> CreateFileInputNodeAsync(Windows.Storage.IStorageFile file)
-->

# Windows.Media.Audio.AudioGraph.CreateFileInputNodeAsync

## -description
Creates an [AudioFileInputNode](audiofileinputnode.md) that inputs audio data into the audio graph from a storage file.

## -parameters
### -param file
A [StorageFile](../windows.storage/storagefile.md) object representing the audio file associated with the input node.

## -returns
An asynchronous operation that returns a [CreateAudioFileInputNodeResult](createaudiofileinputnoderesult.md) on completion. This object exposes a [Status](createaudiofileinputnoderesult_status.md) property, that indicates either that the operation was successful or the reason why the operation failed. The [FileInputNode](createaudiofileinputnoderesult_fileinputnode.md) property provides a reference to the created output node on success.

## -remarks

## -examples

## -see-also

## -capabilities
backgroundMediaRecording
