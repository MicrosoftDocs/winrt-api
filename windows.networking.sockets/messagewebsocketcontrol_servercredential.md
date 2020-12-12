---
-api-id: P:Windows.Networking.Sockets.MessageWebSocketControl.ServerCredential
-api-type: winrt property
---

<!-- Property syntax
public Windows.Security.Credentials.PasswordCredential ServerCredential { get;  set; }
-->

# Windows.Networking.Sockets.MessageWebSocketControl.ServerCredential

## -description
The credential to use to authenticate to the WebSocket server through HTTP header authentication using a [MessageWebSocket](messagewebsocket.md) object.

## -property-value
The credential to use to authenticate to the WebSocket server through HTTP header authentication.

## -remarks
The ServerCredential property must be set before calling the [ConnectAsync](messagewebsocket_connectasync_682685111.md) method on the [MessageWebSocket](messagewebsocket.md) object. An attempt to set the ServerCredential property after calling the [ConnectAsync](messagewebsocket_connectasync_682685111.md) method will result in an error.

## -examples

## -see-also
[How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)), [ConnectAsync](messagewebsocket_connectasync_682685111.md), [MessageWebSocket](messagewebsocket.md), [PasswordCredential](../windows.security.credentials/passwordcredential.md), [ProxyCredential](messagewebsocketcontrol_proxycredential.md)
