---
-api-id: M:Windows.Storage.Streams.RandomAccessStream.CopyAsync(Windows.Storage.Streams.IInputStream,Windows.Storage.Streams.IOutputStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<ulong, ulong> CopyAsync(Windows.Storage.Streams.IInputStream source, Windows.Storage.Streams.IOutputStream destination)
-->

# Windows.Storage.Streams.RandomAccessStream.CopyAsync

## -description

Copies a source stream to a destination stream.

## -parameters

### -param source

The stream to copy data from.

### -param destination

The stream to copy data to.

## -returns

The byte writer operation. The first integer represents the number of bytes written. The second integer represents the progress of the write operation.

## -remarks

## -examples

## -see-also

[CopyAsync(IInputStream, IOutputStream, UInt64)](randomaccessstream_copyasync_651010873.md), [IAsyncOperationWithProgress&lt;ulong, ulong&gt;](../windows.foundation/iasyncoperationwithprogress_2.md)
