---
-api-id: P:Windows.Networking.Sockets.StreamSocket.Control
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.StreamSocketControl Control { get; }
-->

# Windows.Networking.Sockets.StreamSocket.Control

## -description
Gets socket control data on a [StreamSocket](streamsocket.md) object.

## -property-value
Socket control data on a [StreamSocket](streamsocket.md) object.

## -remarks
The [Control](streamsocket_control.md) property gets the [StreamSocketControl](streamsocketcontrol.md) instance associated with a [StreamSocket](streamsocket.md) object.

A [StreamSocketControl](streamsocketcontrol.md) object is automatically created with the parent [StreamSocket](streamsocket.md) object. The [StreamSocketControl](streamsocketcontrol.md) instance can then be used to get or set control data used by the [StreamSocket](streamsocket.md) object. These properties on the [StreamSocketControl](streamsocketcontrol.md) instance include the following:


+ [IgnorableServerCertificateErrors](streamsocketcontrol_ignorableservercertificateerrors.md) - Get a vector of SSL server errors to ignore when making an SSL connection with a [StreamSocket](streamsocket.md) object.
+ [KeepAlive](streamsocketcontrol_keepalive.md) - A value that indicates whether keep-alive packets are sent to the remote destination on a [StreamSocket](streamsocket.md) object.
+ [NoDelay](streamsocketcontrol_nodelay.md) - A value that indicates whether the Nagle algorithm is used on a [StreamSocket](streamsocket.md) object.
+ [OutboundUnicastHopLimit](streamsocketcontrol_outboundunicasthoplimit.md) - The hop limit on an outbound packet sent to a unicast IP address by the [StreamSocket](streamsocket.md) object.
+ [OutboundBufferSizeInBytes](streamsocketcontrol_outboundbuffersizeinbytes.md) - - The size, in bytes, of the send buffer to be used for sending data on a [StreamSocket](streamsocket.md) object.
+ [QualityOfService](streamsocketcontrol_qualityofservice.md) - The quality of service on a [StreamSocket](streamsocket.md) object.


Any changes to the property values on the [StreamSocketControl](streamsocketcontrol.md) must be set before the [StreamSocket](streamsocket.md) is connected. As a result if you need to make changes to the [IgnorableServerCertificateErrors](streamsocketcontrol_ignorableservercertificateerrors.md), [KeepAlive](streamsocketcontrol_keepalive.md), [NoDelay](streamsocketcontrol_nodelay.md), [OutboundBufferSizeInBytes](streamsocketcontrol_outboundbuffersizeinbytes.md) , [OutboundUnicastHopLimit](streamsocketcontrol_outboundunicasthoplimit.md), or [QualityOfService](streamsocketcontrol_qualityofservice.md) properties, then these changes must occur before a successful call to one of the [ConnectAsync](streamsocket_connectasync.md) methods on the [StreamSocket](streamsocket.md).

## -examples

## -see-also
[How to use advanced socket controls](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [IgnorableServerCertificateErrors](streamsocketcontrol_ignorableservercertificateerrors.md), [KeepAlive](streamsocketcontrol_keepalive.md), [NoDelay](streamsocketcontrol_nodelay.md), [OutboundBufferSizeInBytes](streamsocketcontrol_outboundbuffersizeinbytes.md), [OutboundUnicastHopLimit](streamsocketcontrol_outboundunicasthoplimit.md), [QualityOfService](streamsocketcontrol_qualityofservice.md), [StreamSocketControl](streamsocketcontrol.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]