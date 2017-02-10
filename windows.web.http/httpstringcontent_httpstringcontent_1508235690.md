---
-api-id: M:Windows.Web.Http.HttpStringContent.#ctor(System.String,Windows.Storage.Streams.UnicodeEncoding,System.String)
-api-type: winrt method
---

<!-- Method syntax
public HttpStringContent(System.String content, Windows.Storage.Streams.UnicodeEncoding encoding, System.String mediaType)
-->

# Windows.Web.Http.HttpStringContent.HttpStringContent

## -description
Initializes a new instance of the [HttpStringContent](httpstringcontent.md) class with the specified content, encoding, and media type.

## -parameters
### -param content
The content used to initialize the [HttpStringContent](httpstringcontent.md).

### -param encoding
The encoding to use for the content.

### -param mediaType
The media type to use for the content.

## -remarks
The media type in the **Content-Type** header for the [HttpStringContent](httpstringcontent.md) created is set to the value of the *mediaType* parameter.

## -examples

## -see-also
[HttpStringContent(String)](httpstringcontent_httpstringcontent_290278668.md), [HttpStringContent(String, UnicodeEncoding)](httpstringcontent_httpstringcontent_1071791402.md)