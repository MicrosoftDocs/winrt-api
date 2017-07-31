---
-api-id: P:Windows.Networking.Sockets.MessageWebSocketControl.DesiredUnsolicitedPongInterval
-api-type: winrt property
---

<!-- Property syntax.
public TimeSpan DesiredUnsolicitedPongInterval { get;  set; }
-->

# Windows.Networking.Sockets.MessageWebSocketControl.DesiredUnsolicitedPongInterval

## -description
Allows an app to get and set the desired unsolicited WebSocket PONG interval.
## -property-value
System.Timespan
## -remarks
This terminology is defined in WebSocket RFC 6455, which is the time between unsolicited Pong control frames sent by the client to the server. The PONG serves as a unidirectional heartbeat and can be used for the client to determine network connection issues.  
## -see-also
[MessageWebSocket](messagewebsocket.md)
## -examples

