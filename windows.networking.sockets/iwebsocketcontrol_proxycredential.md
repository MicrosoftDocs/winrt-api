---
-api-id: P:Windows.Networking.Sockets.IWebSocketControl.ProxyCredential
-api-type: winrt property
---

<!-- Property syntax
public Windows.Security.Credentials.PasswordCredential ProxyCredential { get;  set; }
-->

# Windows.Networking.Sockets.IWebSocketControl.ProxyCredential

## -description
The credential to use to authenticate to the proxy server through HTTP header authentication using an [IWebSocket](iwebsocket.md) object.

## -property-value
The credential to use to authenticate to the proxy server through HTTP header authentication.

## -remarks
The [ProxyCredential](iwebsocketcontrol_proxycredential.md) property must be set before calling the [ConnectAsync](iwebsocket_connectasync.md) method on the [IWebSocket](iwebsocket.md) object. An attempt to set the [ProxyCredential](iwebsocketcontrol_proxycredential.md) property after calling the [ConnectAsync](iwebsocket_connectasync.md) method will result in an error.

## -examples

## -see-also
[IWebSocket](iwebsocket.md)