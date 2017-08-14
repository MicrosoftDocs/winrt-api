---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.GetEndpointPairsAsync(Windows.Networking.HostName,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Networking.EndpointPair>> GetEndpointPairsAsync(Windows.Networking.HostName remoteHostName, System.String remoteServiceName)
-->

# Windows.Networking.Sockets.DatagramSocket.GetEndpointPairsAsync

## -description
Gets a list of [EndpointPair](../windows.networking/endpointpair.md) objects based on a remote hostname and remote service name that can be used to send datagrams to a remote network destination.

## -parameters
### -param remoteHostName
The remote hostname or IP address.

### -param remoteServiceName
The remote service name or UDP port.

## -returns
A list of [EndpointPair](../windows.networking/endpointpair.md) objects.

## -remarks
The [GetEndpointPairsAsync](datagramsocket_getendpointpairsasync_1796487528.md) method gets a list of possible [EndpointPair](../windows.networking/endpointpair.md) objects that can be used by a [DatagramSocket](datagramsocket.md) to send datagrams to a remote network destination. The returned list is sorted so that the address pairs that are best suited for communication between two peers occur earlier in the list.

A [DatagramSocket](datagramsocket.md) can use the list returned by the [GetEndpointPairsAsync](datagramsocket_getendpointpairsasync_1796487528.md) method to try and bind or connect to each [EndpointPair](../windows.networking/endpointpair.md) object until a connection can be made. An [EndpointPair](../windows.networking/endpointpair.md) object from the list would be used with the [ConnectAsync(EndpointPair)](datagramsocket_connectasync_13692504.md) methods

## -examples

## -see-also
[ConnectAsync(EndpointPair)](datagramsocket_connectasync_13692504.md), [GetEndpointPairsAsync(HostName, String, HostNameSortOptions)](datagramsocket_getendpointpairsasync_903639760.md), [HostName](../windows.networking/hostname.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
