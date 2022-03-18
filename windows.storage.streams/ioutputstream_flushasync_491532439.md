---
-api-id: M:Windows.Storage.Streams.IOutputStream.FlushAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> FlushAsync()
-->

# Windows.Storage.Streams.IOutputStream.FlushAsync

## -description
Flushes data asynchronously in a sequential stream.

## -returns
The stream flush operation.

## -remarks
The FlushAsync method improves, but does not guarantee durable and coherent storage of data and it introduces latencies. It's generally recommended to avoid this method to achieve good performance but it should be used if coherency is desired.

## -examples

## -see-also
