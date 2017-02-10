---
-api-id: M:Windows.Media.Transcoding.MediaTranscoder.PrepareMediaStreamSourceTranscodeAsync(Windows.Media.Core.IMediaSource,Windows.Storage.Streams.IRandomAccessStream,Windows.Media.MediaProperties.MediaEncodingProfile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Transcoding.PrepareTranscodeResult> PrepareMediaStreamSourceTranscodeAsync(Windows.Media.Core.IMediaSource source, Windows.Storage.Streams.IRandomAccessStream destination, Windows.Media.MediaProperties.MediaEncodingProfile profile)
-->

# Windows.Media.Transcoding.MediaTranscoder.PrepareMediaStreamSourceTranscodeAsync

## -description
Asynchronously initializes the trancode operation on the specified media source and returns a [PrepareTranscodeResult](preparetranscoderesult.md) object which can be used to start the transcode operation.

## -parameters
### -param source
The media source to perform the transcode operation on.

### -param destination
The destination stream for the transcoded media data.

### -param profile
The profile to use for the operation.

## -returns
When this method completes, a [PrepareTranscodeResult](preparetranscoderesult.md) object is returned which can be used to start the transcode.

## -remarks

## -examples

## -see-also
