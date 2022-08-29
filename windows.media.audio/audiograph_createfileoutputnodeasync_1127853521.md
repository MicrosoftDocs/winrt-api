---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateFileOutputNodeAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Audio.CreateAudioFileOutputNodeResult> CreateFileOutputNodeAsync(Windows.Storage.IStorageFile file)
-->

# Windows.Media.Audio.AudioGraph.CreateFileOutputNodeAsync

## -description
Creates a new [AudioFileOutputNode](audiofileoutputnode.md) that outputs audio data from the audio graph to the specified storage file.

## -parameters
### -param file
A [StorageFile](../windows.storage/storagefile.md) to which audio data is written.

## -returns
An asynchronous operation that returns a [CreateAudioFileOutputNodeResult](createaudiofileoutputnoderesult.md) on completion. This object exposes a [Status](createaudiofileoutputnoderesult_status.md) property, that indicates either that the operation was successful or the reason why the operation failed. The [FileOutputNode](createaudiofileoutputnoderesult_fileoutputnode.md) property provides a reference to the created output node on success.

## -remarks
The file output node created by this method defaults to a WAV file format with the same [AudioEncodingProperties](../windows.media.mediaproperties/audioencodingproperties.md) properties as the [AudioGraph](audiograph.md) to which it belongs. To create a file output node with custom encoding properties use the [CreateFileOutputNodeAsync(IStorageFile, MediaEncodingProfile)](audiograph_createfileoutputnodeasync_870871467.md) overload.

## -examples

## -see-also
[CreateFileOutputNodeAsync(IStorageFile, AudioEncodingProperties)](audiograph_createfileoutputnodeasync_870871467.md)
## -capabilities
backgroundMediaRecording
