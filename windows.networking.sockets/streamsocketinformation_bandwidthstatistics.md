---
-api-id: P:Windows.Networking.Sockets.StreamSocketInformation.BandwidthStatistics
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.BandwidthStatistics BandwidthStatistics { get; }
-->

# Windows.Networking.Sockets.StreamSocketInformation.BandwidthStatistics

## -description
Gets bandwidth information for network data transfer on a [StreamSocket](streamsocket.md) object.

Note that the returned statistics are based on extended TCP statistics, which are enabled by default on Client versions of Windows, but disabled by default for performance reasons on Server versions of Windows. If extended TCP statistics are not available, all returned numerical statistics are set to 0, and boolean statistics are set to false.

## -property-value
Bandwidth information for network data transfer on a [StreamSocket](streamsocket.md) object.

## -remarks

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [BandwidthStatistics](bandwidthstatistics.md), [StreamSocket](streamsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
