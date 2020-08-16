---
-api-id: P:Windows.Web.Http.Headers.HttpRequestHeaderCollection.TransferEncoding
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpTransferCodingHeaderValueCollection TransferEncoding { get; }
-->

# Windows.Web.Http.Headers.HttpRequestHeaderCollection.TransferEncoding

## -description
Gets the [HttpTransferCodingHeaderValueCollection](httptransfercodingheadervaluecollection.md) of [HttpTransferCodingHeaderValue](httptransfercodingheadervalue.md) objects that represent the value of a **Transfer-Encoding** HTTP header on an HTTP request.

## -property-value
The collection of [HttpTransferCodingHeaderValue](httptransfercodingheadervalue.md) objects that represent the value of a **Transfer-Encoding** HTTP header on an HTTP request. An empty collection means that the header is absent.

## -remarks
The only transfer encoding value supported by [HttpClient](../windows.web.http/httpclient.md) is chunked, even though the [HttpTransferCodingHeaderValueCollection](httptransfercodingheadervaluecollection.md) of [HttpTransferCodingHeaderValue](httptransfercodingheadervalue.md) objects supports setting other values.

There is no need to set the transfer encoding value manually to chunked if the [HttpRequestMessage](../windows.web.http/httprequestmessage.md) is sent as an  with no content-length specified or available using the  method on [HttpClient](../windows.web.http/httpclient.md) or one of the  methods on the HTTP content classes.



The following sample code shows a method to set the **Transfer-Encoding** header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the TransferEncoding property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) object.

```csharp
    void DemoTransferEncoding(HttpRequestMessage m) {
        var h = m.Headers;

        uiLog.Text += "\nTRANSFERENCODING HEADER\n";
        // Transfer-Encoding: chunked
        var okTryParseAdd = h.TransferEncoding.TryParseAdd("chunked");
        okTryParseAdd = h.TransferEncoding.TryParseAdd("mini; a=b; c=d; e=f");
        h.TransferEncoding.Add(new HttpTransferCodingHeaderValue("cab"));
        h.TransferEncoding.TryParseAdd("newtype, othernewtype");

        // TransferEncoding is a HttpTransferCodingHeaderValueCollection
        // A collection of HttpTransferCodingHeaderValue

        // HttpTransferCodingHeaderValue has three items:
        // Value (string); for example, "compress"
        // Parameter (IList<HttpNameValueHeaderValue>)
        //

        foreach (var item in h.TransferEncoding) {
            // item has: Value (string), Parameter IList<HttpNameValueHeaderValue>
            var parameterString = "";
            foreach (var parameter in item.Parameters) {
                parameterString += string.Format("[{0}={1}] ", parameter.Name, parameter.Value);
            }
            if (parameterString == "") {
                parameterString = "(no parameters)";
            } 
            uiLog.Text += string.Format("Value: {0} Parameters: {1} ToString: {2}\n", item.Value, parameterString, item.ToString());
        }
        uiLog.Text += string.Format("TransferEncoding: ToString: {0}\n\n", h.TransferEncoding.ToString());
    }

```



## -examples

## -see-also
[HttpRequestMessage](../windows.web.http/httprequestmessage.md), [HttpRequestMessage.Headers](../windows.web.http/httprequestmessage_headers.md), [HttpTransferCodingHeaderValue](httptransfercodingheadervalue.md), [HttpTransferCodingHeaderValueCollection](httptransfercodingheadervaluecollection.md)
