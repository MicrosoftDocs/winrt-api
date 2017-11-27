---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateFileOutputNodeAsync(Windows.Storage.IStorageFile,Windows.Media.MediaProperties.MediaEncodingProfile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Audio.CreateAudioFileOutputNodeResult> CreateFileOutputNodeAsync(Windows.Storage.IStorageFile file, Windows.Media.MediaProperties.MediaEncodingProfile fileEncodingProfile)
-->

# Windows.Media.Audio.AudioGraph.CreateFileOutputNodeAsync

## -description
Creates a new [AudioFileOutuputNode](audiofileoutputnode.md) that outputs audio data from the audio graph to the specified storage file.

## -parameters
### -param file
A [StorageFile](../windows.storage/storagefile.md) to which audio data is written.

### -param fileEncodingProfile
A [MediaEncodingProfile](../windows.media.mediaproperties/mediaencodingprofile.md) that determines the format of the output file. 

## -returns
An asynchronous operation that returns a [CreateAudioFileOutputNodeResult](createaudiofileoutputnoderesult.md) on completion. This object exposes a [Status](createaudiofileoutputnoderesult_status.md) property, that indicates either that the operation was successful or the reason why the operation failed. The [FileOutputNode](createaudiofileoutputnoderesult_fileoutputnode.md) property provides a reference to the created output node on success.

## -remarks
If the *file* parameter is null, the encoding profile defaults to a WAV file format with the same [AudioEncodingProperties](../windows.media.mediaproperties/audioencodingproperties.md) as the [AudioGraph](audiograph.md) to which it belongs.

## -examples

## -see-also
[CreateFileOutputNodeAsync(IStorageFile)](audiograph_createfileoutputnodeasync_1127853521.md)
## -capabilities
backgroundMediaRecording
