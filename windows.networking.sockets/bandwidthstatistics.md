---
-api-id: T:Windows.Networking.Sockets.BandwidthStatistics
-api-type: winrt struct
---

<!-- Structure syntax.
public struct BandwidthStatistics 
-->

# BandwidthStatistics

## -description
Represents bandwidth information for network data transfer using a [StreamSocket](streamsocket.md), [StreamWebSocket](streamwebsocket.md), or [MessageWebSocket](messagewebsocket.md) object.

## -struct-fields

### -field OutboundBitsPerSecond
The computed outbound bandwidth estimate in bits per second.

This value is always 0 on systems that do not have extended TCP statistics enabled by default.
    

### -field InboundBitsPerSecond
The computed inbound bandwidth estimate in bits per second.

This value is always 0 on systems that do not have extended TCP statistics enabled by default.
    

### -field OutboundBitsPerSecondInstability
A measure of the instability of the outbound bandwidth estimate in bits per second.

This value is always 0 on systems that do not have extended TCP statistics enabled by default.
    

### -field InboundBitsPerSecondInstability
A measure of the instability of the inbound bandwidth estimate in bits per second.

This value is always 0 on systems that do not have extended TCP statistics enabled by default.
    

### -field OutboundBandwidthPeaked
A Boolean value that indicates whether the computed outbound bandwidth estimate for the network path has peaked.

This member is set to **true** when the app is using enough of the connection bandwidth that the system can get a good estimate of the bandwidth delay product and can determine that the congestion window is a substantial fraction of the bandwidth delay product. This member can change from **true** to **false** if the app sends less data.

This value is always false on systems that do not have extended TCP statistics enabled by default.
    

### -field InboundBandwidthPeaked
A Boolean value that indicates whether the computed inbound bandwidth estimate for the network has peaked.

This member is set to **true** when the app is using enough of the connection bandwidth that the system can get a good estimate of the bandwidth delay product and can determine that the congestion window is a substantial fraction of the bandwidth delay product. This member can change from **true** to **false** if the app sends less data.

This value is always false on systems that do not have extended TCP statistics enabled by default.
    

## -remarks


## -examples

## -see-also
[MessageWebSocket](messagewebsocket.md), [StreamSocket](streamsocket.md), [StreamWebSocket](streamwebsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
