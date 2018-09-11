---
-api-id: P:Windows.Networking.Sockets.StreamSocketControl.SerializeConnectionAttempts
-api-type: winrt property
---

<!-- Property syntax
public bool SerializeConnectionAttempts { get;  set; }
-->

# Windows.Networking.Sockets.StreamSocketControl.SerializeConnectionAttempts

## -description
A value that indicates whether, when multiple connection attempts are being made, the attempts are made in parallel or serially.

## -property-value
When true, at most one connection attempt will be active at one time on this [StreamSocket](streamsocket.md). Default value is false.

## -remarks
In certain circumstances, the Windows runtime might attempt to establish a connection using multiple methods in parallel. For example, when [StreamSocket](streamsocket.md) attempts a connection and a proxy is detected on the network, it attempts both a direct connection to the specified IP address, and an HTTP CONNECT request (which will connect via the proxy) in parallel. The first connection to succeed is the one that is used by the [StreamSocket](streamsocket.md) object. While this works well in most cases, it causes problems with some servers in the case where both connection attempts succeed. If your app is using [StreamSocket](streamsocket.md) to connect to a server where the parallel connection method causes problems on the server, you should set [SerializeConnectionAttempts](streamsocketcontrol_serializeconnectionattempts.md) to true before connecting. This will ensure that at most one TCP connection attempt is ongoing at any given time, and that only a single connection is used.

Your code must set this property before you call [ConnectAsync](/uwp/api/windows.networking.sockets.streamsocket.connectasync) to attempt to connect. Changing this property value after [ConnectAsync](/uwp/api/windows.networking.sockets.streamsocket.connectasync) has been called results in an exception being thrown.

Note that serializing the connection logic can make establishing the connection take longer.

## -examples

## -see-also
