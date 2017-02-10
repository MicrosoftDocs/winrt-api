---
-api-id: P:Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentLocation
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri ContentLocation { get;  set; }
-->

# Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentLocation

## -description
Gets or sets the value of the HTTP **Content-Location** header on the HTTP content.

## -property-value
The value of the HTTP **Content-Location** header on the HTTP content. A null value means that the header is absent.

## -remarks


The following sample code shows a method to get or set the **Content-Location** header value on HTTP content using the [ContentLocation](httpcontentheadercollection_contentlocation.md) property on the [HttpContentHeaderCollection](httpcontentheadercollection.md) object.

```csharp
    // Content-Location header
    // Uri
    void DemoContentLocation(IHttpContent content) {
        var h = content.Headers;

        h.ContentLocation = new Uri("http://example.com/");

        var header = h.ContentLocation;
        uiLog.Text += "\nCONTENT LOCATION HEADER\n";

        uiLog.Text += string.Format("ContentLocation: ToString: {0}\n\n", header.ToString());
    }

```



## -examples

## -see-also
[Uri](../windows.foundation/uri.md)