---
-api-id: M:Windows.Storage.Streams.IDataWriter.FlushAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> FlushAsync()
-->

# Windows.Storage.Streams.IDataWriter.FlushAsync

## -description
<!--{annotation author="miriamw" time="6/1/2012 1:04:52 PM"}Description contained link to an API that DNE. Used other flushAsync method description to rewrite this one. Original description appears in comment immediately following.-->
Flushes data asynchronously.


<!--<abstract  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">Returns an asynchronous sequential <xref targtype="class_winrt" rid="w_storage_streams.streamflushoperation">StreamFlushOperation</xref> object.</abstract>-->

## -returns
The stream flush operation.

## -remarks
The [FlushAsync](datawriter_flushasync.md) method ensures that the data has reached the target storage medium that the stream represents. For example, to improve application responsiveness and throughput, a file stream might respond to a write operation by copying the buffer into another temporary storage medium and returning immediately, while the target device begins writing the data concurrently.


<!--{annotation author="miriamw" time="6/1/2012 1:04:52 PM"}Remark contained link to an API the DNE. rewrote last comma delimited clause. Original remark appears in comment immediately following.-->
The [FlushAsync](datawriter_flushasync.md) method doesn't complete until all data specified in previous write calls has reached the target storage medium. If the data can't be written, or an error occurred during a write operation, the method returns false.


<!--<p  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">The <xref targtype="method_winrt" rid="w_storage_streams.datawriter_flushasync">FlushAsync</xref> method doesn't complete until all data specified in previous write calls has reached the target storage medium. If the data can't be written, or an error occurred during a write operation, the error is communicated to the application through the <xref targtype="class_winrt" rid="w_storage_streams.streamflushoperation">StreamFlushOperation</xref>.</p>-->
For streams which write data immediately, [FlushAsync](datawriter_flushasync.md) has no effect and completes immediately.

## -examples

## -see-also
