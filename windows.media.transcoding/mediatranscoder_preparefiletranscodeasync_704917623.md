---
-api-id: M:Windows.Media.Transcoding.MediaTranscoder.PrepareFileTranscodeAsync(Windows.Storage.IStorageFile,Windows.Storage.IStorageFile,Windows.Media.MediaProperties.MediaEncodingProfile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Transcoding.PrepareTranscodeResult> PrepareFileTranscodeAsync(Windows.Storage.IStorageFile source, Windows.Storage.IStorageFile destination, Windows.Media.MediaProperties.MediaEncodingProfile profile)
-->

# Windows.Media.Transcoding.MediaTranscoder.PrepareFileTranscodeAsync

## -description
Asynchronously initializes the trancode operation on the specified file and returns a [PrepareTranscodeResult](preparetranscoderesult.md) object which can be used to start the transcode operation.

## -parameters
### -param source
The source file.

### -param destination
The destination file.

### -param profile
The profile to use for the operation.

## -returns
When this method completes, a [PrepareTranscodeResult](preparetranscoderesult.md) object is returned which can be used to start the transcode.

## -remarks

## -examples

## -see-also
[Transcoding media sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MediaTranscoding)
