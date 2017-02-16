---
-api-id: M:Windows.Networking.Sockets.StreamSocket.GetEndpointPairsAsync(Windows.Networking.HostName,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Networking.EndpointPair>> GetEndpointPairsAsync(Windows.Networking.HostName remoteHostName, System.String remoteServiceName)
-->

# Windows.Networking.Sockets.StreamSocket.GetEndpointPairsAsync

## -description
Gets a list of [EndpointPair](../windows.networking/endpointpair.md) objects based on a remote hostname and remote service name that can be used to send TCP packets to a remote network destination.

## -parameters
### -param remoteHostName
The hostname of a service. The service might actually be hosted on multiple services, so that a DNS lookup returns multiple IP addresses for the various servers. This method returns one endpoint pair for each of the servers found by a DNS lookup.

### -param remoteServiceName
The name or port number of a remote service. Note that different servers might support the named service on different physical ports, so not all of the returned endpoints will use the same service port number.

## -returns
An asynchronous lookup operation. On successful completion, the returned list contains one [EndpointPair](../windows.networking/endpointpair.md) for each remote host found, with one end point being one of the remote hosts and the other being the local host.

## -remarks
This method gets a list of possible [EndpointPair](../windows.networking/endpointpair.md) objects that can be used by a [StreamSocket](streamsocket.md) to send data to a remote network destination using TCP. The returned list is sorted so that the address pairs that are best suited for communication between two peers occur earlier in the list.

A [StreamSocket](streamsocket.md) can use the list returned by this method to try and bind or connect to each [EndpointPair](../windows.networking/endpointpair.md) object until a connection can be made. An [EndpointPair](../windows.networking/endpointpair.md) object from the list would be used with the [ConnectAsync(EndpointPair)](streamsocket_connectasync_13692504.md) methods

## -examples

## -see-also
[GetEndpointPairsAsync(HostName, String, HostNameSortOptions)](streamsocket_getendpointpairsasync_903639760.md)