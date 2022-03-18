---
-api-id: T:Windows.Web.Http.IHttpContent
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IHttpContent : Windows.Foundation.IClosable
-->

# Windows.Web.Http.IHttpContent

## -description
Provides a base interface for an HTTP entity body and content headers.

## -remarks
The contents of an HTTP message corresponds to the entity body and headers associated with the content defined in [RFC 2616](https://tools.ietf.org/html/rfc2616). Several classes and an interface in the [Windows.Web.Http](windows_web_http.md) namespace can be used for HTTP content, including:


+ IHttpContent - A base interface for developers to create their own content objects. It represents an HTTP entity body and content headers. This interface has methods that get and set the actual content data. It also provides properties that get and set content related headers.
+ [HttpBufferContent](httpbuffercontent.md) - HTTP content that uses a buffer.
+ [HttpFormUrlEncodedContent](httpformurlencodedcontent.md) - HTTP content that uses name/value tuples encoded with the **application/x-www-form-urlencoded** MIME type.
+ [HttpMultipartContent](httpmultipartcontent.md) - HTTP content that uses **multipart/*** MIME type.
+ [HttpMultipartFormDataContent](httpmultipartformdatacontent.md) - HTTP content that uses the encoded **multipart/form-data** MIME type.
+ [HttpStreamContent](httpstreamcontent.md) - HTTP content that uses a stream. This content type is used by the HTTP methods to receive data and HTTP methods to upload data.
+ [HttpStringContent](httpstringcontent.md) - HTTP content that uses a string.


## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md), [IStringable](../windows.foundation/istringable.md)
