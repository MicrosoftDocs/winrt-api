---
-api-id: M:Windows.System.Diagnostics.DevicePortal.DevicePortalConnection.GetServerStreamWebSocketForRequest(Windows.Web.Http.HttpRequestMessage,System.String,System.UInt32,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public ServerStreamWebSocket DevicePortalConnection.GetServerStreamWebSocketForRequest(HttpRequestMessage request, String protocol, UInt32 outboundBufferSizeInBytes, Boolean noDelay)
-->

# Windows.System.Diagnostics.DevicePortal.DevicePortalConnection.GetServerStreamWebSocketForRequest

## -description
Returns a server-side stream WebSocket for use with Device Portal.

## -parameters
### -param request
The HTTP request message (found as a property of the **[DevicePortalConnectionRequestReceivedEventArgs](DevicePortalConnectionRequestReceivedEventArgs.md)** class).

### -param protocol
The sub-protocol that this WebSocket will use.

### -param outboundBufferSizeInBytes
The size, in bytes, of the send buffer to be used for sending data on a **[ServerMessageWebSocket](../windows.networking.sockets/servermessagewebsocket.md)** object.

### -param noDelay
A boolean value indicating whether Nagle's algorithm is used on this WebSocket object. See the **[StreamSocketControl](/uwp/api/windows.networking.sockets.streamsocketcontrol)** class for more information on Nagle's algorithm.

## -returns
A server-side stream WebSocket object that can be used with Device Portal.

## -remarks

## -see-also

## -examples

