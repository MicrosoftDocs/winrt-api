---
-api-id: P:Windows.Web.Http.Headers.HttpResponseHeaderCollection.Connection
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpConnectionOptionHeaderValueCollection Connection { get; }
-->

# Windows.Web.Http.Headers.HttpResponseHeaderCollection.Connection

## -description
Gets the [HttpConnectionOptionHeaderValueCollection](httpconnectionoptionheadervaluecollection.md) of [HttpConnectionOptionHeaderValue](httpconnectionoptionheadervalue.md) objects that represent the value of a **Connection** HTTP header on an HTTP response.

## -property-value
The collection of [HttpConnectionOptionHeaderValue](httpconnectionoptionheadervalue.md) objects that represent the value of a **Connection** HTTP header. An empty collection means that the header is absent.

## -remarks


The following sample code shows a method to get and set the **Connection** header on an [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) object using the [Connection](httpresponseheadercollection_connection.md) property on the [HttpResponseHeaderCollection](httpresponseheadercollection.md) object.

```csharp
// Connection:keep-alive
// HttpConnectionOptionHeaderValueCollection, a collection of
// HttpConnectionOptionHeaderValue which just has a Token (string)
// 
// This is the same type as on the request
    void DemoConnection(HttpResponseMessage response) {
        var h = response.Headers;
        h.Connection.TryParseAdd("close");
        h.Connection.TryParseAdd("some,values");
        h.Connection.Add(new HttpConnectionOptionHeaderValue("last"));

        var header = h.Connection;
        uiLog.Text += "\nCONNECTION HEADER\n";
        foreach (var item in header) {
            uiLog.Text += String.Format("Token: {0}  ToString: {1}\n", item.Token, item.ToString());
        }
        uiLog.Text += String.Format("Connection: {0}\n", header.ToString());
    }

```



## -examples

## -see-also
[HttpConnectionOptionHeaderValue](httpconnectionoptionheadervalue.md), [HttpConnectionOptionHeaderValueCollection](httpconnectionoptionheadervaluecollection.md), [HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [HttpResponseMessage.Headers](../windows.web.http/httpresponsemessage_headers.md)