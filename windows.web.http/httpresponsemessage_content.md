---
-api-id: P:Windows.Web.Http.HttpResponseMessage.Content
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.IHttpContent Content { get;  set; }
-->

# Windows.Web.Http.HttpResponseMessage.Content

## -description
Gets or sets the content of the HTTP response message on the [HttpResponseMessage](httpresponsemessage.md) object.

## -property-value
The content of the HTTP response message on the [HttpResponseMessage](httpresponsemessage.md) object.

## -remarks
The content of an HTTP response message corresponds to the entity body defined in [RFC 2616](https://tools.ietf.org/html/rfc2616).

A number of classes and an interface can be used for HTTP content. These include the following.


+ [IHttpContent](ihttpcontent.md) - a base interface representing an HTTP entity body and content headers.
+ [HttpBufferContent](httpbuffercontent.md) - HTTP content based on a stream.
+ [HttpFormUrlEncodedContent](httpformurlencodedcontent.md) - HTTP content based on name/value data encoded using application/x-www-form-urlencoded MIME type.
+ [HttpStreamContent](httpstreamcontent.md) - HTTP content based on a stream.
+ [HttpStringContent](httpstringcontent.md) - HTTP content based on a string.


## -examples

## -see-also
