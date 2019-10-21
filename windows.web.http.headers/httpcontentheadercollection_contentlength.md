---
-api-id: P:Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentLength
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<ulong> ContentLength { get;  set; }
-->

# Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentLength

## -description
Gets or sets the value of the HTTP **Content-Length** header on the HTTP content.

## -property-value
The value of the HTTP **Content-Length** header value on the HTTP content. A null value means that the header is absent.

## -remarks


The following sample code shows a method to get or set the **Content-Length** header on HTTP content using the ContentLength property on the [HttpContentHeaderCollection](httpcontentheadercollection.md) object.

```csharp
    // Content-Length header
    // nullable ulong
    void DemoContentLength(IHttpContent content) {
        var h = content.Headers;

        h.ContentLength = 313;

        var header = h.ContentLength;
        uiLog.Text += "\nCONTENT LENGTH HEADER\n";

        uiLog.Text += string.Format("ContentLength: ToString: {0}\n\n", header.ToString());
    }

```



## -examples

## -see-also
