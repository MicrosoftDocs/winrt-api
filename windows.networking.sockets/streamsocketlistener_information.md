---
-api-id: P:Windows.Networking.Sockets.StreamSocketListener.Information
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.StreamSocketListenerInformation Information { get; }
-->

# Windows.Networking.Sockets.StreamSocketListener.Information

## -description
Gets socket information for the [StreamSocketListener](streamsocketlistener.md) object.

## -property-value
Socket information for the [StreamSocketListener](streamsocketlistener.md) object.

## -remarks
The [Information](datagramsocket_bindendpointasync.md) property gets the [StreamSocketListenerInformation](streamsocketlistenerinformation.md) instance associated with a [StreamSocketListener](streamsocketlistener.md) object. The [Information](datagramsocket_bindendpointasync.md) instance can then be used to get information used by the [StreamSocketListener](streamsocketlistener.md). The only information data supported is the [LocalPort](streamsocketlistenerinformation_localport.md) property which represents the local TCP port number bound to the [StreamSocketListener](streamsocketlistener.md) object.

## -examples

## -see-also
[StreamSocketListenerInformation](streamsocketlistenerinformation.md), [StreamSocketListenerInformation.LocalPort](streamsocketlistenerinformation_localport.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
