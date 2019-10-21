---
-api-id: M:Windows.Web.Http.HttpFormUrlEncodedContent.ReadAsBufferAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Storage.Streams.IBuffer, ulong> ReadAsBufferAsync()
-->

# Windows.Web.Http.HttpFormUrlEncodedContent.ReadAsBufferAsync

## -description
Serialize the [HttpFormUrlEncodedContent](httpformurlencodedcontent.md) to a buffer as an asynchronous operation.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) (of [IBuffer](/uwp/api/windows.storage.streams.ibuffer) and unsigned 64-bit integer) completes after all of the content has been written to the buffer.

## -examples

## -see-also
