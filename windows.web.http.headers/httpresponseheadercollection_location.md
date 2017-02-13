---
-api-id: P:Windows.Web.Http.Headers.HttpResponseHeaderCollection.Location
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri Location { get;  set; }
-->

# Windows.Web.Http.Headers.HttpResponseHeaderCollection.Location

## -description
Gets or sets the [Uri](../windows.foundation/uri.md) that represents the value or a **Location** HTTP header on an HTTP response.

## -property-value
The object that represents the value of a **Location** HTTP header on an HTTP response. A **null** value means that the header is absent.

## -remarks


The following sample code shows a method to set the **Location** header on an [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) object using the [Location](httpresponseheadercollection_location.md) property on the [HttpResponseHeaderCollection](httpresponseheadercollection.md) object.

```csharp
    public void DemonstrateHeaderResponseLocation() {
        var response = new HttpResponseMessage();

        // Set the header with a strong type.
        response.Headers.Location = new Uri("http://example.com/");

        // Get the strong type out
        System.Diagnostics.Debug.WriteLine("Location absolute uri: {0}", response.Headers.Location.AbsoluteUri);

        // The ToString() is useful for diagnostics, too.
        System.Diagnostics.Debug.WriteLine("The Location ToString() results: {0}", response.Headers.Location.ToString());
    }

```



## -examples

## -see-also
[HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [HttpResponseMessage.Headers](../windows.web.http/httpresponsemessage_headers.md), [Uri](../windows.foundation/uri.md)