---
-api-id: P:Windows.Networking.Sockets.StreamSocketListener.Control
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.StreamSocketListenerControl Control { get; }
-->

# Windows.Networking.Sockets.StreamSocketListener.Control

## -description
Gets socket control data on a [StreamSocketListener](streamsocketlistener.md) object.

## -property-value
Socket control data on a [StreamSocketListener](streamsocketlistener.md) object.

## -remarks
The [Control](streamsocketlistener_control.md) property gets the [StreamSocketListenerControl](streamsocketlistenercontrol.md) instance associated with a [StreamSocketListener](streamsocketlistener.md) object.

A [StreamSocketListenerControl](streamsocketlistenercontrol.md) object is automatically created with the parent [StreamSocketListener](streamsocketlistener.md) object. The [StreamSocketListenerControl](streamsocketlistenercontrol.md) instance can then be used to get or set control data used by the [StreamSocketListener](streamsocketlistener.md) object. These properties on the [StreamSocketControl](streamsocketcontrol.md) instance include the following:


+ [QualityOfService](streamsocketlistenercontrol_qualityofservice.md) - The quality of service to be set on a [StreamSocket](streamsocket.md) object created when a connection is received by the [StreamSocketListener](streamsocketlistener.md) object.


Any changes to the [StreamSocketListenerControl](streamsocketlistenercontrol.md) property values must be set before the [StreamSocketListener](streamsocketlistener.md) is bound. So changes to the [QualityOfService](streamsocketlistenercontrol_qualityofservice.md) property must be set before the [BindServiceNameAsync](streamsocketlistener_bindservicenameasync.md) or [BindEndpointAsync](streamsocketlistener_bindendpointasync.md) method is called on the [StreamSocketListener](streamsocketlistener.md).

## -examples

## -see-also
[StreamSocket](streamsocket.md), [StreamSocketListenerControl](streamsocketlistenercontrol.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]