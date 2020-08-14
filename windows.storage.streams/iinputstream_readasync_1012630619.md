---
-api-id: M:Windows.Storage.Streams.IInputStream.ReadAsync(Windows.Storage.Streams.IBuffer,System.UInt32,Windows.Storage.Streams.InputStreamOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Storage.Streams.IBuffer, uint> ReadAsync(Windows.Storage.Streams.IBuffer buffer, System.UInt32 count, Windows.Storage.Streams.InputStreamOptions options)
-->

# Windows.Storage.Streams.IInputStream.ReadAsync

## -description
Reads data from the stream asynchronously.

## -parameters
### -param buffer
A buffer that may be used to return the bytes that are read. The return value contains the buffer that holds the results.

### -param count
The number of bytes to read that is less than or equal to the [Capacity](ibuffer_capacity.md) value.

### -param options
Specifies the type of the asynchronous read operation.

## -returns
The asynchronous operation.

## -remarks
Always read data from the buffer returned in the [IAsyncOperationWithProgress(IBuffer, UInt32)](../windows.foundation/iasyncoperationwithprogress_2.md). Don't assume that the input buffer contains the data. Depending on the implementation, the data that's read might be placed into the input buffer, or it might be returned in a different buffer. For the input buffer, you don't have to implement the [IBuffer](ibuffer.md) interface. Instead, you can create an instance of the [Buffer](buffer.md) class.

Also consider reading a buffer into an [IInputStream](iinputstream.md) by using the [ReadBuffer](datareader_readbuffer_1019013844.md) method of the [DataReader](datareader.md) class.

## -examples

Sample applications that use this method include the [HttpClient sample](/samples/microsoft/windows-universal-samples/httpclient/).

## -see-also

[HttpClient sample](/samples/microsoft/windows-universal-samples/httpclient/)