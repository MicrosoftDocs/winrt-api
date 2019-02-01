---
-api-id: M:Windows.Networking.Sockets.MessageWebSocket.ConnectAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ConnectAsync(Windows.Foundation.Uri uri)
-->

# Windows.Networking.Sockets.MessageWebSocket.ConnectAsync

## -description
Starts an asynchronous operation to connect to a remote network destination on a [MessageWebSocket](messagewebsocket.md) object.

## -parameters
### -param uri
An absolute [Uri](../windows.foundation/uri.md) for the server to connect to.

## -returns
An asynchronous connect operation on a [MessageWebSocket](messagewebsocket.md) object.

## -remarks
The [ConnectAsync](messagewebsocket_connectasync_682685111.md) method initiates the WebSocket handshake with a remote network destination, and then negotiates the subprotocol.

For WebSocket connections over TCP, use the **ws://** scheme in the *uri*. For secure WebSocket connections over TLS/SSL, use the **wss://** scheme.

## -examples

## -see-also
[Uri](../windows.foundation/uri.md), [How to secure WebSocket connections with TLS/SSL](https://msdn.microsoft.com/library/0edaa6c3-f16d-4578-a039-60c547e99ad4)
