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
The LocalPort property represents the local TCP port number bound to the [StreamSocketListener](streamsocketlistener.md) object.

An app can set the local service name or TCP port number by calling the [BindServiceNameAsync](streamsocketlistener_bindservicenameasync_1713574846.md) or [BindEndpointAsync](streamsocketlistener_bindendpointasync_1396029045.md) method on the [StreamSocketListener](streamsocketlistener.md). These methods will bind the [StreamSocketListener](streamsocketlistener.md) object to the specific local IP address and local UDP port number. After the bind completes, the [LocalPort](streamsocketinformation_localport.md) property contains the local TCP port number that the local service name resolved to.

The [BindEndpointAsync](streamsocketlistener_bindendpointasync_1396029045.md) method will bind the socket to a specific IP address or hostname and a specific local TCP port number or service name .

The [BindServiceNameAsync](streamsocketlistener_bindservicenameasync_1713574846.md) method will bind the socket to the specific TCP port number or service name. The system will determine the local IP address or hostname to associate with a [StreamSocketListener](streamsocketlistener.md) object.

After the initial bind operation completes, LocalPort is read only and cannot be changed by calling the [BindServiceNameAsync](streamsocketlistener_bindservicenameasync_1713574846.md) or [BindEndpointAsync](streamsocketlistener_bindendpointasync_1396029045.md) method again. The LocalPort property can be used at any time to get the local TCP port number associated with a [StreamSocketListener](streamsocketlistener.md) object.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [BindEndpointAsync](streamsocketlistener_bindendpointasync_1396029045.md), [BindServiceNameAsync](streamsocketlistener_bindservicenameasync_1713574846.md), [StreamSocketListener](streamsocketlistener.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
