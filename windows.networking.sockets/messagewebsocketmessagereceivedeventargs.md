---
-api-id: T:Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class MessageWebSocketMessageReceivedEventArgs : Windows.Networking.Sockets.IMessageWebSocketMessageReceivedEventArgs
-->

# Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs

## -description
Provides data for a message received event on a [MessageWebSocket](messagewebsocket.md).

## -remarks
The MessageWebSocketMessageReceivedEventArgs is used to receive data on a [MessageWebSocket](messagewebsocket.md) object.

A [MessageWebSocket.MessageReceived](messagewebsocket_messagereceived.md) event occurs on a [MessageWebSocket](messagewebsocket.md) when a message is received. A MessageWebSocketMessageReceivedEventArgs instance is created when the [MessageWebSocket.MessageReceived](messagewebsocket_messagereceived.md) event occurs.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | IsMessageComplete |

## -examples

## -see-also
 [WebSockets](/windows/uwp/networking/websockets), [MessageWebSocket](messagewebsocket.md)
