---
-api-id: M:Windows.Networking.Sockets.WebSocketServerCustomValidationRequestedEventArgs.Reject
-api-type: winrt method
---

<!-- Method syntax
public void Reject()
-->

# Windows.Networking.Sockets.WebSocketServerCustomValidationRequestedEventArgs.Reject

## -description
Rejects validation of this server. Call this method when your validation has determined that you should not connect to the server.

## -remarks
There is no explicit method that allows a connection during validation. If no event handler calls [Reject](websocketservercustomvalidationrequestedeventargs_reject.md), then the connection is allowed.

## -examples

## -see-also
