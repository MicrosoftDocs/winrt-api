---
-api-id: P:Windows.Networking.Sockets.ServerStreamWebSocketInformation.BandwidthStatistics
-api-type: winrt property
---

<!-- Property syntax.
public BandwidthStatistics BandwidthStatistics { get; }
-->

# Windows.Networking.Sockets.ServerStreamWebSocketInformation.BandwidthStatistics

## -description
Gets bandwidth information for network data transfer on a [ServerStreamWebSocket](serverstreamwebsocket.md) object.

Note that the returned statistics are based on extended TCP statistics, which are enabled by default on Client versions of Windows, but disabled by default for performance reasons on Server versions of Windows. If extended TCP statistics are not available, all returned numerical statistics are set to 0, and boolean statistics are set to false.

## -property-value
Bandwidth information for network data transfer on a [ServerStreamWebSocket](serverstreamwebsocket.md) object.

## -remarks

## -see-also

## -examples

## -capabilities
internetClientServer, privateNetworkClientServer
