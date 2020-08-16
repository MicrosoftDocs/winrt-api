---
-api-id: M:Windows.Web.Http.HttpStringContent.ReadAsInputStreamAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Storage.Streams.IInputStream, ulong> ReadAsInputStreamAsync()
-->

# Windows.Web.Http.HttpStringContent.ReadAsInputStreamAsync

## -description
Serialize the [HttpStringContent](httpstringcontent.md) and return an input stream that represents the content as an asynchronous operation.

## -returns
The object that represents the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) (of [IInputStream](/uwp/api/windows.storage.streams.iinputstream) and unsigned 64-bit integer) completes after all of the content has been written to the stream.

## -examples

## -see-also
