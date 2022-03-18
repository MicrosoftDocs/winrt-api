---
-api-id: P:Windows.Web.Http.Headers.HttpContentHeaderCollection.LastModified
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.DateTime> LastModified { get;  set; }
-->

# Windows.Web.Http.Headers.HttpContentHeaderCollection.LastModified

## -description
Gets or sets the [DateTime](../windows.foundation/datetime.md) object that represents the value of an HTTP **Last-Modified** header on the HTTP content.

## -property-value
The object that represents the value of an HTTP **Last-Modified** header on the HTTP content. A **null** value means that the header is absent.

## -remarks
The LastModified property represents the **Last-Modified** header on HTTP content. The **Last-Modified** header is the date and time that the HTTP content was last modified.

Javascript and .NET languages do not use the [DateTime](../windows.foundation/datetime.md) object directly. In Javascript a [DateTime](../windows.foundation/datetime.md) is projected as a  object, and in .NET it is projected as a [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true). Each language transparently handles the conversion to the granularity and date ranges for the respective language.

In C++, a  value has the same granularity as a  and supports the date ranges required by Javascript and .NET.

For more detailed information, see the [Windows.Foundation.DateTime](../windows.foundation/datetime.md) structure.



The following sample code shows a method to get or set the **Expires** header value on HTTP content using the LastModified property on the [HttpContentHeaderCollection](httpcontentheadercollection.md) object.

```csharp
    // Last-Modified header
    // nullable DateTimeOffset
    //
    void DemoLastModified(IHttpContent content) {
        var h = content.Headers;
        h.LastModified = DateTimeOffset.Now;

        var header = h.LastModified;
        uiLog.Text += "\nLAST MODIFIED HEADER\n";
        uiLog.Text += String.Format("LastModified: {0}\n", header.ToString());
    }

```



## -examples

## -see-also
[Windows.Foundation.DateTime](../windows.foundation/datetime.md)
