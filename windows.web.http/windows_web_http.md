---
-api-id: N:Windows.Web.Http
-api-type: winrt namespace
---

# Windows.Web.Http

## -description

Provides a modern HTTP client API for UWP app.

## -remarks

The [Windows.Web.Http](windows_web_http.md) namespace and the related [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md) and [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md) namespaces provide a programming interface for UWP app that target HTTP and REST services. This features of this new HTTP API are designed to be in compliance with HTTP as defined in [RFC 2616](http://go.microsoft.com/fwlink/p/?LinkID=241642) by the IETF. The new HTTP API provides consistent support in JavaScript, C#, VB.NET, and C++ for developers.

This new API replaces the use of three different APIs with differing features that previously were needed for each language projection in Windows 8.

+ [WinJS.xhr](http://msdn.microsoft.com/library/62fc3e32-3d52-4654-8807-8c0563150f01) for JavaScript
+ [HttpClient](http://go.microsoft.com/fwlink/p/?linkid=241637) in the [System.Net.Http](http://go.microsoft.com/fwlink/p/?linkid=227894) namespace for C# and VB.
+ [IXMLHTTPRequest2](https://msdn.microsoft.com/en-us/library/windows/desktop/hh831151(v=vs.85).aspx) for C++

Classes in the [Windows.Web.Http](windows_web_http.md) and related namespaces are targeted at all levels of HTTP and REST development:

+ Basic HTTP developers
+ Site-specific HTTP library developers
+ Advanced HTTP developers

For basic HTTP developers, the new API has a simple interface to handle the most common tasks and sensible defaults for authentication that should work in most environments. For library developers, the consistent object model and multiple language support means you can write a library once for developers in all languages. For advanced HTTP developers, the new API includes a rich set of capabilities.

The [Windows.Web.Http](windows_web_http.md) namespace and the related namespaces provide these components:

+ [HttpClient](httpclient.md) - the main class that sends and receives requests over HTTP.
+ [HttpRequestMessage](httprequestmessage.md) - HTTP request messages defined in [RFC 2616](http://go.microsoft.com/fwlink/p/?LinkID=241642).
+ [HttpResponseMessage](httpresponsemessage.md) - HTTP response messages defined in [RFC 2616](http://go.microsoft.com/fwlink/p/?LinkID=241642).

The contents of an HTTP message corresponds to the entity body defined in [RFC 2616](http://go.microsoft.com/fwlink/p/?LinkID=241642). Several classes and an interface in the [Windows.Web.Http](windows_web_http.md) namespace can be used for HTTP content, including:

+ [IHttpContent](ihttpcontent.md) - A base interface for developers to create their own content objects. It represents an HTTP entity body and content headers. This interface has methods that get and set the actual content data. It also provides properties that get and set content related headers.
+ [HttpBufferContent](httpbuffercontent.md) - HTTP content that uses a buffer.
+ [HttpFormUrlEncodedContent](httpformurlencodedcontent.md) - HTTP content that uses name/value tuples encoded with the **application/x-www-form-urlencoded** MIME type.
+ [HttpMultipartContent](httpmultipartcontent.md) - HTTP content that uses **multipart/*** MIME type.
+ [HttpMultipartFormDataContent](httpmultipartformdatacontent.md) - HTTP content that uses the encoded **multipart/form-data** MIME type.
+ [HttpStreamContent](httpstreamcontent.md) - HTTP content that uses a stream. This content type is used by the HTTP GET method to receive data and the HTTP POST method to upload data.
+ [HttpStringContent](httpstringcontent.md) - HTTP content that uses a string.

Classes in the [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md) namespace represent HTTP headers defined in [RFC 2616](http://go.microsoft.com/fwlink/p/?LinkID=241642). HTTP headers are associated with [HttpRequestMessage](httprequestmessage.md) and [HttpResponseMessage](httpresponsemessage.md) as properties that are retrieved or set.

Classes in the [Windows.Web.Http](windows_web_http.md) namespace can use filters based on the classes in the [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md) namespace. Filters provide handlers to help with common HTTP service issues. Filters can be chained together in a sequence to address more complex HTTP service issues. Several ready-to-use filters are included with Windows 8.1 to help library developers fix common HTTP service issues. These filters include handlers for monitored network connections and retry. Library developers can write their own filters for site-specific issues (for example, a site might use the 503 (Server Unavailable) response to indicate the request should be retried).

If an app that uses the [Windows.Web.Http](windows_web_http.md) namespace and the related [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md) and [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md) namespaces downloads large amounts of data (50 megabytes or more), then the app should stream those downloads and not use the default buffering. If the default buffering is used the client memory usage gets very large, potentially resulting in reduced performance.

For sample code in C#/VB/C++ and XAML that shows how to use [HttpClient](httpclient.md) to connect to an HTTP server, see [HttpClient](http://msdn.microsoft.com/library/ec9820d3-3a46-474f-8a01-ae1c27442750).

For sample code in JavaScript and HTML that shows how to use [HttpClient](httpclient.md) to connect to an HTTP server, see [Connecting to an HTTP server using Windows.Web.Http](http://msdn.microsoft.com/library/dfc2a92c-e84a-4def-9203-e348e64befe5).

## -examples

The following sample code shows how to GET content from an HTTP server as a string.

```javascript

// Note: the URI constructor will throw an exception
// if the string passed is not a valid URI
var uri = new Uri("http://example.com/datalist.aspx");
var httpClient = new HttpClient();

// Always catch network exceptions for async methods
httpClient.GetStringAsync(uri).done(function () {
        // get completed
    }, onError);


function onError(reason) {
    // Details in reason.Message and ex.HResult.       
}

// Once your app is done using the HttpClient object call close to 
// free up system resources (the underlying socket and memory used for the object)
// httpClient.close();

```

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

```cpp

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

// In C++ and CX, the system resources used by httpClient object are released 
// when the object falls out of scope or by the destructor (delete operator)

```

## -see-also

[HttpClient](http://msdn.microsoft.com/library/ec9820d3-3a46-474f-8a01-ae1c27442750), [Connecting to an HTTP server using Windows.Web.Http](http://msdn.microsoft.com/library/dfc2a92c-e84a-4def-9203-e348e64befe5), [Handling exceptions in network apps](http://msdn.microsoft.com/library/76fafcc9-c674-4cf8-baa0-2400638fae35), [System.Uri](https://msdn.microsoft.com/library/system.uri.aspx), [Windows.Foundation.Uri](../windows.foundation/uri.md), [Windows.Web.Http](windows_web_http.md), [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md), [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md), [HttpClient Sample]( http://go.microsoft.com/fwlink/p/?linkid=242550), [HttpClient sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620551), [Background transfer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTransfer), [JSON sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Json)