---
-api-id: P:Windows.Networking.Sockets.StreamSocketInformation.LocalAddress
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.HostName LocalAddress { get; }
-->

# Windows.Networking.Sockets.StreamSocketInformation.LocalAddress

## -description
Gets the local IP address associated with a [StreamSocket](streamsocket.md) object.

## -property-value
The local IP address or hostname.

## -remarks
The LocalAddress property represents the local IP address the [StreamSocket](streamsocket.md) object is bound to after a connection is established.

An app can set the local hostname or IP address to use by calling the [ConnectAsync(EndpointPair)](streamsocket_connectasync_13692504.md) or [ConnectAsync(EndpointPair, SocketProtectionLevel)](streamsocket_connectasync_706428084.md) method on the [StreamSocket](streamsocket.md). The connect operation will bind the socket to the specific local IP address and local UDP port number. After the bind or connect operation completes, the LocalAddress property contains the IP address and the [LocalPort](streamsocketinformation_localport.md) property contains the local TCP port number that the local hostname and service name resolved to.

If the local hostname or IP address passed to the [ConnectAsync(EndpointPair)](streamsocket_connectasync_13692504.md) or [ConnectAsync(EndpointPair, SocketProtectionLevel)](streamsocket_connectasync_706428084.md) method is null or the [ConnectAsync(HostName, String)](streamsocket_connectasync_1841953676.md) or [ConnectAsync(HostName, String, SocketProtectionLevel)](streamsocket_connectasync_945708620.md) method is called, the system will determine the local IP address to bind to the [StreamSocket](streamsocket.md) object.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [ConnectAsync](streamsocket_connectasync_13692504.md), [HostName](../windows.networking/hostname.md), [LocalPort](streamsocketinformation_localport.md), [StreamSocket](streamsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
