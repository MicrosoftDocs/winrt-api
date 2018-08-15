---
-api-id: M:Windows.Storage.Streams.IOutputStream.WriteAsync(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<uint, uint> WriteAsync(Windows.Storage.Streams.IBuffer buffer)
-->

# Windows.Storage.Streams.IOutputStream.WriteAsync

## -description
Writes data asynchronously in a sequential stream.

## -parameters
### -param buffer
A buffer that contains the data to be written.

## -returns
The byte writer operation. The first integer represents the number of bytes written. The second integer represents the progress of the write operation. 

## -remarks
Some stream implementations support queuing of write operations. In this case, the asynchronous execution of the [WriteAsync](ioutputstream_writeasync_897036872.md) method does not complete until the [FlushAsync](ioutputstream_flushasync_491532439.md) method has completed. For the *buffer* parameter, you don't have to implement the [IBuffer](ibuffer.md) interface. Instead, you can create an instance of the [Buffer](buffer.md) class or create a buffer by using methods in the [CryptographicBuffer](../windows.security.cryptography/cryptographicbuffer.md) class.

Also consider writing a buffer into an [IOutputStream](ioutputstream.md) by using the [WriteBuffer](datawriter_writebuffer_210574036.md) method of the [DataWriter](datawriter.md) class.

## -examples

## -see-also
