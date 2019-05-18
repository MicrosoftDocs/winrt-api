---
-api-id: P:Windows.Web.Http.Headers.HttpRequestHeaderCollection.MaxForwards
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<uint> MaxForwards { get;  set; }
-->

# Windows.Web.Http.Headers.HttpRequestHeaderCollection.MaxForwards

## -description
Gets or sets an integer value that represents the value of a **Max-Forwards** HTTP header on an HTTP request.

## -property-value
An integer value that represents the value of a **Max-Forwards** HTTP header on an HTTP request. A null value means that the header is absent.

## -remarks


The following sample code shows a method to set the **Max-Forwards** header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the MaxForwards property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) object.

```csharp
    public void DemonstrateHeaderRequestMaxForwards() {
        var request = new HttpRequestMessage();

        // Set the header with an integer.
        request.Headers.MaxForwards= 2;

        // Get the strong type out
        System.Diagnostics.Debug.WriteLine("MaxForwards value: {0}", request.Headers.MaxForwards);
    }

```



## -examples

## -see-also
[HttpRequestMessage](../windows.web.http/httprequestmessage.md), [HttpRequestMessage.Headers](../windows.web.http/httprequestmessage_headers.md)
