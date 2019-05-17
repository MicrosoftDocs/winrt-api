---
-api-id: M:Windows.Web.Http.HttpMultipartContent.BufferAllAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<ulong, ulong> BufferAllAsync()
-->

# Windows.Web.Http.HttpMultipartContent.BufferAllAsync

## -description
Serialize the [HttpMultipartContent](httpmultipartcontent.md) into memory as an asynchronous operation.

## -returns
The object that represents the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(UInt64, UInt64)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after all of the content has been written into memory.

The [HttpMultipartContent](httpmultipartcontent.md) class can be used to stream content that might be of arbitrary length. The BufferAllAsync method will fail if all of the [HttpMultipartContent](httpmultipartcontent.md) can't fit in memory.

## -examples

## -see-also
