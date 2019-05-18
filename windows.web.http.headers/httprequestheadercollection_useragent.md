---
-api-id: P:Windows.Web.Http.Headers.HttpRequestHeaderCollection.UserAgent
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpProductInfoHeaderValueCollection UserAgent { get; }
-->

# Windows.Web.Http.Headers.HttpRequestHeaderCollection.UserAgent

## -description
Gets the [HttpProductInfoHeaderValueCollection](httpproductinfoheadervaluecollection.md) of [HttpProductInfoHeaderValue](httpproductinfoheadervalue.md) objects that represent the value of a **User-Agent** HTTP header on an HTTP request.

## -property-value
The collection of [HttpProductInfoHeaderValue](httpproductinfoheadervalue.md) objects that represent the value of a **User-Agent** HTTP header on an HTTP request. An empty collection means that the header is absent.

## -remarks


The following sample code shows a method to set the **User-Agent** header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the UserAgent property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) object.

```csharp
    void DemoUserAgent(HttpRequestMessage m) {
        var h = m.Headers;

        uiLog.Text += "\nUSERAGENT HEADER\n";
        // User-Agent: CERN-LineMode/2.15 libwww/2.17b3
        // User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; Zune 4.0; InfoPath.3; MS-RTC LM 8; .NET4.0C; .NET4.0E)
        var ok = h.UserAgent.TryParseAdd("ie");
        ok = h.UserAgent.TryParseAdd("Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; Zune 4.0; InfoPath.3; MS-RTC LM 8; .NET4.0C; .NET4.0E)");
        ok = h.UserAgent.TryParseAdd("CERN-LineMode/2.15 libwww/2.17b3");
        h.UserAgent.Add (new HttpProductInfoHeaderValue ("productComment"));
        h.UserAgent.Add(new HttpProductInfoHeaderValue("Mozilla", "1.0"));

        // UserAgent is a HttpProductInfoHeaderValueCollection
        // A collection of HttpProductInfoHeaderValue

        // HttpProductInfoHeaderValue has two items:
        // Product (string)
        // Comment (string)
        //
        // According to the RFC, each "item" is EITHER a product OR a comment, and a product is EITHER product or product/version

        foreach (var item in h.UserAgent) {
            // item has: Value (string), Parameter IList<HttpNameValueHeaderValue>

            uiLog.Text += string.Format("Product: {0} Comment: {1} ToString: {2}\n", item.Product, item.Comment, item.ToString());
        }
        uiLog.Text += string.Format("UserAgent: ToString: {0}\n\n", h.UserAgent.ToString());
    }

```



## -examples

## -see-also
[HttpProductInfoHeaderValue](httpproductinfoheadervalue.md), [HttpProductInfoHeaderValueCollection](httpproductinfoheadervaluecollection.md), [HttpRequestMessage](../windows.web.http/httprequestmessage.md), [HttpRequestMessage.Headers](../windows.web.http/httprequestmessage_headers.md)
