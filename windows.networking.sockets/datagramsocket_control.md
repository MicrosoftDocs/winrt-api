---
-api-id: P:Windows.Networking.Sockets.DatagramSocket.Control
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.DatagramSocketControl Control { get; }
-->

# Windows.Networking.Sockets.DatagramSocket.Control

## -description
Gets socket control data on a [DatagramSocket](datagramsocket.md) object.

## -property-value
Socket control data on a [DatagramSocket](datagramsocket.md) object.

## -remarks
The [Control](datagramsocket_bindendpointasync_1396029045.md) property gets the [DatagramSocketControl](datagramsocketcontrol.md) instance associated with a [DatagramSocket](datagramsocket.md) object. A [DatagramSocketControl](datagramsocketcontrol.md) object is automatically created with the parent [DatagramSocket](datagramsocket.md) object. The [DatagramSocketControl](datagramsocketcontrol.md) instance can then be used to get or set control data used by the [DatagramSocket](datagramsocket.md). These properties on the [DatagramSocketControl](datagramsocketcontrol.md) instance include the following:


+ [DontFragment](datagramsocketcontrol_dontfragment.md) - Gets or sets a **Boolean** value that specifies whether the [DatagramSocket](datagramsocket.md) allows IP datagrams for UDP to be fragmented.
+ [InboundBufferSizeInBytes](datagramsocketcontrol_inboundbuffersizeinbytes.md) - Gets or sets the size, in bytes, of the buffer used for receiving data on the [DatagramSocket](datagramsocket.md) object.
+ [OutboundUnicastHopLimit](datagramsocketcontrol_outboundunicasthoplimit.md) - Gets or sets the hop limit on an outbound packet sent to a unicast IP address by the [DatagramSocket](datagramsocket.md) object.
+ [QualityOfService](datagramsocketcontrol_qualityofservice.md) - Gets or sets the quality of service on a [DatagramSocket](datagramsocket.md) object.


The [OutboundUnicastHopLimit](datagramsocketcontrol_outboundunicasthoplimit.md) property can be set before or after the [DatagramSocket](datagramsocket.md) is bound or connected. Before changing this value on a bound or connected [DatagramSocket](datagramsocket.md), any outgoing packets should first be flushed to ensure that all previously-written data is sent out with the previous hop limit.

Any changes to the other property values on the [DatagramSocketControl](datagramsocketcontrol.md) must be set before the [DatagramSocket](datagramsocket.md) is bound or connected. As a result if you need to make changes to the [DontFragment](datagramsocketcontrol_dontfragment.md), [InboundBufferSizeInBytes](datagramsocketcontrol_inboundbuffersizeinbytes.md), or [QualityOfService](datagramsocketcontrol_qualityofservice.md) properties, then these changes must occur before a successful call to the [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md), [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md), or one of the [ConnectAsync](datagramsocket_connectasync_13692504.md) methods on the [DatagramSocket](datagramsocket.md).

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [DatagramSocketControl](datagramsocketcontrol.md), [DontFragment](datagramsocketcontrol_dontfragment.md), [InboundBufferSizeInBytes](datagramsocketcontrol_inboundbuffersizeinbytes.md), [OutboundUnicastHopLimit](datagramsocketcontrol_outboundunicasthoplimit.md), [QualityOfService](datagramsocketcontrol_qualityofservice.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
