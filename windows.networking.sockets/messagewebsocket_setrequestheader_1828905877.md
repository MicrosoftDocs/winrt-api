---
-api-id: M:Windows.Networking.Sockets.MessageWebSocket.SetRequestHeader(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void SetRequestHeader(System.String headerName, System.String headerValue)
-->

# Windows.Networking.Sockets.MessageWebSocket.SetRequestHeader

## -description
Adds an HTTP request header to the HTTP request message used in the WebSocket protocol handshake by the [MessageWebSocket](messagewebsocket.md) object.

## -parameters
### -param headerName
The name of the request header.

### -param headerValue
The value of the request header.

## -remarks
The SetRequestHeader method must be called prior to calling the [ConnectAsync](messagewebsocket_connectasync_682685111.md) method. Calling the SetRequestHeader method after calling the [ConnectAsync](messagewebsocket_connectasync_682685111.md) method will result in an error.

Using the SetRequestHeader method to add a **Sec-WebSocket-Extensions** header is not supported.

## -examples

## -see-also
[ConnectAsync](messagewebsocket_connectasync_682685111.md)
