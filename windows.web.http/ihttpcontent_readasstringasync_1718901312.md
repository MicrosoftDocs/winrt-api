---
-api-id: M:Windows.Web.Http.IHttpContent.ReadAsStringAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync()
-->

# Windows.Web.Http.IHttpContent.ReadAsStringAsync

## -description
Serialize the HTTP content to a [String](https://docs.microsoft.com/dotnet/api/system.string?redirectedfrom=MSDN) as an asynchronous operation.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(String, UInt64)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after all of the content has been written to the [String](https://docs.microsoft.com/dotnet/api/system.string?redirectedfrom=MSDN).

## -examples

## -see-also
[String](https://docs.microsoft.com/dotnet/api/system.string?redirectedfrom=MSDN)