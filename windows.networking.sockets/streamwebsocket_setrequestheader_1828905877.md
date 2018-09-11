---
-api-id: M:Windows.Networking.Sockets.StreamWebSocket.SetRequestHeader(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void SetRequestHeader(System.String headerName, System.String headerValue)
-->

# Windows.Networking.Sockets.StreamWebSocket.SetRequestHeader

## -description
Adds an HTTP request header to the HTTP request message used in the WebSocket protocol handshake by the [StreamWebSocket](streamwebsocket.md) object.

## -parameters
### -param headerName
The name of the request header.

### -param headerValue
The value of the request header.

## -remarks
The [SetRequestHeader](streamwebsocket_setrequestheader_1828905877.md) method must be called prior to calling the [ConnectAsync](streamwebsocket_connectasync_682685111.md) method. Calling the [SetRequestHeader](streamwebsocket_setrequestheader_1828905877.md) method after calling the [ConnectAsync](streamwebsocket_connectasync_682685111.md) method will result in an error.

Using the [SetRequestHeader](streamwebsocket_setrequestheader_1828905877.md) method to add a **Sec-WebSocket-Extensions** header is not supported.



## -examples

## -see-also
[ConnectAsync](streamwebsocket_connectasync_682685111.md)