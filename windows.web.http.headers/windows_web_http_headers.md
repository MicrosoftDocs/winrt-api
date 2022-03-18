---
-api-id: N:Windows.Web.Http.Headers
-api-type: winrt namespace
---

# Windows.Web.Http.Headers

## -description

Provides support for HTTP headers used by the [Windows.Web.Http](../windows.web.http/windows_web_http.md) namespace for UWP app that target HTTP services.

## -remarks

The [Windows.Web.Http](../windows.web.http/windows_web_http.md) namespace and the related Windows.Web.Http.Headers and [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md) namespaces provide a programming interface for UWP app that connect to HTTP and REST services. These namespaces provides consistent support in JavaScript, C#, VB.NET, and C++ for HTTP app developers.

Classes in the Windows.Web.Http.Headers namespace represent HTTP headers defined in [RFC 2616](https://tools.ietf.org/html/rfc2616) by the IETF. HTTP headers are associated with the [HttpRequestMessage](../windows.web.http/httprequestmessage.md), [HttpResponseMessage](../windows.web.http/httpresponsemessage.md), and HTTP content sent with an HTTP request message or received with an HTTP response message.

The primary classes in the Windows.Web.Http.Headers namespace are the following:

+ [HttpRequestHeaderCollection](httprequestheadercollection.md) - a collection of the HTTP headers associated with an HTTP request.
+ [HttpResponseHeaderCollection](httpresponseheadercollection.md) - a collection of the HTTP headers associated with an HTTP response.
+ [HttpContentHeaderCollection](httpcontentheadercollection.md) - a collection of the HTTP headers associated with the content, which can be used on an HTTP request or response.

Most of the properties on these primary classes provide access to strongly-typed class objects for specific HTTP headers.

The [Headers](../windows.web.http/httprequestmessage_headers.md) property on [HttpRequestMessage](../windows.web.http/httprequestmessage.md) returns an [HttpRequestHeaderCollection](httprequestheadercollection.md) object. The [DefaultRequestHeaders](../windows.web.http/httpclient_defaultrequestheaders.md) property on [HttpClient](../windows.web.http/httpclient.md) also returns an [HttpRequestHeaderCollection](httprequestheadercollection.md) object.

The [Headers](../windows.web.http/httpresponsemessage_headers.md) property on [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) returns an [HttpResponseHeaderCollection](httpresponseheadercollection.md) object.

The [HttpContentHeaderCollection](httpcontentheadercollection.md) has a constructor and also is returned by the  property on [HttpBufferContent](../windows.web.http/httpbuffercontent.md), [HttpFormUrlEncodedContent](../windows.web.http/httpformurlencodedcontent.md), [HttpMultipartContent](../windows.web.http/httpmultipartcontent.md), [HttpMultipartFormDataContent](../windows.web.http/httpmultipartformdatacontent.md), [HttpStringContent](../windows.web.http/httpstringcontent.md), and [HttpStreamContent](../windows.web.http/httpstreamcontent.md) classes and the [IHttpContent](../windows.web.http/ihttpcontent.md) interface.

## -examples

## -see-also

[HttpClient](../windows.web.http/httpclient.md), [HttpRequestMessage](../windows.web.http/httprequestmessage.md), [HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [Windows.Web.Http](../windows.web.http/windows_web_http.md), [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md), [HttpClient sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HttpClient)
