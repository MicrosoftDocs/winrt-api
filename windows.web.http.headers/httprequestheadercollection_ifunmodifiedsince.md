---
-api-id: P:Windows.Web.Http.Headers.HttpRequestHeaderCollection.IfUnmodifiedSince
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.DateTime> IfUnmodifiedSince { get;  set; }
-->

# Windows.Web.Http.Headers.HttpRequestHeaderCollection.IfUnmodifiedSince

## -description
Gets or sets the [DateTime](../windows.foundation/datetime.md) object that represents the value of an **If-Unmodified-Since** HTTP header on an HTTP request.

## -property-value
The [DateTime](../windows.foundation/datetime.md) object that represents the value of an **If-Unmodified-Since** HTTP header on an HTTP request. A null value means that the header is absent.

## -remarks
The IfUnmodifiedSince property represents the value of an **If-Unmodified-Since** HTTP header on an HTTP request message. The **If-Unmodified-Since** header is the date and time the content was not modified since.

Javascript and .NET languages do not use the [DateTime](../windows.foundation/datetime.md) object directly. In Javascript a [DateTime](../windows.foundation/datetime.md) is projected as a  object, and in .NET it is projected as a [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true). Each language transparently handles the conversion to the granularity and date ranges for the respective language.

In C++, a  value has the same granularity as a  and supports the date ranges required by Javascript and .NET.

For more detailed information, see the [Windows.Foundation.DateTime](../windows.foundation/datetime.md) structure.



The following sample code shows a method to set the **If-Unmodified-Since** header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the IfUnmodifiedSince property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) object.

```csharp
    public void DemonstrateHeaderRequestIfUnmodifiedSince() {
        var request = new HttpRequestMessage();

        // This is not typically set with a string.

        // Set the header with a strong type.
        var value = DateTimeOffset.Now.AddDays(-1); // Since yesterday.
        request.Headers.IfUnmodifiedSince = value;

        // Get the strong type out
        System.Diagnostics.Debug.WriteLine("IfUnmodifiedSince value in ticks: {0}", request.Headers.IfUnmodifiedSince.Value.Ticks);

        // The ToString() is useful for diagnostics, too.
        System.Diagnostics.Debug.WriteLine("The IfUnmodfiedSince ToString() results: {0}", request.Headers.IfUnmodifiedSince.ToString());
    }

```



## -examples

## -see-also
[DateTime](../windows.foundation/datetime.md), [HttpRequestMessage](../windows.web.http/httprequestmessage.md), [HttpRequestMessage.Headers](../windows.web.http/httprequestmessage_headers.md), [IfModifiedSince](httprequestheadercollection_ifmodifiedsince.md)
