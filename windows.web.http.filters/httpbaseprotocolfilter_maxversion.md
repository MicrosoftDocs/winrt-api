---
-api-id: P:Windows.Web.Http.Filters.HttpBaseProtocolFilter.MaxVersion
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.HttpVersion MaxVersion { get;  set; }
-->

# Windows.Web.Http.Filters.HttpBaseProtocolFilter.MaxVersion

## -description
Gets or sets the version of the HTTP protocol used.

## -property-value
An enumeration value that specifies the version of HTTP used.

## -remarks
By default, when a new request is started using [Windows.Web.Http.HttpClient](../windows.web.http/httpclient.md), it uses HTTP 2.0. To create an instance of HttpClient that uses HTTP 1.1 instead, set this property to **HttpVersion.Http11** on a filter, and then create a new instance of HttpClient, passing the filter as an argument to the HttpClient constructor.

## -examples
The following code shows how to create an HttpClient that uses HTTP 1.1 rather than the default HTTP 2.0.

```csharp
HttpBaseProtocolFilter filter = new HttpBaseProtocolFilter(); 

filter.MaxVersion = HttpVersion.Http11;

HttpClient client = new HttpClient(filter);

```



## -see-also
