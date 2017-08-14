---
-api-id: P:Windows.Networking.Sockets.StreamSocketListenerInformation.LocalPort
-api-type: winrt property
---

<!-- Property syntax
public string LocalPort { get; }
-->

# Windows.Networking.Sockets.StreamSocketListenerInformation.LocalPort

## -description
Get the local TCP port number associated with a [StreamSocketListener](streamsocketlistener.md) object.

## -property-value
The local TCP port number or service name.

## -remarks
The [LocalPort](streamsocketlistenerinformation_localport.md) property represents the local TCP port number bound to the [StreamSocketListener](streamsocketlistener.md) object.

An app can set the local service name or TCP port number by calling the [BindServiceNameAsync](streamsocketlistener_bindservicenameasync.md) or [BindEndpointAsync](streamsocketlistener_bindendpointasync.md) method on the [StreamSocketListener](streamsocketlistener.md). These methods will bind the [StreamSocketListener](streamsocketlistener.md) object to the specific local IP address and local UDP port number. After the bind completes, the [LocalPort](streamsocketinformation_localport.md) property contains the local TCP port number that the local service name resolved to.

The [BindEndpointAsync](streamsocketlistener_bindendpointasync.md) method will bind the socket to a specific IP address or hostname and a specific local TCP port number or service name .

The [BindServiceNameAsync](streamsocketlistener_bindservicenameasync.md) method will bind the socket to the specific TCP port number or service name. The system will determine the local IP address or hostname to associate with a [StreamSocketListener](streamsocketlistener.md) object.

After the initial bind operation completes, [LocalPort](streamsocketlistenerinformation_localport.md) is read only and cannot be changed by calling the [BindServiceNameAsync](streamsocketlistener_bindservicenameasync.md) or [BindEndpointAsync](streamsocketlistener_bindendpointasync.md) method again. The [LocalPort](streamsocketlistenerinformation_localport.md) property can be used at any time to get the local TCP port number associated with a [StreamSocketListener](streamsocketlistener.md) object.

## -examples

## -see-also
[How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [BindEndpointAsync](streamsocketlistener_bindendpointasync.md), [BindServiceNameAsync](streamsocketlistener_bindservicenameasync.md), [StreamSocketListener](streamsocketlistener.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
