---
-api-id: P:Windows.Web.Http.Headers.HttpRequestHeaderCollection.From
-api-type: winrt property
---

<!-- Property syntax
public string From { get;  set; }
-->

# Windows.Web.Http.Headers.HttpRequestHeaderCollection.From

## -description
Gets or sets the [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) that represents the value of a **From** HTTP header on an HTTP request.

## -property-value
The value of a **From** HTTP header on an HTTP request. An empty string means that the header is absent.

## -remarks


The following sample code shows a method to set the **From** header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the From property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) object.

```csharp
    public void DemonstrateHeaderRequestFrom() {
        var request = new HttpRequestMessage();

        // Set the header with a string.
        request.Headers.From = "person@example.com";

        // Get the strong type out
        System.Diagnostics.Debug.WriteLine("From value: {0}", request.Headers.From);
    }

```



## -examples

## -see-also
[HttpRequestMessage](../windows.web.http/httprequestmessage.md), [HttpRequestMessage.Headers](../windows.web.http/httprequestmessage_headers.md)
