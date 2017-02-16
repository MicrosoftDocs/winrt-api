---
-api-id: P:Windows.Web.Http.Headers.HttpResponseHeaderCollection.Allow
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpMethodHeaderValueCollection Allow { get; }
-->

# Windows.Web.Http.Headers.HttpResponseHeaderCollection.Allow

## -description
Gets the [HttpMethodHeaderValueCollection](httpmethodheadervaluecollection.md) of [HttpMethod](../windows.web.http/httpmethod.md) objects that represent the value of an **Allow** HTTP header on an HTTP response.

## -property-value
The collection of [HttpMethod](../windows.web.http/httpmethod.md) objects that represent the value of an **Allow** HTTP header on an HTTP response. An empty collection means that the header is absent.

## -remarks
The [Allow](httpresponseheadercollection_allow.md) property represents the value of an **Allow** HTTP header on an HTTP response. The **Allow** header is a list of HTTP methods (GET, PUT, and POST, for example) allowed by the HTTP server.



The following sample code shows a method to get and set the **Allow** header on an [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) object using the [Allow](httpresponseheadercollection_allow.md) property on the [HttpResponseHeaderCollection](httpresponseheadercollection.md) object.

```csharp
    public void DemonstrateHeaderResponseAllow() {
        var response = new HttpResponseMessage();

        // Set the header with a string
        response.Headers.Allow.TryParseAdd ("GET");

        // Set the header with a strong type
        response.Headers.Allow.Add(HttpMethod.Patch);

        // Get the strong type out
        foreach (var value in response.Headers.Allow) {
            System.Diagnostics.Debug.WriteLine("Allow value: {0}", value.Method);
        }

        // The ToString() is useful for diagnostics, too.
        System.Diagnostics.Debug.WriteLine("The Allow ToString() results: {0}", response.Headers.Allow.ToString());
    }

```



## -examples

## -see-also
[HttpMethod](../windows.web.http/httpmethod.md), [HttpMethodHeaderValueCollection](httpmethodheadervaluecollection.md), [HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [HttpResponseMessage.Headers](../windows.web.http/httpresponsemessage_headers.md)