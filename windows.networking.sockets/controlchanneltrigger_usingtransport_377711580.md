---
-api-id: M:Windows.Networking.Sockets.ControlChannelTrigger.UsingTransport(System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void UsingTransport(System.Object transport)
-->

# Windows.Networking.Sockets.ControlChannelTrigger.UsingTransport

## -description
Sets the transport connection to be used by a control channel trigger by class elements in the [Windows.Networking.Sockets](windows_networking_sockets.md) and related namespaces. 

> [!NOTE]
> The ControlChannelTrigger class is not supported on Windows Phone.

## -parameters
### -param transport
The instance of the network class that represents the network transport.

## -remarks
The UsingTransport method indicates to the system the transport connection to be used by the [ControlChannelTrigger](controlchanneltrigger.md) .

An app must call the UsingTransport method after the transport object (a [StreamSocket](streamsocket.md) instance, for example) has been created, but before a network connection is established.

For a [StreamSocket](streamsocket.md), the constructor for the [StreamSocket](streamsocket.md) would first be called to create the transport object. Then the returned [StreamSocket](streamsocket.md) instance would be passed to the UsingTransport method as the *transport* parameter. Only then can one of the [StreamSocket.ConnectAsync](streamsocket_connectasync_13692504.md) methods be called to establish the network connection.

For [HttpClient](../windows.web.http/httpclient.md) in the [Windows.Web.Http](../windows.web.http/windows_web_http.md) namespace, the UsingTransport method needs to be called with the initialized [HttpClient](../windows.web.http/httpclient.md) instance before any of the GET, PUT, POST, SEND, OR DELETE request methods on the [HttpClient](../windows.web.http/httpclient.md) or related classes are invoked.

For [IXMLHTTPRequest2](/previous-versions/windows/desktop/api/msxml6/nn-msxml6-ixmlhttprequest2) interface, the HTTP request must be opened first using the [Open](/previous-versions/windows/desktop/api/msxml6/nf-msxml6-ixmlhttprequest2-open) method and passed to the UsingTransport method. Then the [Send](/previous-versions/windows/desktop/api/msxml6/nf-msxml6-ixmlhttprequest2-send) method on the [IXMLHTTPRequest2](/previous-versions/windows/desktop/api/msxml6/nn-msxml6-ixmlhttprequest2) object can be invoked to send the HTTP request.

For , the UsingTransport method needs to be called with the initialized  instance before any of the GET, PUT, POST, SEND, OR DELETE request methods on the  or related classes are invoked.

## -examples

## -see-also
[How to set background connectivity options](/previous-versions/windows/apps/hh771189(v=win.10)), [IXMLHTTPRequest2](/previous-versions/windows/desktop/api/msxml6/nn-msxml6-ixmlhttprequest2), [StreamSocket](streamsocket.md), , [Windows.Web.Http.HttpClient](../windows.web.http/httpclient.md)
