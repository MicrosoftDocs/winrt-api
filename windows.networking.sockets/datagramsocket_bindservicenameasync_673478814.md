---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.BindServiceNameAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction BindServiceNameAsync(System.String localServiceName)
-->

# Windows.Networking.Sockets.DatagramSocket.BindServiceNameAsync

## -description
Starts a bind operation on a [DatagramSocket](datagramsocket.md) to a local service name.

## -parameters
### -param localServiceName
The local service name or UDP port on which to bind the [DatagramSocket](datagramsocket.md) object.

## -returns
An asynchronous bind operation on a [DatagramSocket](datagramsocket.md) object.

## -remarks
The [BindServiceNameAsync](datagramsocket_bindservicenameasync.md) method binds to the local IP addresses of all network interfaces on the local computer on the local service name or UDP port specified in the *localServiceName* parameter. If the *localServiceName* parameter is an empty string, the system will select the local UDP port on which to bind.

The [BindServiceNameAsync](datagramsocket_bindservicenameasync.md) method will fail if another app using UDP (another [DatagramSocket](datagramsocket.md), for example) has already been bound to the local UDP port specified in the *localServiceName* parameter.

Binding is essential for receiving data from any remote endpoint on a [DatagramSocket](datagramsocket.md), and is commonly done after a socket is created and the [MessageReceived](datagramsocket_messagereceived.md) event has been set. The [BindServiceNameAsync](datagramsocket_bindservicenameasync.md) or [BindEndpointAsync](datagramsocket_bindendpointasync.md) method is used to bind a [DatagramSocket](datagramsocket.md) to a local service name or UDP port. The [ConnectAsync](datagramsocket_connectasync.md) methods will also result in a bind operation. Writing to a stream returned by one of the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods will also result in a bind operation if the socket isn't already bound.

The [BindServiceNameAsync](datagramsocket_bindservicenameasync.md) and [BindEndpointAsync](datagramsocket_bindendpointasync.md) methods are not needed in the following cases:
+ The [DatagramSocket](datagramsocket.md) is used only to send data.
+ The [DatagramSocket](datagramsocket.md) is used to send data to and receive data from a single endpoint.


## -examples

## -see-also
[BindEndpointAsync](datagramsocket_bindendpointasync.md), [BindServiceNameAsync(String, NetworkAdapter)](datagramsocket_bindservicenameasync_440542334.md), [DatagramSocketInformation](datagramsocketinformation.md)

## -capabilities
internetClientServer, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone]