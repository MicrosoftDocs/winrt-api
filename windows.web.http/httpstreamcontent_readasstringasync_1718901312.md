---
-api-id: M:Windows.Web.Http.HttpStreamContent.ReadAsStringAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync()
-->

# Windows.Web.Http.HttpStreamContent.ReadAsStringAsync

## -description
Serialize the [HttpStreamContent](httpstreamcontent.md) to a [String](https://msdn.microsoft.com/library/system.string.aspx) as an asynchronous operation.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(String, UInt64)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after all of the content has been written to the [String](https://msdn.microsoft.com/library/system.string.aspx).

The [HttpStreamContent](httpstreamcontent.md) class can be used to stream content that might be of arbitrary length. The [ReadAsStringAsync](httpstreamcontent_readasstringasync_1718901312.md) method will fail if all of the [HttpStreamContent](httpstreamcontent.md) can't fit in memory since this method requires the entire content to be buffered in memory first.

## -examples

## -see-also
