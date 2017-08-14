---
-api-id: P:Windows.Networking.Sockets.StreamSocketControl.OutboundUnicastHopLimit
-api-type: winrt property
---

<!-- Property syntax
public byte OutboundUnicastHopLimit { get;  set; }
-->

# Windows.Networking.Sockets.StreamSocketControl.OutboundUnicastHopLimit

## -description
The hop limit on an outbound packet sent to a unicast IP address by the [StreamSocket](streamsocket.md) object.

## -property-value
The hop limit on an outbound packet sent by the [StreamSocket](streamsocket.md) object. The default is 128.

## -remarks
This value indicates the hop limit that is set on an outbound TCP packet sent to a unicast IP address using the [StreamSocket](streamsocket.md) object. This property is used to set the Time to Live (TTL) field in an IPv4 packet header. This property is used to set the Hop Limit field in an IPv6 header. The default value for this property is 128.

This property may be set before the [StreamSocket](streamsocket.md) is connected. After the [StreamSocket](streamsocket.md) is connected, setting this property will result in an error.

Setting the [OutboundUnicastHopLimit](streamsocketcontrol_outboundunicasthoplimit.md) may not have an effect if the system doesn't support setting the TTL.

## -examples

## -see-also
[How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [StreamSocket](streamsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
