---
-api-id: M:Windows.Media.SpeechSynthesis.SpeechSynthesisStream.ReadAsync(Windows.Storage.Streams.IBuffer,System.UInt32,Windows.Storage.Streams.InputStreamOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Storage.Streams.IBuffer, uint> ReadAsync(Windows.Storage.Streams.IBuffer buffer, System.UInt32 count, Windows.Storage.Streams.InputStreamOptions options)
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesisStream.ReadAsync

## -description
Reads data asynchronously in a sequential stream.

## -parameters
### -param buffer
The buffer into which the asynchronous read operation places the bytes that are read.

### -param count
The number of bytes to read that is less than or equal to the Capacity value.

### -param options
Specifies the type of the asynchronous read operation.

## -returns
An asynchronous operation that includes progress updates. For more information, see [ReadAsync](../windows.storage.streams/iinputstream_readasync_1012630619.md) method.

## -remarks

## -examples

## -see-also
[Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
