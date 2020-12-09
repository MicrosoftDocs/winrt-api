---
-api-id: P:Windows.Networking.Sockets.StreamWebSocketInformation.BandwidthStatistics
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.BandwidthStatistics BandwidthStatistics { get; }
-->

# Windows.Networking.Sockets.StreamWebSocketInformation.BandwidthStatistics

## -description
Gets bandwidth information for network data transfer on a [StreamWebSocket](streamwebsocket.md) object.

Note that the returned statistics are based on extended TCP statistics, which are enabled by default on Client versions of Windows, but disabled by default for performance reasons on Server versions of Windows. If extended TCP statistics are not available, all returned numerical statistics are set to 0, and boolean statistics are set to false.

## -property-value
Bandwidth information for network data transfer on a [StreamWebSocket](streamwebsocket.md) object.

## -remarks

## -examples

## -see-also
[How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)), [BandwidthStatistics](bandwidthstatistics.md), [StreamWebSocket](streamwebsocket.md)
