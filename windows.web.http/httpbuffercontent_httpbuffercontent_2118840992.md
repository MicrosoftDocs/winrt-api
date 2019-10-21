---
-api-id: M:Windows.Web.Http.HttpBufferContent.#ctor(Windows.Storage.Streams.IBuffer,System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public HttpBufferContent(Windows.Storage.Streams.IBuffer content, System.UInt32 offset, System.UInt32 count)
-->

# Windows.Web.Http.HttpBufferContent.HttpBufferContent

## -description
Initializes a new instance of the [HttpBufferContent](httpbuffercontent.md) class with an offset and count of bytes from the specified buffer.

## -parameters
### -param content
The content used to initialize the [HttpBufferContent](httpbuffercontent.md).

### -param offset
The offset in bytes from the beginning of the *content* buffer to initialize the [HttpBufferContent](httpbuffercontent.md).

### -param count
The count of bytes in the *content* buffer to initialize the [HttpBufferContent](httpbuffercontent.md).

## -remarks
Only the range specified by the *offset* parameter and the *count* parameter is used to initialize the [HttpBufferContent](httpbuffercontent.md).

Below are the exceptions that this content throws.
### E_INVALIDARG

The *content* parameter is **null** (**Nothing** in Visual Basic).

The *offset* parameter is less than zero.

The *offset* parameter is greater than the length of content specified by the *content* parameter.

The *count* parameter is less than zero or the *count* parameter is greater than the length of content specified by the *count* parameter minus the *offset* parameter.

## -examples

See [POST binary data over HTTP](/windows/uwp/networking/httpclient#post-binary-data-over-http).

## -see-also
[HttpBufferContent(IBuffer)](httpbuffercontent_httpbuffercontent_1985205386.md)