---
-api-id: P:Windows.Web.Http.Headers.HttpRequestHeaderCollection.Host
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.HostName Host { get;  set; }
-->

# Windows.Web.Http.Headers.HttpRequestHeaderCollection.Host

## -description
Gets or sets the [HostName](../windows.networking/hostname.md) that represents the value of a **Host** HTTP header on an HTTP request.

## -property-value
The [HostName](../windows.networking/hostname.md) that represents the value of a **Host** HTTP header on an HTTP request. A null value means that the header is absent.

## -remarks


The following sample code shows a method to set the **Host** header on an [HttpRequestMessage](../windows.web.http/httprequestmessage.md) object using the [Host](httprequestheadercollection_host.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) object.

```csharp
    public void DemonstrateHeaderRequestHost() {
        var request = new HttpRequestMessage();

        // This is not typically set with a string.

        // Set the header with a strong type.
        // HostName is in the Windows.Networking namespace.
        var value = new Windows.Networking.HostName("example.com");
        request.Headers.Host = value;

        // Get the strong type out
        System.Diagnostics.Debug.WriteLine("Canonical Host name: {0}", request.Headers.Host.CanonicalName);

        // The ToString() is useful for diagnostics, too.
        System.Diagnostics.Debug.WriteLine("The Host ToString() results: {0}", request.Headers.Host.ToString());
    }

```



## -examples

## -see-also
[HostName](../windows.networking/hostname.md), [HttpRequestMessage](../windows.web.http/httprequestmessage.md), [HttpRequestMessage.Headers](../windows.web.http/httprequestmessage_headers.md)