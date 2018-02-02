---
-api-id: P:Windows.Networking.Sockets.StreamWebSocketControl.DesiredUnsolicitedPongInterval
-api-type: winrt property
---

<!-- Property syntax.
public TimeSpan DesiredUnsolicitedPongInterval { get;  set; }
-->

# Windows.Networking.Sockets.StreamWebSocketControl.DesiredUnsolicitedPongInterval

## -description
Allows an app to get and set the desired unsolicited WebSocket PONG interval.
## -property-value
System.Timespan
## -remarks
This terminology is defined in WebSocket RFC 6455, which is the time between unsolicited Pong control frames sent by the client to the server. The PONG serves as a unidirectional heartbeat and can be used for the client to determine network connection issues.  

Note that setting the DesiredUnsolicitedPongInterval on a StreamWebSocket associated with a [ControlChannelTrigger](https://docs.microsoft.com/en-us/uwp/api/Windows.Networking.Sockets.ControlChannelTrigger) is not supported. Setting the property does not change the actual interval.
Even though a custom unsolicited PONG interval is not supported with a [ControlChannelTrigger](https://docs.microsoft.com/en-us/uwp/api/Windows.Networking.Sockets.ControlChannelTrigger) WebSocket, the [ControlChannelTrigger](https://docs.microsoft.com/en-us/uwp/api/Windows.Networking.Sockets.ControlChannelTrigger) is impacted by two types of keep-alive intervals  (1) network keep-alive interval and (2) server keep-alive interval. See [ControlChannelTrigger Remarks](https://docs.microsoft.com/en-us/uwp/api/Windows.Networking.Sockets.ControlChannelTrigger#Remarks) for details. The server keep-alive interval can be configured through ControlChannelTrigger’s [ServerKeepAliveIntervalInMinutes](https://docs.microsoft.com/en-us/uwp/api/windows.networking.sockets.controlchanneltrigger#Windows_Networking_Sockets_ControlChannelTrigger_ServerKeepAliveIntervalInMinutes) property while implementing application level PONGs. 
## -see-also

## -examples

