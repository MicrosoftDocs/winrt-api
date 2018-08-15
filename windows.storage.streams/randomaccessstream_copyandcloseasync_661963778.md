---
-api-id: M:Windows.Storage.Streams.RandomAccessStream.CopyAndCloseAsync(Windows.Storage.Streams.IInputStream,Windows.Storage.Streams.IOutputStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<ulong, ulong> CopyAndCloseAsync(Windows.Storage.Streams.IInputStream source, Windows.Storage.Streams.IOutputStream destination)
-->

# Windows.Storage.Streams.RandomAccessStream.CopyAndCloseAsync

## -description
Copies a source stream to a destination stream and waits for the copy operation to complete.

## -parameters
### -param source
The stream to copy data from.

### -param destination
The stream to copy data to.

## -returns
The asynchronous operation.

## -remarks
The [CopyAndCloseAsync](randomaccessstream_copyandcloseasync_661963778.md) method is similar to [CopyAsync](randomaccessstream_copyasync_1577084715.md) but also calls and waits for [FlushAsync](ioutputstream_flushasync_491532439.md) and [Close](http://msdn.microsoft.com/library/b08161d3-01d9-4782-a3fa-ead15da8b7d9) on the output stream before its asynchronous operation completes.

## -examples

## -see-also
