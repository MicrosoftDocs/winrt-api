---
-api-id: M:Windows.Networking.Sockets.StreamWebSocket.ConnectAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ConnectAsync(Windows.Foundation.Uri uri)
-->

# Windows.Networking.Sockets.StreamWebSocket.ConnectAsync

## -description
Starts an asynchronous operation to connect to a remote network destination on a [StreamWebSocket](streamwebsocket.md) object.

## -parameters
### -param uri
An absolute [Uri](../windows.foundation/uri.md) for the server to connect to.

## -returns
An asynchronous connect operation on a [StreamWebSocket](streamwebsocket.md) object.

## -remarks
The [ConnectAsync](streamwebsocket_connectasync_682685111.md) method initiates the WebSocket handshake with a remote network destination, and then negotiates the subprotocol.

For WebSocket connections over TCP, use the **ws://** scheme in the *uri*. For secure WebSocket connections over TLS/SSL, use the **wss://** scheme.

## -examples

## -see-also
[Uri](../windows.foundation/uri.md)