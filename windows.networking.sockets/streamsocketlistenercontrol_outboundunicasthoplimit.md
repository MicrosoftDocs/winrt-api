---
-api-id: P:Windows.Networking.Sockets.StreamSocketListenerControl.OutboundUnicastHopLimit
-api-type: winrt property
---

<!-- Property syntax
public byte OutboundUnicastHopLimit { get;  set; }
-->

# Windows.Networking.Sockets.StreamSocketListenerControl.OutboundUnicastHopLimit

## -description
The hop limit on an outbound packet sent to a unicast IP address by the [StreamSocket](streamsocket.md) object created when a connection is received by the [StreamSocketListener](streamsocketlistener.md) object.

## -property-value
The hop limit on an outbound packet sent by the [StreamSocket](streamsocket.md) object created. The default is 128.

## -remarks
This value indicates the hop limit that is set on an outbound TCP packet sent to a unicast IP address using the [StreamSocket](streamsocket.md) object created. This property is used to set the Time to Live (TTL) field in an IPv4 packet header. This property is used to set the Hop Limit field in an IPv6 header. The default value for this property is 128.

This property may be set before the [StreamSocketListener](streamsocketlistener.md) starts listening for incoming connections. After the [StreamSocketListener](streamsocketlistener.md) starts listening for incoming connections, setting the property will result in an error.

Setting this property may throw an exception if the system doesn't support setting the TTL.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [StreamSocket](streamsocket.md), [StreamSocketListener](streamsocketlistener.md)
