---
-api-id: P:Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentRange
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpContentRangeHeaderValue ContentRange { get;  set; }
-->

# Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentRange

## -description
Gets or sets the [HttpContentRangeHeaderValue](httpcontentrangeheadervalue.md) object that represent the value of an HTTP **Content-Range** header on the HTTP content.

## -property-value
The object that represent the value of the HTTP **Content-Range** header on the HTTP content. A null value means that the header is absent.

## -remarks


The following sample code shows a method to get or set the **Content-Range** header value on HTTP content using the [ContentRange](httpcontentheadercollection_contentrange.md) property on the [HttpContentHeaderCollection](httpcontentheadercollection.md) object.

```csharp
    // Content-Range header
    // HttpContentRangeHeaderValue (Unit=string, FirstBytePosition, LastBytePosition, Length) all nullable ulong
    //
    void DemoContentRange(IHttpContent content) {
        var h = content.Headers;
        h.ContentRange = new HttpContentRangeHeaderValue (10, 20, 333);

        var header = h.ContentRange;
        uiLog.Text += "\nCONTENT RANGE HEADER\n";

        uiLog.Text += string.Format("ContentRange: Unit: {0} FirstBytePosition: {1} LastBytePosition: {2} Length: {3} ToString: {4}\n\n", header.Unit, header.FirstBytePosition, header.LastBytePosition, header.Length, header.ToString());
    }

```



## -examples

## -see-also
[HttpContentRangeHeaderValue](httpcontentrangeheadervalue.md)