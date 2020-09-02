---
-api-id: N:Windows.Web.Http.Filters
-api-type: winrt namespace
---

# Windows.Web.Http.Filters

## -description

Provides classes to send HTTP requests and an interface to create filters to target HTTP and REST services in UWP app.

## -remarks

The [Windows.Web.Http](../windows.web.http/windows_web_http.md) namespace and the related [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md) and Windows.Web.Http.Filters namespaces provides an HTTP programming interface for UWP app that want to connect to HTTP services. The HTTP API provides consistent support in JavaScript, C#, VB.NET, and C++ for developers. The API also supports adding custom filters on requests and responses. Filters can simplify handling more complex network issues. The API also lets an app control read and write caching behavior.

Classes in the [Windows.Web.Http](../windows.web.http/windows_web_http.md) namespace support the use of filters based on the classes in the Windows.Web.Http.Filters namespace. Classes in the Windows.Web.Http.Filters namespace also let an app control read and write caching behavior on the client. The [HttpCacheDirectiveHeaderValueCollection](../windows.web.http.headers/httpcachedirectiveheadervaluecollection.md) in the [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md) provides a collection container for instances of the cache directives in **Cache-Control** HTTP header on HTTP content associated with an HTTP request or response. The **Cache-Control** header lets an app have more control over caching behavior.

Classes in the [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md) namespace represent HTTP headers as defined in [RFC 2616](https://tools.ietf.org/html/rfc2616) by the IETF.

The [HttpClient](../windows.web.http/httpclient.md) class in the [Windows.Web.Http](../windows.web.http/windows_web_http.md) namespace provides a base class for sending HTTP requests and receiving HTTP responses. Filters provide a handler mechanism to help with common HTTP service issues. Simple filters can be chained together in a sequence to handle more complex HTTP service issues.

An HTTP filter is a black box which takes an HTTP request message and produces an HTTP response message. How the filter gets an HTTP response is determined by the filter developer. Filters commonly add or change headers, handle authorization (possibly using the [WebAuthenticationBroker](../windows.security.authentication.web/webauthenticationbroker.md)), or allow or disallow a request based on network conditions. Filters usually make changes and then pass the request to an inner filter, which is typically set when a filter is constructed.

This approach allows a filter to be only responsible for a specific aspect of an HTTP request execution and delegate other aspects to other filters. A filter can implement caching, authentication, redirects, cookies, actual communication with the server, or a combination of these. The bottom-most (base) filter will usually be the one that does actual communication with the network.

Many apps that use HTTP for network access often need to respond to a variety of conditions. Some common examples include:

+ Network retry (with back-off).
+ Adapting to metered networks (when a network connection is roaming, for example).
+ Authentication to social network sites.
+ Logging and telemetry.

It’s not hard to handle any of these network issues by themselves. This becomes a complex problem when several of these issues are combined. Support for custom filters in the Windows.Web.Http.Filters namespace enables developers to create modular code for simple filters. A series of simple filters can be linked into a chain of filters to handle complex combinations of issues. The developer chooses everything about the filter chain:

+ The filters to add.
+ The order to place them in the filter chain.

[HttpClient](../windows.web.http/httpclient.md) is the main class used to send and receive requests over HTTP. [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) is what [HttpClient](../windows.web.http/httpclient.md) uses to send and receive data. So [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) is typically the bottom of any custom filter chain. [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) can also be used to control caching and other behavior of the HTTP connection. Each [HttpClient](../windows.web.http/httpclient.md) instance can have a different filter chain or pipeline.

<!--The following image is the identical same file being used in the m_dev_guide project  that is handling the artwork and localization of this file. -->
<img src="../images/HTTP_Filters.png" alt="Drawing of an HTTP filter chain" />

To write a custom filter, an app implements a custom version of the [IHttpFilter](ihttpfilter.md) interface. The code to implement the filter behavior is in the [IHttpFilter.SendRequestAsync](ihttpfilter_sendrequestasync_602331974.md) method. Filters can be written in C#/VB.NET or C++. Filters can be called and used from any language supported for UWP app including JavaScript.

The sample code shows a filter to add a custom header to HTTP requests and responses.

```csharp
public class PlugInFilter : IHttpFilter {
    private IHttpFilter innerFilter;

    public PlugInFilter(IHttpFilter innerFilter) {
        if (innerFilter == null) {
            throw new ArgumentException("innerFilter cannot be null.");
        }
        this.innerFilter = innerFilter;
    }

    public IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(HttpRequestMessage request) {
        return AsyncInfo.Run<HttpResponseMessage, HttpProgress>(async (cancellationToken, progress) =>
        {
            request.Headers.Add("Custom-Header", "CustomRequestValue");
            HttpResponseMessage response = await innerFilter.SendRequestAsync(request).AsTask(cancellationToken, progress);

            cancellationToken.ThrowIfCancellationRequested();

            response.Headers.Add("Custom-Header", "CustomResponseValue");
        return response;
        });
    }

    public void Dispose() {
        innerFilter.Dispose();
        GC.SuppressFinalize(this);
    }
}

```

To use a filter, an app uses the [HttpClient(IHttpFilter)](../windows.web.http/httpclient_httpclient_782807480.md) constructor passing the interface of the filter to use for the [HttpClient](../windows.web.http/httpclient.md) instance. To set up the filter chain, the new filter is linked to a previous filter and to [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) at the bottom.

The sample code shows creating an [HttpClient](../windows.web.http/httpclient.md) to use a custom filter.

```csharp

internal static void CreateHttpClient(ref HttpClient httpClient)
{
    if (httpClient != null) {
        httpClient.Dispose();
    }

    // HttpClient can be extended by plugging multiple filters together,
    // providing HttpClient with the configured filter pipeline.
    var baseFilter = new HttpBaseProtocolFilter();

    // Adds a custom header to every request and response message.
    var myFilter = new PlugInFilter(baseFilter);
    httpClient = new HttpClient(myFilter);

}


```

## -examples

## -see-also

[HttpClient](../windows.web.http/httpclient.md), [Windows.Web.Http](../windows.web.http/windows_web_http.md), [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md), [HttpClient sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HttpClient)
