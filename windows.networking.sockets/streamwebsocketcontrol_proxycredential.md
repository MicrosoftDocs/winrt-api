---
-api-id: P:Windows.Networking.Sockets.StreamWebSocketControl.ProxyCredential
-api-type: winrt property
---

<!-- Property syntax
public Windows.Security.Credentials.PasswordCredential ProxyCredential { get;  set; }
-->

# Windows.Networking.Sockets.StreamWebSocketControl.ProxyCredential

## -description
The credential to use to authenticate to the proxy server through HTTP header authentication using a [StreamWebSocket](streamwebsocket.md) object.

## -property-value
The credential to use to authenticate to the proxy server through HTTP header authentication.

## -remarks
The ProxyCredential property must be set before calling the [ConnectAsync](streamwebsocket_connectasync_682685111.md) method on the [StreamWebSocket](streamwebsocket.md) object. An attempt to set the ProxyCredential property after calling the [ConnectAsync](streamwebsocket_connectasync_682685111.md) method will result in an error.

## -examples

## -see-also
[How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)), [PasswordCredential](../windows.security.credentials/passwordcredential.md), [StreamWebSocket](streamwebsocket.md)
