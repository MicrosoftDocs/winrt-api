---
-api-id: P:Windows.Web.Http.Headers.HttpRequestHeaderCollection.Date
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.DateTime> Date { get;  set; }
-->

# Windows.Web.Http.Headers.HttpRequestHeaderCollection.Date

## -description
Gets or sets the [DateTime](../windows.foundation/datetime.md) object that represents the value of a **Date** HTTP header on an HTTP request.

## -property-value
The object that represents the value of a **Date** HTTP header on an HTTP request. A null value means that the header is absent.

## -remarks
The Date property represents the **Date** header on an HTTP request message. The **Date** header is the date and time the message was sent.

Javascript and .NET languages do not use the [DateTime](../windows.foundation/datetime.md) object directly. In Javascript a [DateTime](../windows.foundation/datetime.md) is projected as a  object, and in .NET it is projected as a [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true). Each language transparently handles the conversion to the granularity and date ranges for the respective language.

In C++, a  value has the same granularity as a  and supports the date ranges required by Javascript and .NET.

For more detailed information, see the [Windows.Foundation.DateTime](../windows.foundation/datetime.md) structure.



The following sample code shows a method to set the **Date** header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the Date property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) object.

```csharp
    public void DemonstrateHeaderRequestDate() {
        var request = new HttpRequestMessage();

        // This is not typically set with a string.

        // Set the header with a strong type.
        DateTimeOffset value = DateTimeOffset.UtcNow;
        request.Headers.Date = value;

        // Get the strong type out
        System.Diagnostics.Debug.WriteLine("Date value in ticks: {0}", request.Headers.Date.Value.Ticks);

        // The ToString() is useful for diagnostics, too.
        System.Diagnostics.Debug.WriteLine("The Date ToString() results: {0}", request.Headers.Date.ToString());
    }

```



## -examples

## -see-also
[DateTime](../windows.foundation/datetime.md), [HttpRequestMessage](../windows.web.http/httprequestmessage.md), [HttpRequestMessage.Headers](../windows.web.http/httprequestmessage_headers.md)
