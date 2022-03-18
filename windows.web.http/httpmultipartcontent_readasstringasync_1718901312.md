---
-api-id: M:Windows.Web.Http.HttpMultipartContent.ReadAsStringAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync()
-->

# Windows.Web.Http.HttpMultipartContent.ReadAsStringAsync

## -description
Serialize the [HttpMultipartContent](httpmultipartcontent.md) to a [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) as an asynchronous operation.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(String, UInt64)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after all of the content has been written to the [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true).

The [HttpMultipartContent](httpmultipartcontent.md) class can be used to stream content that might be of arbitrary length. The ReadAsStringAsync method will fail if all of the [HttpMultipartContent](httpmultipartcontent.md) can't fit in memory since this method requires the entire content to be buffered in memory first.

## -examples

## -see-also
