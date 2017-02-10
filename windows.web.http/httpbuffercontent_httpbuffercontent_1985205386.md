---
-api-id: M:Windows.Web.Http.HttpBufferContent.#ctor(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public HttpBufferContent(Windows.Storage.Streams.IBuffer content)
-->

# Windows.Web.Http.HttpBufferContent.HttpBufferContent

## -description
Initializes a new instance of the [HttpBufferContent](httpbuffercontent.md) class with the specified buffer.

## -parameters
### -param content
The content used to initialize the [HttpBufferContent](httpbuffercontent.md).

## -exceptions
### E_INVALIDARG

The *content* parameter is **null** (**Nothing** in Visual Basic).

## -remarks
The entire buffer specified in the *content* parameter is used to initialize the [HttpBufferContent](httpbuffercontent.md).

## -examples

## -see-also
[HttpBufferContent(IBuffer, UInt32, UInt32)](httpbuffercontent_httpbuffercontent_2118840992.md)