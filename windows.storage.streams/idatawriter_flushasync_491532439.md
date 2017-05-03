---
-api-id: M:Windows.Storage.Streams.IDataWriter.FlushAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> FlushAsync()
-->

# Windows.Storage.Streams.IDataWriter.FlushAsync

## -description
Flushes data asynchronously.

## -returns
The stream flush operation.

## -remarks
The [FlushAsync](datawriter_flushasync.md) method ensures that the data has reached the target storage medium that the stream represents. For example, to improve application responsiveness and throughput, a file stream might respond to a write operation by copying the buffer into another temporary storage medium and returning immediately, while the target device begins writing the data concurrently.

The [FlushAsync](datawriter_flushasync.md) method doesn't complete until all data specified in previous write calls has reached the target storage medium. If the data can't be written, or an error occurred during a write operation, the method returns false.

The FlushAsync method may produce latencies and does not always guarantee durable and coherent storage of data. It's generally recommended to avoid this method if possible.

## -examples

## -see-also
