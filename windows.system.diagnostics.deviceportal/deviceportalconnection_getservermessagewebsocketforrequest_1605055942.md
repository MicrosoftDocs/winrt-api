---
-api-id: M:Windows.System.Diagnostics.DevicePortal.DevicePortalConnection.GetServerMessageWebSocketForRequest(Windows.Web.Http.HttpRequestMessage,Windows.Networking.Sockets.SocketMessageType,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public ServerMessageWebSocket DevicePortalConnection.GetServerMessageWebSocketForRequest(HttpRequestMessage request, SocketMessageType messageType, String protocol)
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

## -returns
A server-side message WebSocket object that can be used with Device Portal.

## -remarks

## -see-also

## -examples

