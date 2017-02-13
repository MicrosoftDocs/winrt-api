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
An asynchronous operation that includes progress updates. For more information, see [ReadAsync](../windows.storage.streams/iinputstream_readasync.md) method.

## -remarks

## -examples

## -see-also
[Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)