---
-api-id: P:Windows.Web.Http.HttpRequestMessage.Content
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.IHttpContent Content { get;  set; }
-->

# Windows.Web.Http.HttpRequestMessage.Content

## -description
Gets or sets the HTTP content to send to the server on the [HttpRequestMessage](httprequestmessage.md) object.

## -property-value
The HTTP content to send to the server on the [HttpRequestMessage](httprequestmessage.md) object.

## -remarks
The content of an HTTP request message corresponds to the entity body defined in RFC 2616.

A number of classes and an interface can be used for HTTP content. These include the following.


+ [IHttpContent](ihttpcontent.md) - a base interface representing an HTTP entity body and content headers.
+ [HttpBufferContent](httpbuffercontent.md) - HTTP content based on a stream.
+ [HttpFormUrlEncodedContent](httpformurlencodedcontent.md) - HTTP content based on name/value data encoded using application/x-www-form-urlencoded MIME type.
+ [HttpMultipartContent](httpmultipartcontent.md) - HTTP content that uses multipart/* MIME type.
+ [HttpMultipartFormDataContent](httpmultipartformdatacontent.md) - HTTP content that uses the encoded multipart/form-data MIME type.
+ [HttpStreamContent](httpstreamcontent.md) - HTTP content based on a stream.
+ [HttpStringContent](httpstringcontent.md) - HTTP content based on a string.


A number of [HttpClient](httpclient.md) methods don't need to set the Content property on the [HttpRequestMessage](httprequestmessage.md). These include the following:
+ The [HttpClient.GetAsync](/uwp/api/windows.web.http.httpclient.getasync) methods.
+ [HttpClient.GetBufferAsync](httpclient_getbufferasync_894906839.md).
+ [HttpClient.GetInputStreamAsync](httpclient_getinputstreamasync_1910746187.md).
+ [HttpClient.GetStringAsync](httpclient_getstringasync_149346728.md).


## -examples

## -see-also
