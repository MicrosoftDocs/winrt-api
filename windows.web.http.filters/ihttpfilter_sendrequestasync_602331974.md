---
-api-id: M:Windows.Web.Http.Filters.IHttpFilter.SendRequestAsync(Windows.Web.Http.HttpRequestMessage)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Http.HttpResponseMessage, Windows.Web.Http.HttpProgress> SendRequestAsync(Windows.Web.Http.HttpRequestMessage request)
-->

# Windows.Web.Http.Filters.IHttpFilter.SendRequestAsync

## -description
Send an HTTP request on the [IHttpFilter](ihttpfilter.md) instance as an asynchronous operation.

## -parameters
### -param request
The HTTP request message to send.

## -returns
The object representing the asynchronous operation.

## -exceptions
### E_INVALIDARG

The *request* parameter was a **null** reference (**Nothing** in Visual Basic).

### E_ILLEGAL_METHOD_CALL

The request message was already sent by the [IHttpFilter](ihttpfilter.md) instance.

## -remarks
Custom filters are implemented in the [SendRequestAsync](ihttpfilter_sendrequestasync.md) method on their [IHttpFilter](ihttpfilter.md) interface.

Classes in the [Windows.Web.Http](../windows.web.http/windows_web_http.md) namespace support the use of filters based on the classes in the [Windows.Web.Http.Filters](windows_web_http_filters.md) namespace. The [HttpClient](../windows.web.http/httpclient.md) class in the [Windows.Web.Http](../windows.web.http/windows_web_http.md) namespace provides a base class for sending HTTP requests and receiving HTTP responses. Filters provide a handler mechanism to help with common HTTP service issues. Simple filters can be chained together in a sequence to handle more complex HTTP service issues.

An HTTP filter is a black box which takes an HTTP request message and produces an HTTP response message. How the filter gets an HTTP response is determined by the filter developer. An app can create the response immediately, it can send the request over TCP to a server, it can even send multiple requests to a server (or to more than one server) before it generates a response message. Since it is unspecified how a filter gets to a response message, a filter can pass the request message to another filter (called the inner filter), thus delegating the creation of a response message to the inner filter.

Filters commonly add or change headers, handle authorization (possibly using the [WebAuthenticationBroker](../windows.security.authentication.web/webauthenticationbroker.md)), or allow or disallow a request based on network conditions. Filters usually make changes and then pass the request to an inner filter, which is typically set when a filter is constructed.

This approach allows filters to be only responsible for a specific aspect of an HTTP request execution and delegate other aspects to other filters. A filter can implement caching, authentication, redirects, cookies, actual communication with the server, or a combination of these. The bottom-most (base) filter will usually be the one that does actual communication with the network.

## -examples

## -see-also
