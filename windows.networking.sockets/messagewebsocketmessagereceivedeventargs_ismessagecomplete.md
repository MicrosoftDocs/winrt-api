---
-api-id: P:Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs.IsMessageComplete
-api-type: winrt property
---

<!-- Property syntax.
public bool IsMessageComplete { get; }
-->

# Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs.IsMessageComplete

## -description
Allow clients to query if a MessageReceived callback indicates the received message is complete or just a partial message. 
## -property-value
TRUE if the message is complete. The default value is FALSE.
## -remarks
This flag is always true if ReceiveMode is FullMessage mode (the default), but only true for the last (for a given set of fragments) MessageReceive callback in the new PartialMessage mode. 

## -see-also
[MessageWebSocket](messagewebsocket.md)
## -examples

