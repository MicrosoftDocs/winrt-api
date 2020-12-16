---
-api-id: N:Windows.Web.Http
-api-type: winrt namespace
---

# Windows.Web.Http

## -description

Provides a modern HTTP client API for UWP app.

## -remarks

The Windows.Web.Http namespace and the related [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md) and [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md) namespaces provide a programming interface for UWP app that target HTTP and REST services. This features of this new HTTP API are designed to be in compliance with HTTP as defined in [RFC 2616](https://tools.ietf.org/html/rfc2616) by the IETF. The new HTTP API provides consistent support in JavaScript, C#, VB.NET, and C++ for developers.

This new API replaces the use of three different APIs with differing features that previously were needed for each language projection in Windows 8.

+ [WinJS.xhr](/previous-versions/windows/apps/br229787(v=win.10)) for JavaScript
+ [HttpClient](/dotnet/api/system.net.http.httpclient?view=dotnet-uwp-10.0&preserve-view=true) in the [System.Net.Http](/dotnet/api/system.net.http?view=dotnet-uwp-10.0&preserve-view=true) namespace for C# and VB.
+ [IXMLHTTPRequest2](/previous-versions/windows/desktop/api/msxml6/nn-msxml6-ixmlhttprequest2) for C++

Classes in the Windows.Web.Http and related namespaces are targeted at all levels of HTTP and REST development:

+ Basic HTTP developers
+ Site-specific HTTP library developers
+ Advanced HTTP developers

For basic HTTP developers, the new API has a simple interface to handle the most common tasks and sensible defaults for authentication that should work in most environments. For library developers, the consistent object model and multiple language support means you can write a library once for developers in all languages. For advanced HTTP developers, the new API includes a rich set of capabilities.

The Windows.Web.Http namespace and the related namespaces provide these components:

+ [HttpClient](httpclient.md) - the main class that sends and receives requests over HTTP.
+ [HttpRequestMessage](httprequestmessage.md) - HTTP request messages defined in [RFC 2616](https://tools.ietf.org/html/rfc2616).
+ [HttpResponseMessage](httpresponsemessage.md) - HTTP response messages defined in [RFC 2616](https://tools.ietf.org/html/rfc2616).

The contents of an HTTP message corresponds to the entity body defined in [RFC 2616](https://tools.ietf.org/html/rfc2616). Several classes and an interface in the Windows.Web.Http namespace can be used for HTTP content, including:

+ [IHttpContent](ihttpcontent.md) - A base interface for developers to create their own content objects. It represents an HTTP entity body and content headers. This interface has methods that get and set the actual content data. It also provides properties that get and set content related headers.
+ [HttpBufferContent](httpbuffercontent.md) - HTTP content that uses a buffer.
+ [HttpFormUrlEncodedContent](httpformurlencodedcontent.md) - HTTP content that uses name/value tuples encoded with the **application/x-www-form-urlencoded** MIME type.
+ [HttpMultipartContent](httpmultipartcontent.md) - HTTP content that uses **multipart/*** MIME type.
+ [HttpMultipartFormDataContent](httpmultipartformdatacontent.md) - HTTP content that uses the encoded **multipart/form-data** MIME type.
+ [HttpStreamContent](httpstreamcontent.md) - HTTP content that uses a stream. This content type is used by the HTTP GET method to receive data and the HTTP POST method to upload data.
+ [HttpStringContent](httpstringcontent.md) - HTTP content that uses a string.

Classes in the [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md) namespace represent HTTP headers defined in [RFC 2616](https://tools.ietf.org/html/rfc2616). HTTP headers are associated with [HttpRequestMessage](httprequestmessage.md) and [HttpResponseMessage](httpresponsemessage.md) as properties that are retrieved or set.

Classes in the Windows.Web.Http namespace can use filters based on the classes in the [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md) namespace. Filters provide handlers to help with common HTTP service issues. Filters can be chained together in a sequence to address more complex HTTP service issues. Several ready-to-use filters are included with Windows 8.1 to help library developers fix common HTTP service issues. These filters include handlers for monitored network connections and retry. Library developers can write their own filters for site-specific issues (for example, a site might use the 503 (Server Unavailable) response to indicate the request should be retried).

If an app that uses the Windows.Web.Http namespace and the related [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md) and [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md) namespaces downloads large amounts of data (50 megabytes or more), then the app should stream those downloads and not use the default buffering. If the default buffering is used the client memory usage gets very large, potentially resulting in reduced performance.

For sample code in C#/VB/C++ and XAML that shows how to use [HttpClient](httpclient.md) to connect to an HTTP server, see [HttpClient](/windows/uwp/networking/httpclient).

For sample code in JavaScript and HTML that shows how to use [HttpClient](httpclient.md) to connect to an HTTP server, see [Connecting to an HTTP server using Windows.Web.Http](/previous-versions/windows/apps/dn469430(v=win.10)).

## -examples

The following sample code shows how to GET content from an HTTP server as a string.

```csharp
using System;
using Windows.Foundation;
using Windows.Web.Http;

// Note: the URI constructor will throw an exception
// if the string passed is not a valid URI
var uri = new Uri("http://example.com/datalist.aspx");
var httpClient = new HttpClient();

// Always catch network exceptions for async methods
try 
{
    var result = await httpClient.GetStringAsync(uri);
}
catch (Exception ex)
{
    // Details in ex.Message and ex.HResult.       
}

// Once your app is done using the HttpClient object call dispose to 
// free up system resources (the underlying socket and memory used for the object)
httpclient.Dispose();
```

```cppwinrt
#include "winrt/Windows.Foundation.h"
#include "winrt/Windows.Web.Http.h"
using namespace winrt;

Windows::Foundation::IAsyncAction HttpClientExample()
{
    Windows::Foundation::Uri uri{ L"http://www.bing.com" };
    Windows::Web::Http::HttpClient httpClient{};

    // Always catch network exceptions for async methods.
    try
    {
        auto response{ co_await httpClient.GetStringAsync(uri) };
    }
    catch (winrt::hresult_error const& ex)
    {
        // Details in ex.message() and ex.to_abi().
    }

    // The destructor of HttpClient frees system resources
    // (the underlying socket, and memory used for the object).
}
```

```cppcx
using namespace Windows::Foundation;
using namespace Windows::Web::Http;

// Note: the URI constructor will throw an exception
// if the string passed is not a valid URI
uri = ref new Uri("http://example.com/datalist.aspx");
httpClient = ref new HttpClient();

// Always catch network exceptions for async methods
try 
{
    httpClient->GetStringAsync(uri);
}
catch (Exception ^ ex) 
{
    // Details in ex.Message and ex.HResult.       
}

// In C++/CX, the system resources used by httpClient object are released 
// when the object falls out of scope or by the destructor (delete operator).
```

## -see-also

[HttpClient](/windows/uwp/networking/httpclient), [Connecting to an HTTP server using Windows.Web.Http](/previous-versions/windows/apps/dn469430(v=win.10)), [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)), [System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true), [Windows.Foundation.Uri](../windows.foundation/uri.md), Windows.Web.Http, [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md), [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md), [HttpClient Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%23%5D-Windows%208%20app%20samples/C%23/Windows%208%20app%20samples/HttpClient%20sample%20(Windows%208)), [HttpClient sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HttpClient), [Background transfer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTransfer), [Background transfer sample (Windows 8.x)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Background%20Transfer%20sample), [JSON sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Json)
