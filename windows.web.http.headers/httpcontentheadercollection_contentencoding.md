---
-api-id: P:Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentEncoding
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpContentCodingHeaderValueCollection ContentEncoding { get; }
-->

# Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentEncoding

## -description
Gets the [HttpContentCodingHeaderValueCollection](httpcontentcodingheadervaluecollection.md) of [HttpContentCodingHeaderValue](httpcontentcodingheadervalue.md) objects that represent the value of an HTTP **Content-Encoding** header on the HTTP content.

## -property-value
The collection of [HttpContentCodingHeaderValue](httpcontentcodingheadervalue.md) objects that represent the value of an HTTP **Content-Encoding** header on the HTTP content. An empty collection means that the header is absent.

## -remarks


The following sample code shows a method to get or set the **Content-Encoding** header value on HTTP content using the [ContentEncoding](httpcontentheadercollection_contentencoding.md) property on the [HttpContentHeaderCollection](httpcontentheadercollection.md) object.

```csharp
    // Content-Encoding header
    // HttpContentCodingHeaderValueCollection
    // HttpContentCodingHeaderValue [has ContentCoding, a string]
    void DemoContentEncoding(IHttpContent content) {
        var h = content.Headers;

        h.ContentEncoding.TryParseAdd("gzip");
        h.ContentEncoding.TryParseAdd("cab, compress");
        h.ContentEncoding.Add(new HttpContentCodingHeaderValue("myencoding"));

        var header = h.ContentEncoding;
        uiLog.Text += "\nCONTENT ENCODING HEADER\n";
        foreach (var item in header) {
            uiLog.Text += string.Format("ContentCoding: {0}  ToString: {1}\n", item.ContentCoding, item.ToString());
        }
        uiLog.Text += string.Format("ContentEncoding: ToString: {0}\n\n", header.ToString());
    }


```



## -examples

## -see-also
[HttpContentCodingHeaderValue](httpcontentcodingheadervalue.md), [HttpContentCodingHeaderValueCollection](httpcontentcodingheadervaluecollection.md)