---
-api-id: T:Windows.Web.Http.HttpClient
-api-type: winrt class
---

<!-- Class syntax.
public class HttpClient : Windows.Foundation.IClosable, Windows.Foundation.IStringable, Windows.Web.Http.IHttpClient
-->

# Windows.Web.Http.HttpClient

## -description
Sends HTTP requests and receives HTTP responses from a resource identified by a URI.

## -remarks
The [HttpClient](httpclient.md) class instance acts as a session to send HTTP requests and receive responses. An [HttpClient](httpclient.md) instance is a collection of settings that apply to all requests executed by that instance. In addition, every [HttpClient](httpclient.md) instance uses its own connection pool, isolating its requests from requests executed by other [HttpClient](httpclient.md) instances.

The [HttpClient](httpclient.md) also acts as a class to use with filters for more specific HTTP clients. An example would be an HttpClientFilter that provides additional methods specific to a social network service (a GetFriends method, for instance).

If an app using [HttpClient](httpclient.md) and related classes in the [Windows.Web.Http](windows_web_http.md) namespace downloads large amounts of data (50 megabytes or more), then the app should stream those downloads and not use the default buffering. If the default buffering is used the client memory usage will get very large, potentially resulting in reduced performance.

For sample code in C#/VB/C++ and XAML that shows how to use [HttpClient](httpclient.md) to connect to an HTTP server, see [HttpClient](http://msdn.microsoft.com/library/ec9820d3-3a46-474f-8a01-ae1c27442750).

For sample code in JavaScript and HTML that shows how to use [HttpClient](httpclient.md) to connect to an HTTP server, see [Connecting to an HTTP server using Windows.Web.Http](http://msdn.microsoft.com/library/dfc2a92c-e84a-4def-9203-e348e64befe5).

## -examples
The following sample code shows how to GET content from a Web server as a string.

```javascript
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

var uri = new Uri("http://example.com/datalist.aspx");
var httpClient = new HttpClient();

// Always catch network exceptions for async methods
try 
{
    var result = await httpClient.GetStringAsync(uri);
}
catch 
{
    // Details in ex.Message and ex.HResult.       
}

// Once your app is done using the HttpClient object call dispose to 
// free up system resources (the underlying socket and memory used for the object)
httpClient.Dispose();


```

```cpp

using namespace Windows::Foundation;
using namespace Windows::Web::Http;

uri = ref new Uri("http://example.com/datalist.aspx");
httpClient = ref new HttpClient();

// Always catch network exceptions for async methods
try 
{
    httpClient->GetStringAsync(uri);
}
catch 
{
    // Details in ex.Message and ex.HResult.       
}

// In C++ and CX, the system resources used by httpClient object are released 
// when the object falls out of scope or by the destructor (delete operator)

```

The [HttpClient](httpclient.md) class is often used by an app to download and then parse text. It is possible that the character encoding specified in the **Content-Type** header by an HTTP server does not match the character encoding of the HTTP response body (the XML encoding in an XML document, for example). One way to use [HttpClient](httpclient.md) with text is to call the [GetStringAsync](httpclient_getstringasync.md) method and pass the returned string to the text parser. However, this can result in errors if the **Content-Type** is not a type expressible as a string. A reliable way to use [HttpClient](httpclient.md) with an XML parser is to call the [GetBufferAsync](httpclient_getbufferasync.md) method and parse the buffer for the "&lt;?xml&gt;" element. Then use the character encoding specified ("&lt;xmlversion="1.0" encoding="UTF-8"?&gt;", for example) to parse the HTTP response body. For other text formats, similar methods can be used where the app scans the initial part of the HTTP response body to determine the character encoding used.

## -see-also
[HttpClient](http://msdn.microsoft.com/library/ec9820d3-3a46-474f-8a01-ae1c27442750), [Connecting to an HTTP server using Windows.Web.Http](http://msdn.microsoft.com/library/dfc2a92c-e84a-4def-9203-e348e64befe5), [Handling exceptions in network apps](http://msdn.microsoft.com/library/76fafcc9-c674-4cf8-baa0-2400638fae35), [IClosable](../windows.foundation/iclosable.md), [IStringable](../windows.foundation/istringable.md), [System.Uri](https://msdn.microsoft.com/library/system.uri.aspx), [Windows.Foundation.Uri](../windows.foundation/uri.md), [Windows.Web.Http](windows_web_http.md), [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md), [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md), [HttpClient Sample]( http://go.microsoft.com/fwlink/p/?linkid=242550), [Background transfer sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620510), [HttpClient sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620551), [JSON sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620556)
