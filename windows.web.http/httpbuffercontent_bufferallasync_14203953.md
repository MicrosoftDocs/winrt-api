---
-api-id: M:Windows.Web.Http.HttpBufferContent.BufferAllAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<ulong, ulong> BufferAllAsync()
-->

# Windows.Web.Http.HttpBufferContent.BufferAllAsync

## -description
Serialize the [HttpBufferContent](httpbuffercontent.md) into memory as an asynchronous operation.

## -returns
The object that represents the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(UInt64, UInt64)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after all of the content has been written into memory.

## -examples

## -see-also
