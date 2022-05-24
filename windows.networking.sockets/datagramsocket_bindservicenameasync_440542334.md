---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.BindServiceNameAsync(System.String,Windows.Networking.Connectivity.NetworkAdapter)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction BindServiceNameAsync(System.String localServiceName, Windows.Networking.Connectivity.NetworkAdapter adapter)
-->

# Windows.Networking.Sockets.DatagramSocket.BindServiceNameAsync

## -description
Starts a bind operation on a [DatagramSocket](datagramsocket.md) to a local service name and specific network interface.

## -parameters
### -param localServiceName
The local service name or UDP port on which to bind the [DatagramSocket](datagramsocket.md) object.

### -param adapter
The network adapter on which to bind the [DatagramSocket](datagramsocket.md) object.

## -returns
An asynchronous bind operation on a [DatagramSocket](datagramsocket.md) object.

## -remarks
The [BindServiceNameAsync(String, NetworkAdapter) method binds to a network interface specified in the *adapter* parameter and the local service name or UDP port specified in the *localServiceName* parameter on the local computer. If the *localServiceName* parameter is an empty string, the system will select the local UDP port on which to bind. If the *adapter* parameter is null, an error will occur.

The name resolution mechanism used by the [BindServiceNameAsync(String, NetworkAdapter) method is limited to the specified interface for the domain name system (DNS) namespace.

Unless you've used the [DatagramSocketControl.MulticastOnly](/uwp/api/windows.networking.sockets.datagramsocketcontrol.multicastonly) property, the BindServiceNameAsync method will fail if another app using UDP (another [DatagramSocket](datagramsocket.md), for example) has already been bound to the local UDP port specified in the *localServiceName* parameter on the same network interface.

Binding is essential for receiving data from any remote endpoint on a [DatagramSocket](datagramsocket.md), and is commonly done after a socket is created and the [MessageReceived](datagramsocket_messagereceived.md) event has been set. The BindServiceNameAsync or [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) method is used to bind a [DatagramSocket](datagramsocket.md) to a local service name or UDP port. The [ConnectAsync](datagramsocket_connectasync_13692504.md) methods will also result in a bind operation, but can't be limited to a specific network adapter. Writing to a stream returned by one of the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync_1619245957.md) methods will also result in a bind operation if the socket isn't already bound, but can't be limited to a specific network adapter.

The BindServiceNameAsync and [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) methods are not needed in the following cases:
+ The [DatagramSocket](datagramsocket.md) is used only to send data.
+ The [DatagramSocket](datagramsocket.md) is used to send data to and receive data from a single endpoint.


If the [BindServiceNameAsync(String, NetworkAdapter) method is used, the bind operation will limit incoming and outgoing multicast and unicast packets to the specified adapter.

Using the specified network adapter is on a best-effort basis. Among other configuration, systems with adapters configured in weak-host or forwarding modes may use an adapter other than the specified adapter.

## -examples

## -see-also
[BindServiceNameAsync(String)](datagramsocket_bindservicenameasync_673478814.md), [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md), [DatagramSocketInformation](datagramsocketinformation.md)
