---
-api-id: E:Windows.Networking.Sockets.MessageWebSocket.Closed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Closed<Windows.Networking.Sockets.IWebSocket,  Windows.Networking.Sockets.WebSocketClosedEventArgs>
-->

# Windows.Networking.Sockets.MessageWebSocket.Closed

## -description
Occurs when a close frame is received on the [MessageWebSocket](messagewebsocket.md) object as part of the close handshake.

## -remarks
This event is only triggered if a close frame is received from the server or if [Close](messagewebsocket_close_294895258.md) is explicitly called on the local socket. If the underlying TCP connection is suddenly terminated, [GetDataReader](messagewebsocketmessagereceivedeventargs_getdatareader_509392724.md) and/or [GetDataStream](messagewebsocketmessagereceivedeventargs_getdatastream_1357691687.md) throw the WININET_E_CONNECTION_ABORTED exception, without the [Close](messagewebsocket_closed.md) event ever being raised.

Your code should handle aborted connections by first closing and disposing of the current [MessageWebSocket](messagewebsocket.md) object (as it is now useless), and then performing whatever other steps are appropriate for your app, such as creating a new MessageWebSocket and trying to connect again.

## -examples

## -see-also
[WebSocketClosedEventArgs](websocketclosedeventargs.md)