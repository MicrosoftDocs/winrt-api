---
-api-id: M:Windows.Web.Http.HttpStreamContent.WriteToStreamAsync(Windows.Storage.Streams.IOutputStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<ulong, ulong> WriteToStreamAsync(Windows.Storage.Streams.IOutputStream outputStream)
-->

# Windows.Web.Http.HttpStreamContent.WriteToStreamAsync

## -description
Write the [HttpStreamContent](httpstreamcontent.md) to an output stream as an asynchronous operation.

## -parameters
### -param outputStream
The output stream to write to.

## -returns
The object that represents the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(UInt64, UInt64)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after all of the content has been written to the output stream.

## -examples

## -see-also
