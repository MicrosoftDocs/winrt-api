---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.BindEndpointAsync(Windows.Networking.HostName,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction BindEndpointAsync(Windows.Networking.HostName localHostName, System.String localServiceName)
-->

# Windows.Networking.Sockets.DatagramSocket.BindEndpointAsync

## -description
Starts a bind operation on a [DatagramSocket](datagramsocket.md) to a local hostname and a local service name.

## -parameters
### -param localHostName
The local hostname or IP address on which to bind the [DatagramSocket](datagramsocket.md) object.

### -param localServiceName
The local service name or UDP port on which to bind the [DatagramSocket](datagramsocket.md) object.

## -returns
An asynchronous bind operation on a [DatagramSocket](datagramsocket.md) object.

## -remarks
The BindEndpointAsync method binds the [DatagramSocket](datagramsocket.md) to the local hostname or IP address specified in the *localHostName* parameter and the local service name or UDP port number address specified in the *localServiceName* parameter. If the *localHostName* parameter is null, the system will select the local IP address on which to bind. If the *localServiceName* parameter is an empty string, the system will select the local UDP port on which to bind.

Unless you've used the [DatagramSocketControl.MulticastOnly](/uwp/api/windows.networking.sockets.datagramsocketcontrol.multicastonly) property, the **BindEndpointAsync** method will fail if another app using UDP (for example, another [DatagramSocket](datagramsocket.md)) has already been bound to the local IP address and UDP port specified in the *localHostName* and *localServiceName* parameters.

Binding is essential for receiving data from any remote endpoint on a [DatagramSocket](datagramsocket.md), and is commonly done after a socket is created and the [MessageReceived](datagramsocket_messagereceived.md) event has been set. The [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md) or BindEndpointAsync method is used to bind a [DatagramSocket](datagramsocket.md) to a local service name or UDP port. The [ConnectAsync](datagramsocket_connectasync_13692504.md) methods will also result in a bind operation if the socket isn't already bound. Writing to a stream returned by one of the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync_1619245957.md) methods will also result in a bind operation.

The [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md) and BindEndpointAsync methods are not needed in the following cases:
+ The [DatagramSocket](datagramsocket.md) is used only to send data.
+ The [DatagramSocket](datagramsocket.md) is used to send data to and receive data from a single endpoint.


## -examples

## -see-also
[BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md), [DatagramSocketInformation](datagramsocketinformation.md), [MessageReceived](datagramsocket_messagereceived.md)

## -capabilities
internetClientServer, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone]
