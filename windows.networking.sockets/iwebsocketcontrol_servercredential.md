---
-api-id: P:Windows.Networking.Sockets.IWebSocketControl.ServerCredential
-api-type: winrt property
---

<!-- Property syntax
public Windows.Security.Credentials.PasswordCredential ServerCredential { get;  set; }
-->

# Windows.Networking.Sockets.IWebSocketControl.ServerCredential

## -description
The credential to use to authenticate to the WebSocket server through HTTP header authentication using an [IWebSocket](iwebsocket.md) object.

## -property-value
The credential to use to authenticate to the WebSocket server through HTTP header authentication.

## -remarks
The [ServerCredential](iwebsocketcontrol_servercredential.md) property must be set before calling the [ConnectAsync](iwebsocket_connectasync_682685111.md) method on the [IWebSocket](iwebsocket.md) object. An attempt to set the [ServerCredential](iwebsocketcontrol_servercredential.md) property after calling the [ConnectAsync](iwebsocket_connectasync_682685111.md) method will result in an error.

## -examples

## -see-also
[IWebSocket](iwebsocket.md)