---
-api-id: M:Windows.Storage.Streams.DataWriter.FlushAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> FlushAsync()
-->

# Windows.Storage.Streams.DataWriter.FlushAsync

## -description  
Flushes data asynchronously.


<!--<abstract  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">Returns an asynchronous sequential <xref targtype="class_winrt" rid="w_storage_streams.streamflushoperation">StreamFlushOperation</xref> object.</abstract>-->

## -returns
The stream flush operation.

## -remarks
The FlushAsync method may produce latencies and does not always guarantee durable and coherent storage of data. It's generally recommended to avoid this method if possible.

## -examples

## -see-also
[IDataWriter](idatawriter.md)