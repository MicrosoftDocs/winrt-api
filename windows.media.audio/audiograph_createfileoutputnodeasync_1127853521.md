---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateFileOutputNodeAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Audio.CreateAudioFileOutputNodeResult> CreateFileOutputNodeAsync(Windows.Storage.IStorageFile file)
-->

# Windows.Media.Audio.AudioGraph.CreateFileOutputNodeAsync

## -description
Creates a file output node for the indicated file.

## -parameters
### -param file
A [StorageFile](../windows.storage/storagefile.md) object representing the file.

## -returns
When this operation completes, a **CreateAudioFileOutputNodeResult** object is returned.

## -remarks
The file output node created by this method defaults to a WAV file format with the same [AudioEncodingProperties](../windows.media.mediaproperties/audioencodingproperties.md) properties as the [AudioGraph](audiograph.md) to which it belongs. To create a file output node with custom encoding properties use the [CreateFileOutputNodeAsync(IStorageFile, MediaEncodingProfile)](audiograph_createfileoutputnodeasync_870871467.md) overload.

## -examples

## -see-also
[CreateFileOutputNodeAsync(IStorageFile, AudioEncodingProperties)](audiograph_createfileoutputnodeasync_870871467.md)