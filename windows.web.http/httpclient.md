---
-api-id: T:Windows.Web.Http.HttpClient
-api-type: winrt class
---

<!-- Class syntax.
public class HttpClient : Windows.Foundation.IClosable, Windows.Foundation.IStringable, Windows.Web.Http.IHttpClient
-->

# Windows.Web.Http.HttpClient

## -description

Sends HTTP requests and receives HTTP responses from a resource identified by a URI. For programming guidance for the **HttpClient** class, and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -remarks

The HttpClient class instance acts as a session to send HTTP requests and receive responses. An HttpClient instance is a collection of settings that apply to all requests executed by that instance. In addition, every HttpClient instance uses its own connection pool, isolating its requests from requests executed by other HttpClient instances.

The HttpClient also acts as a class to use with filters for more specific HTTP clients. An example would be an HttpClientFilter that provides additional methods specific to a social network service (a GetFriends method, for instance).

If an app using HttpClient and related classes in the [Windows.Web.Http](windows_web_http.md) namespace downloads large amounts of data (50 megabytes or more), then the app should stream those downloads and not use the default buffering. If the default buffering is used the client memory usage will get very large, potentially resulting in reduced performance.

For sample code in C# and C++/WinRT that shows how to use HttpClient to connect to an HTTP server, see [HttpClient](/windows/uwp/networking/httpclient).

For sample code in JavaScript and HTML that shows how to use HttpClient to connect to an HTTP server, see [Connecting to an HTTP server using Windows.Web.Http](/previous-versions/windows/apps/dn469430(v=win.10)).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | TryDeleteAsync |
| 1903 | 18362 | TryGetAsync(Uri) |
| 1903 | 18362 | TryGetAsync(Uri,HttpCompletionOption) |
| 1903 | 18362 | TryGetBufferAsync |
| 1903 | 18362 | TryGetInputStreamAsync |
| 1903 | 18362 | TryGetStringAsync |
| 1903 | 18362 | TryPostAsync |
| 1903 | 18362 | TryPutAsync |
| 1903 | 18362 | TrySendRequestAsync(HttpRequestMessage) |
| 1903 | 18362 | TrySendRequestAsync(HttpRequestMessage,HttpCompletionOption) |

## -examples

The following sample code shows how to GET content from a Web server as a string.

```csharp
using System;

var uri = new System.Uri("http://www.bing.com");
using (var httpClient = new Windows.Web.Http.HttpClient())
{
    // Always catch network exceptions for async methods
    try
    {
        string result = await httpClient.GetStringAsync(uri);
    }
    catch (Exception ex)
    {
        // Details in ex.Message and ex.HResult.
    }
}
// Having exited the scope of the using statement, httpClient.Dispose() will be called
// automatically, thus freeing up system resources (the underlying socket, and memory
// used for the object).
```

```cppwinrt
#include "winrt/Windows.Foundation.h"
#include "winrt/Windows.Web.Http.h"
using namespace winrt;

Windows::Foundation::IAsyncAction HttpClientExample()
{
    Windows::Foundation::Uri uri{ L"http://www.bing.com" };
    Windows::Web::Http::HttpClient httpClient{};

    // Always catch network exceptions for async methods
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

// In C++/CX, the system resources used by httpClient object are released 
// when the object falls out of scope or by the destructor (delete operator).
```

The HttpClient class is often used by an app to download and then parse text. It is possible that the character encoding specified in the **Content-Type** header by an HTTP server does not match the character encoding of the HTTP response body (the XML encoding in an XML document, for example). One way to use HttpClient with text is to call the [GetStringAsync](httpclient_getstringasync_149346728.md) method and pass the returned string to the text parser. However, this can result in errors if the **Content-Type** is not a type expressible as a string. A reliable way to use HttpClient with an XML parser is to call the [GetBufferAsync](httpclient_getbufferasync_894906839.md) method and parse the buffer for the "&lt;?xml&gt;" element. Then use the character encoding specified ("&lt;xmlversion="1.0" encoding="UTF-8"?&gt;", for example) to parse the HTTP response body. For other text formats, similar methods can be used where the app scans the initial part of the HTTP response body to determine the character encoding used.

## -see-also

[HttpClient](/windows/uwp/networking/httpclient), [Connecting to an HTTP server using Windows.Web.Http](/previous-versions/windows/apps/dn469430(v=win.10)), [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)), [IClosable](../windows.foundation/iclosable.md), [IStringable](../windows.foundation/istringable.md), [System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true), [Windows.Foundation.Uri](../windows.foundation/uri.md), [Windows.Web.Http](windows_web_http.md), [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md), [Windows.Web.Http.Headers](../windows.web.http.headers/windows_web_http_headers.md), [Background transfer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTransfer), [Background transfer sample (Windows 8.x)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Background%20Transfer%20sample), [HttpClient sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HttpClient), [JSON sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620556)