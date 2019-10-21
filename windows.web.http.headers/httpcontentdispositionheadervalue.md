---
-api-id: T:Windows.Web.Http.Headers.HttpContentDispositionHeaderValue
-api-type: winrt class
---

<!-- Class syntax.
public class HttpContentDispositionHeaderValue : Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpContentDispositionHeaderValue
-->

# Windows.Web.Http.Headers.HttpContentDispositionHeaderValue

## -description
Represents the value of the **Content-Disposition** HTTP header on HTTP content in a request or a response.

## -remarks
The HttpContentDispositionHeaderValue class represents information in the **Content-Disposition** header on HTTP content sent in an HTTP request or received in an HTTP response.

The [ContentDisposition](httpcontentheadercollection_contentdisposition.md) property on the [HttpContentHeaderCollection](httpcontentheadercollection.md) returns an HttpContentDispositionHeaderValue.

The **Content-Disposition** header is normally used for working with file uploads and downloads. The format differs from other headers in that it is a single header with a disposition type followed by a list of parameters, some of which are well defined.

This header is used in two different contexts: 
+ A MIME header for nested body content in the [HttpMultipartFormDataContent](../windows.web.http/httpmultipartformdatacontent.md) class. For more information, see IETF RFC 2183.
+ An HTTP header in [HttpContentHeaderCollection](httpcontentheadercollection.md) class. For more information, see IETF RFC 6266.

## -examples
See the code example in [HttpContentHeaderCollection class](httpcontentheadercollection.md).

## -see-also
[ContentDisposition](httpcontentheadercollection_contentdisposition.md), [HttpContentHeaderCollection](httpcontentheadercollection.md), [IStringable](../windows.foundation/istringable.md)
