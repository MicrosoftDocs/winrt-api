---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateFileOutputNodeAsync(Windows.Storage.IStorageFile,Windows.Media.MediaProperties.MediaEncodingProfile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Audio.CreateAudioFileOutputNodeResult> CreateFileOutputNodeAsync(Windows.Storage.IStorageFile file, Windows.Media.MediaProperties.MediaEncodingProfile fileEncodingProfile)
-->

# Windows.Media.Audio.AudioGraph.CreateFileOutputNodeAsync

## -description
Creates a file output node for the indicated file and media encoding profile.

## -parameters
### -param file
A [StorageFile](../windows.storage/storagefile.md) object representing the file.

### -param fileEncodingProfile
An objecting representing the media encoding profile.

## -returns
When this operation completes, a **CreateAudioFileOutputNodeResult** object is returned.

## -remarks
The *fileEncodingProfile* parameter specifies the [MediaEncodingProfile](../windows.media.mediaproperties/mediaencodingprofile.md) with which the output file will be created. If this parameter is null, the encoding profile defaults to a WAV file format with the same [AudioEncodingProperties](../windows.media.mediaproperties/audioencodingproperties.md) as the [AudioGraph](audiograph.md) to which it belongs.

## -examples

## -see-also
[CreateFileOutputNodeAsync(IStorageFile)](audiograph_createfileoutputnodeasync_1127853521.md)