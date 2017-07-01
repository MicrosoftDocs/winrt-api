---
-api-id: P:Windows.Networking.Sockets.StreamWebSocketControl.ActualUnsolicitedPongInterval
-api-type: winrt property
---

<!-- Property syntax.
public TimeSpan ActualUnsolicitedPongInterval { get; }
-->

# Windows.Networking.Sockets.StreamWebSocketControl.ActualUnsolicitedPongInterval

## -description
Allows an app to get the actual unsolicited WebSocket PONG interval.
## -property-value
System.Timespan
## -remarks
This terminology is defined in WebSocket RFC 6455, which is the time between unsolicited Pong control frames sent by the client to the server. The PONG serves as a unidirectional heartbeat and can be used for the client to determine network connection issues.  

## -see-also
[StreamWebSocket](streamwebsocket.md)
## -examples

