---
-api-id: P:Windows.Web.Http.Headers.HttpContentHeaderCollection.Expires
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.DateTime> Expires { get;  set; }
-->

# Windows.Web.Http.Headers.HttpContentHeaderCollection.Expires

## -description
Gets or sets the [DateTime](../windows.foundation/datetime.md) object that represents the value of an HTTP **Expires** header on the HTTP content.

## -property-value
The object that represents the value of an HTTP **Expires** header on the HTTP content. A **null** value means that the header is absent.

## -remarks
The Expires property represents the value of the **Expires** header on HTTP content. The **Expires** header is the date and time after which the HTTP content is considered outdated.

Javascript and .NET languages do not use the [DateTime](../windows.foundation/datetime.md) object directly. In Javascript a [DateTime](../windows.foundation/datetime.md) is projected as a  object, and in .NET it is projected as a [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true). Each language transparently handles the conversion to the granularity and date ranges for the respective language.

In C++, a  value has the same granularity as a  and supports the date ranges required by Javascript and .NET.

For more detailed information, see the [Windows.Foundation.DateTime](../windows.foundation/datetime.md) structure.



The following sample code shows a method to get or set the **Expires** header value on HTTP content using the Expires property on the [HttpContentHeaderCollection](httpcontentheadercollection.md) object.

```csharp
    // Expires header
    // nullable DateTimeOffset
    //
    void DemoExpires(IHttpContent content) {
        var h = content.Headers;
        h.Expires = DateTimeOffset.Now;

        var header = h.Expires;
        uiLog.Text += "\nEXPIRES HEADER\n";
        uiLog.Text += String.Format ("Expires: {0}\n", header.ToString());
    }

```



## -examples

## -see-also
[Windows.Foundation.DateTime](../windows.foundation/datetime.md)
