---
-api-id: M:Windows.Web.Http.HttpStreamContent.ReadAsInputStreamAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Storage.Streams.IInputStream, ulong> ReadAsInputStreamAsync()
-->

# Windows.Web.Http.HttpStreamContent.ReadAsInputStreamAsync

## -description
Serialize the [HttpStreamContent](httpstreamcontent.md) and return an input stream that represents the content as an asynchronous operation.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) (of [IInputStream](/uwp/api/windows.storage.streams.iinputstream) and unsigned 64-bit integer) completes after all of the content has been written to the stream.

## -examples

## -see-also
