---
-api-id: P:Windows.Web.Http.Headers.HttpResponseHeaderCollection.Date
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.DateTime> Date { get;  set; }
-->

# Windows.Web.Http.Headers.HttpResponseHeaderCollection.Date

## -description
Gets or sets the [DateTime](../windows.foundation/datetime.md) object that represents the value of a **Date** HTTP header on an HTTP response.

## -property-value
The object that represents the value of a **Date** HTTP header on an HTTP request. A **null** value means that the header is absent.

## -remarks
The Date property represents the value of a **Date** HTTP header on an HTTP response. The **Date** header is the date and time the message was sent.

Javascript and .NET languages do not use the [DateTime](../windows.foundation/datetime.md) object directly. In Javascript a [DateTime](../windows.foundation/datetime.md) is projected as a  object, and in .NET it is projected as a [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true). Each language transparently handles the conversion to the granularity and date ranges for the respective language.

In C++, a  value has the same granularity as a  and supports the date ranges required by Javascript and .NET.

For more detailed information, see the [Windows.Foundation.DateTime](../windows.foundation/datetime.md) structure.



The following sample code shows a method to get and set the **Date** header on an [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) object using the Date property on the [HttpResponseHeaderCollection](httpresponseheadercollection.md) object.

```csharp
    public void DemonstrateHeaderResponseDate() {
        var response = new HttpResponseMessage();

        // Set the header with a strong type.
        response.Headers.Date = DateTimeOffset.UtcNow;

        // Get the strong type out
        System.Diagnostics.Debug.WriteLine("Date value in ticks: {0}", response.Headers.Date.Value.Ticks);

        // The ToString() is useful for diagnostics, too.
        System.Diagnostics.Debug.WriteLine("The Date ToString() results: {0}", response.Headers.Date.ToString());
    }

```



## -examples

## -see-also
[HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [HttpResponseMessage.Headers](../windows.web.http/httpresponsemessage_headers.md), [Windows.Foundation.DateTime](../windows.foundation/datetime.md)
