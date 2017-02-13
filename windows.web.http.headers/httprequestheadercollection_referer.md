---
-api-id: P:Windows.Web.Http.Headers.HttpRequestHeaderCollection.Referer
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri Referer { get;  set; }
-->

# Windows.Web.Http.Headers.HttpRequestHeaderCollection.Referer

## -description
Gets or sets the [Uri](../windows.foundation/uri.md) that represents the value of a **Referer** HTTP header on an HTTP request.

## -property-value
The object that represents the value of a **Referer** HTTP header on an HTTP request. A null value means that the header is absent.

## -remarks


The following sample code shows a method to set the **Referer** header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the [Referer](httprequestheadercollection_referer.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) object.

```csharp
    public void DemonstrateHeaderRequestReferer() {
        var request = new HttpRequestMessage();

        // This is not typically set with a string.

        // Set the header with a strong type.
        // Uri is either in the Windows.Foundation namespace (JavaScript and C++)
        // or in the System.Net namespace (C#).
        var value = new Uri("http://example.com/");
        request.Headers.Referer = value;

        // Get the strong type out
        System.Diagnostics.Debug.WriteLine("Referer absolute uri: {0}", request.Headers.Referer.AbsoluteUri);

        // The ToString() is useful for diagnostics, too.
        System.Diagnostics.Debug.WriteLine("The Host ToString() results: {0}", request.Headers.Referer.ToString());
    }

```



## -examples

## -see-also
[HttpRequestMessage](../windows.web.http/httprequestmessage.md), [HttpRequestMessage.Headers](../windows.web.http/httprequestmessage_headers.md), [Uri](../windows.foundation/uri.md)