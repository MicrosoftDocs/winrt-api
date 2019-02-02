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
[How to use advanced socket controls ](https://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](https://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [BandwidthStatistics](bandwidthstatistics.md), [StreamSocket](streamsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
