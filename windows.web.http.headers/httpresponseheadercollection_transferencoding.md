---
-api-id: P:Windows.Web.Http.Headers.HttpResponseHeaderCollection.TransferEncoding
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpTransferCodingHeaderValueCollection TransferEncoding { get; }
-->

# Windows.Web.Http.Headers.HttpResponseHeaderCollection.TransferEncoding

## -description
Gets the [HttpTransferCodingHeaderValueCollection](httptransfercodingheadervaluecollection.md) of [HttpTransferCodingHeaderValue](httptransfercodingheadervalue.md) objects that represent the value of a **Transfer-Encoding** HTTP header on an HTTP response.

## -property-value
The collection of [HttpTransferCodingHeaderValue](httptransfercodingheadervalue.md) objects that represent the value of a **Transfer-Encoding** HTTP header on an HTTP response. An empty collection means that the header is absent.

## -remarks


The following sample code shows a method to get and set the **Transfer-Encoding** header on an [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) object using the TransferEncoding property on the [HttpResponseHeaderCollection](httpresponseheadercollection.md) object.

```csharp
    // HttpTransferCodingHeaderValueCollection
    // HttpTransferCodingHeaderValue hasValue (string) and Parameters (IList<HttpNameValueHeaderValue>)
    // IList<HttpNameValueHeaderValue>
    // HttpNameValueHeaderValue
    //
    // This is the same type as on the Request TransferEncoding  value
    void DemoTransferEncoding(HttpResponseMessage response) {
        var h = response.Headers;
        h.TransferEncoding.TryParseAdd("Basic");
        h.TransferEncoding.Add(new HttpTransferCodingHeaderValue("gzip"));

        var header = h.TransferEncoding;
        uiLog.Text += "\nTRANSFER ENCODING HEADER\n";
        foreach (var item in header) {
            // Parameters is an IList<HttpNameValueHeaderValue> of Name/Value strings
            var parameterString = "";
            foreach (var parameter in item.Parameters) {
                parameterString += string.Format("[{0}={1}] ", parameter.Name, parameter.Value);
            }
            if (parameterString == "") {
                parameterString = "(no parameters)";
            }
            uiLog.Text += string.Format("Value: {0} Parameters: {1} ToString(): {2}\n", item.Value, parameterString, item.ToString());
        }
        uiLog.Text += String.Format("TransferEncoding: {0}\n", header.ToString());
    }

```



## -examples

## -see-also
[HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [HttpResponseMessage.Headers](../windows.web.http/httpresponsemessage_headers.md), [HttpTransferCodingHeaderValue](httptransfercodingheadervalue.md), [HttpTransferCodingHeaderValueCollection](httptransfercodingheadervaluecollection.md)
