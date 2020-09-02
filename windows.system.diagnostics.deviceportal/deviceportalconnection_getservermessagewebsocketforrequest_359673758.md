---
-api-id: M:Windows.System.Diagnostics.DevicePortal.DevicePortalConnection.GetServerMessageWebSocketForRequest(Windows.Web.Http.HttpRequestMessage,Windows.Networking.Sockets.SocketMessageType,System.String,System.UInt32,System.UInt32,Windows.Networking.Sockets.MessageWebSocketReceiveMode)
-api-type: winrt method
---

<!-- Method syntax.
public ServerMessageWebSocket DevicePortalConnection.GetServerMessageWebSocketForRequest(HttpRequestMessage request, SocketMessageType messageType, String protocol, UInt32 outboundBufferSizeInBytes, UInt32 maxMessageSize, MessageWebSocketReceiveMode receiveMode)
-->

# Windows.System.Diagnostics.DevicePortal.DevicePortalConnection.GetServerMessageWebSocketForRequest

## -description
Returns a server-side message WebSocket for use with Device Portal.

## -parameters
### -param request
The HTTP request message (found as a property of the **[DevicePortalConnectionRequestReceivedEventArgs](DevicePortalConnectionRequestReceivedEventArgs.md)** class).

### -param messageType
A **[SocketMessageType](/uwp/api/windows.networking.sockets.socketmessagetype)** value indicating the type of messaging that this WebSocket will use.

### -param protocol
The sub-protocol that this WebSocket will use.

### -param outboundBufferSizeInBytes
The size, in bytes, of the send buffer to be used for sending data on a **[ServerMessageWebSocket](../windows.networking.sockets/servermessagewebsocket.md)** object.

### -param maxMessageSize
The maximum message size, in bytes, for a WebSocket message to be configured on the **[ServerMessageWebSocket](../windows.networking.sockets/servermessagewebsocket.md)** object.

### -param receiveMode
A **[MessageWebSocketReceiveMode](/uwp/api/windows.networking.sockets.messagewebsocketreceivemode)** value indicating whether this WebSocket will receive either complete or partial messages.

## -returns
A server-side message WebSocket object that can be used with Device Portal.

## -remarks

## -see-also

## -examples

