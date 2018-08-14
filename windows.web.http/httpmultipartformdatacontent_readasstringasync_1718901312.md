---
-api-id: M:Windows.Web.Http.HttpMultipartFormDataContent.ReadAsStringAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync()
-->

# Windows.Web.Http.HttpMultipartFormDataContent.ReadAsStringAsync

## -description
Serialize the [HttpMultipartFormDataContent](httpmultipartformdatacontent.md) to a [String](https://msdn.microsoft.com/library/system.string.aspx) as an asynchronous operation.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(String, UInt64)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after all of the content has been written to the [String](https://msdn.microsoft.com/library/system.string.aspx).

The [HttpMultipartFormDataContent](httpmultipartformdatacontent.md) class can be used to stream content that might be of arbitrary length. The [ReadAsStringAsync](httpmultipartformdatacontent_readasstringasync_1718901312.md) method will fail if all of the [HttpMultipartFormDataContent](httpmultipartformdatacontent.md) can't fit in memory since this method requires the entire content to be buffered in memory first.

## -examples

## -see-also
