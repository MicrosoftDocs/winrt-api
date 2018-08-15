---
-api-id: P:Windows.Networking.Sockets.ControlChannelTrigger.CurrentKeepAliveIntervalInMinutes
-api-type: winrt property
---

<!-- Property syntax
public uint CurrentKeepAliveIntervalInMinutes { get; }
-->

# Windows.Networking.Sockets.ControlChannelTrigger.CurrentKeepAliveIntervalInMinutes

## -description
Gets the network keep-alive interval, in minutes, maintained by low-level network components in the TCP stack based on current network conditions. 

> [!NOTE]
> The ControlChannelTrigger class is not supported on Windows Phone.

## -property-value
The network keep-alive interval, in minutes, maintained by low-level network components in the TCP stack based on current network conditions.

## -remarks
The [CurrentKeepAliveIntervalInMinutes](controlchanneltrigger_currentkeepaliveintervalinminutes.md) property represents the network keep-alive interval, in minutes, maintained by low-level network components in the TCP stack based on current network conditions. This value represents the value needed by network intermediaries to keep the TCP connection intact. These network intermediaries represent hardware and devices such as network proxies and network address translators. A network app cannot set this value, since this value is determined dynamically by low-level system components in the TCP stack . However, a network app can indicate to the system that the network keep-alive timer should be decreased if established TCP connections are regularly dropped by calling the [DecreaseNetworkKeepAliveInterval](controlchanneltrigger_decreasenetworkkeepaliveinterval_1909166565.md) method on the [ControlChannelTrigger](controlchanneltrigger.md) class.

## -examples

## -see-also
[DecreaseNetworkKeepAliveInterval](controlchanneltrigger_decreasenetworkkeepaliveinterval_1909166565.md), [ServerKeepAliveIntervalInMinutes](controlchanneltrigger_serverkeepaliveintervalinminutes.md)