---
-api-id: M:Windows.Networking.Sockets.MessageWebSocket.Close(System.UInt16,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void Close(System.UInt16 code, System.String reason)
-->

# Windows.Networking.Sockets.MessageWebSocket.Close

## -description
Closes the [MessageWebSocket](messagewebsocket.md) object and indicates a reason for the closure.

## -parameters
### -param code
Status code indicating the reason for closure. The list of appropriate codes is on the IANA (Internet Assigned Numbers Authority) WebSocket Protocol [Registry](https://www.iana.org/assignments/websocket/websocket.xml#close-code-number) and is also documented on [MDN](https://developer.mozilla.org/docs/Web/API/CloseEvent).

### -param reason
Optional UTF-8-encoded data with additional information about the closure.

## -remarks

## -examples

## -see-also
[Close](messagewebsocket_close_811482585.md)
