---
-api-id: M:Windows.Web.Http.HttpClient.#ctor(Windows.Web.Http.Filters.IHttpFilter)
-api-type: winrt method
---

<!-- Method syntax
public HttpClient(Windows.Web.Http.Filters.IHttpFilter filter)
-->

# Windows.Web.Http.HttpClient.HttpClient

## -description
Initializes a new instance of the [HttpClient](httpclient.md) class with a specific filter for handling HTTP response messages.

## -parameters
### -param filter
The HTTP filter to use for handling response messages.

## -remarks
If a **null** reference (**Nothing** in Visual Basic) is specified for the filter parameter, the default transport handler for receiving responses with no filter is used.

## -examples
The sample code shows creating an [HttpClient](httpclient.md) to use a custom filter.

```csharp

internal static void CreateHttpClient(ref HttpClient httpClient)
{
    if (httpClient != null) {
        httpClient.Dispose();
    }

    // HttpClient can be extended by plugging multiple filters together,
    // providing HttpClient with the configured filter pipeline.
    var baseFilter = new HttpBaseProtocolFilter();

    var myFilter = new MyCustomFilter(baseFilter);
    httpClient = new HttpClient(myFilter);
}


```



## -see-also
[HttpClient constructor](httpclient_httpclient_1221375020.md), [IHttpFilter](../windows.web.http.filters/ihttpfilter.md), [Windows.Web.Http.Filters](../windows.web.http.filters/windows_web_http_filters.md)