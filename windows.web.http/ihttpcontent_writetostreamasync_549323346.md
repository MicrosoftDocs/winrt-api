---
-api-id: M:Windows.Web.Http.IHttpContent.WriteToStreamAsync(Windows.Storage.Streams.IOutputStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<ulong, ulong> WriteToStreamAsync(Windows.Storage.Streams.IOutputStream outputStream)
-->

# Windows.Web.Http.IHttpContent.WriteToStreamAsync

## -description
Write the HTTP content to an output stream as an asynchronous operation.

## -parameters
### -param outputStream
The output stream to write to.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(UInt64, UInt64)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after all of the content has been written to the output stream.

## -examples

## -see-also
