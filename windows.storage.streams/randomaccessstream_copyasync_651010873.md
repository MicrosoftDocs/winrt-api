---
-api-id: M:Windows.Storage.Streams.RandomAccessStream.CopyAsync(Windows.Storage.Streams.IInputStream,Windows.Storage.Streams.IOutputStream,System.UInt64)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<ulong, ulong> CopyAsync(Windows.Storage.Streams.IInputStream source, Windows.Storage.Streams.IOutputStream destination, System.UInt64 bytesToCopy)
-->

# Windows.Storage.Streams.RandomAccessStream.CopyAsync

## -description

Copies the specified number of bytes from a source stream to a destination stream.

## -parameters

### -param source

The stream to copy data from.

### -param destination

The stream to copy data to.

### -param bytesToCopy

The number of bytes to copy.

## -returns

The byte writer operation. The first integer represents the number of bytes written. The second integer represents the progress of the write operation.

## -remarks

## -examples

## -see-also

[CopyAsync(IInputStream, IOutputStream)](randomaccessstream_copyasync_1577084715.md), [IAsyncOperationWithProgress&lt;ulong, ulong&gt;](../windows.foundation/iasyncoperationwithprogress_2.md)
