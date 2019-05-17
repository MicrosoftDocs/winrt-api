---
-api-id: M:Windows.Web.Http.HttpStreamContent.BufferAllAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<ulong, ulong> BufferAllAsync()
-->

# Windows.Web.Http.HttpStreamContent.BufferAllAsync

## -description
Serialize the [HttpStreamContent](httpstreamcontent.md) into memory as an asynchronous operation.

## -returns
The object that represents the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(UInt64, UInt64)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after all of the content has been written into memory.

The [HttpStreamContent](httpstreamcontent.md) class can be used to stream content that might be of arbitrary length. The BufferAllAsync method will fail if all of the [HttpStreamContent](httpstreamcontent.md) can't fit in memory.

## -examples

## -see-also
