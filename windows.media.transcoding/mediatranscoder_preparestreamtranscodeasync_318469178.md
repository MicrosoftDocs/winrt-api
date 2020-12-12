---
-api-id: M:Windows.Media.Transcoding.MediaTranscoder.PrepareStreamTranscodeAsync(Windows.Storage.Streams.IRandomAccessStream,Windows.Storage.Streams.IRandomAccessStream,Windows.Media.MediaProperties.MediaEncodingProfile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Transcoding.PrepareTranscodeResult> PrepareStreamTranscodeAsync(Windows.Storage.Streams.IRandomAccessStream source, Windows.Storage.Streams.IRandomAccessStream destination, Windows.Media.MediaProperties.MediaEncodingProfile profile)
-->

# Windows.Media.Transcoding.MediaTranscoder.PrepareStreamTranscodeAsync

## -description
Asynchronously initializes the trancode operation on the specified stream and returns a [PrepareTranscodeResult](preparetranscoderesult.md) object which can be used to start the transcode operation.

## -parameters
### -param source
The source stream.

*source* cannot be a [InMemoryRandomAccessStream](../windows.storage.streams/inmemoryrandomaccessstream.md) or other writeable stream.

### -param destination
The destination stream.

### -param profile
The profile to use for the operation.

## -returns
When this method completes, a [PrepareTranscodeResult](preparetranscoderesult.md) object is returned which can be used to start the transcode.

## -remarks
The *source* parameter cannot be a [InMemoryRandomAccessStream](../windows.storage.streams/inmemoryrandomaccessstream.md) or other writeable stream.

## -examples
The following example shows how to use this method to transcode a stream.

```csharp
var transcoder = new Windows.Media.Transcoding.MediaTranscoder();
return transcoder.prepareStreamTranscodeAsync(sourceStream, destinationStream, profile);
```

## -see-also
