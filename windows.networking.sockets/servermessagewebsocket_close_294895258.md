---
-api-id: M:Windows.Networking.Sockets.ServerMessageWebSocket.Close(System.UInt16,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public void ServerMessageWebSocket.Close(UInt16 code, String reason)
-->

# Windows.Networking.Sockets.ServerMessageWebSocket.Close

## -description
Closes the [ServerMessageWebSocket](servermessagewebsocket.md) object and indicates a reason for the closure.

## -parameters
### -param code
Status code indicating the reason for closure. The list of appropriate codes is on the IANA (Internet Assigned Numbers Authority) WebSocket Protocol [Registry](https://www.iana.org/assignments/websocket/websocket.xml#close-code-number) and is also documented on [MDN](https://developer.mozilla.org/docs/Web/API/CloseEvent).

### -param reason
Optional UTF-8-encoded data with additional information about the closure.

## -remarks

## -see-also

## -examples

## -capabilities
internetClientServer, privateNetworkClientServer
