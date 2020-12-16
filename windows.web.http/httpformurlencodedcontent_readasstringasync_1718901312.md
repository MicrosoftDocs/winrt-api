---
-api-id: M:Windows.Web.Http.HttpFormUrlEncodedContent.ReadAsStringAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync()
-->

# Windows.Web.Http.HttpFormUrlEncodedContent.ReadAsStringAsync

## -description
Serialize the [HttpFormUrlEncodedContent](httpformurlencodedcontent.md) to a [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) as an asynchronous operation.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(String, UInt64)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after all of the content has been written to the [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true).

## -examples

## -see-also
