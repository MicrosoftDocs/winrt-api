---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.ConnectAsync(Windows.Networking.HostName,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ConnectAsync(Windows.Networking.HostName remoteHostName, System.String remoteServiceName)
-->

# Windows.Networking.Sockets.DatagramSocket.ConnectAsync

## -description
Starts a connect operation on a [DatagramSocket](datagramsocket.md) to a remote destination specified by a remote hostname and a remote service name.

## -parameters
### -param remoteHostName
The hostname or IP address of the remote network destination.

### -param remoteServiceName
The service name or UDP port of the remote network destination.

## -returns
An asynchronous connect operation on a [DatagramSocket](datagramsocket.md) object.

## -remarks
The **ConnectAsync** method on a [DatagramSocket](datagramsocket.md) is used to define the remote hostname or remote IP address and the remote service name or UDP port number where datagrams will be sent when using the [OutputStream](datagramsocket_outputstream.md) property. This method also restricts the remote IP addresses of packets that will be accepted to the *remoteHostName* parameter. Only incoming packets that match the *remoteHostName* parameter will trigger the [MessageReceived](datagramsocket_messagereceived.md) event on the [DatagramSocket](datagramsocket.md).

The app can later send network data to the remote network destination by calling the [WriteAsync](../windows.storage.streams/ioutputstream_writeasync.md) method on the [OutputStream](datagramsocket_outputstream.md) property of the [DatagramSocket](datagramsocket.md) or by passing the [OutputStream](datagramsocket_outputstream.md) to a [DataWriter](../windows.storage.streams/datawriter.md) object and calling methods of the [DataWriter](../windows.storage.streams/datawriter.md) object.

The *remoteHostName* parameter can contain either the hostname or IP address of the remote destination. The *remoteServiceName* parameter can contain either the service name or an UDP port of the remote destination. If the *remoteHostName* parameter contains a hostname, then the **ConnectAsync** method will resolve the remote hostname to an IP address. If the *remoteServiceName* parameter contains a service name, then the **ConnectAsync** method will resolve the remote service name to a UDP port number.

The service name strings that are recognized by default by the *remoteServiceName* parameter are those service names listed in the *%windir%\System32\drivers\etc\services* file on the local computer. Any other service name value results in a name service query to domain name system (DNS) servers for DNS SRV records.

The *remoteHostName* and *remoteServiceName* parameters must be provided. If the *remoteHostName* is null or the *remoteServiceName* is null or an empty string, an error will occur.

There are two ways of using a [DatagramSocket](datagramsocket.md) to send UDP datagrams to a remote network destination:
+ Use one of the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods.
+ After a successful call to the **ConnectAsync** method use the [OutputStream](datagramsocket_outputstream.md) property.


The [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods allow an app to send UDP datagrams using a [DatagramSocket](datagramsocket.md) object to multiple network destinations. Each time the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync_1619245957.md) method is called, the app can set different values for the *remoteHostName* and *remoteServiceName* parameters.

To receive data from a single endpoint on the [DatagramSocket](datagramsocket.md) object, an app must assign the [MessageReceived ](datagramsocket_messagereceived.md) event to an event handler and then call the **ConnectAsync** method with the *remoteHostName* and *remoteServiceName* parameters set to the remote endpoint information. The [MessageReceived](datagramsocket_messagereceived.md) event handler must be set before any bind or connect operation, otherwise an error will occur.

The typical order of operations is as follows:


1. Create the [DatagramSocket](datagramsocket.md).
1. Use the [Control](datagramsocket_control.md) property on the [DatagramSocket](datagramsocket.md) to retrieve a [DatagramSocketControl](datagramsocketcontrol.md) object and set any advanced controls. This step is not normally needed by most apps.
1. Assign the [MessageReceived ](datagramsocket_messagereceived.md) event to an event handler.
1. Call the **ConnectAsync** method to connect to the remote endpoint.
1. Use the [OutputStream](datagramsocket_outputstream.md) property on the [DatagramSocket](datagramsocket.md) with a [DataWriter](../windows.storage.streams/datawriter.md) object to send messages to the remote endpoint.
1. The [MessageReceived](datagramsocket_messagereceived.md) event handler will be invoked whenever a message from the remote endpoint arrives.
The [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods also differ from the [ConnectAsync](datagramsocket_connectasync.md) method when an app uses the [BindEndpointAsync](datagramsocket_bindendpointasync.md) or [BindServiceNameAsync](datagramsocket_bindservicenameasync.md) method to bind to a local service name or UDP port. With the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods, the app will receive packets from any remote destination sent to the local service name or UDP port. With the [ConnectAsync](datagramsocket_connectasync.md) methods, the app will only receive packets from the remote destination passed as parameters to the [ConnectAsync](datagramsocket_connectasync.md) methods.

The **ConnectAsync** method only works for unicast IP addresses. When trying to call the **ConnectAsync** method with a multicast IP address for the *remoteHostName* parameter, the asynchronous operation will complete with an error. When passing the error to the [SocketError.GetStatus](socketerror_getstatus.md) method, the value returned will be [SocketErrorStatus.HostNotFound](socketerrorstatus.md).

Using **ConnectAsync** with a broadcast IP address such as 255.255.255.255 will connect, but will broadcast only through the first network adapter found. To broadcast on all available adapters, use [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md).

## -examples

## -see-also
[ConnectAsync(EndpointPair)](datagramsocket_connectasync_13692504.md), [HostName](../windows.networking/hostname.md), [OutputStream](datagramsocket_outputstream.md), [DataWriter](../windows.storage.streams/datawriter.md), [IOutputStream](../windows.storage.streams/ioutputstream.md)

## -capabilities
internetClientServer, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone]
