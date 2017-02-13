---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.ConnectAsync(Windows.Networking.EndpointPair)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ConnectAsync(Windows.Networking.EndpointPair endpointPair)
-->

# Windows.Networking.Sockets.DatagramSocket.ConnectAsync

## -description
Starts a connect operation on a [DatagramSocket](datagramsocket.md) to a remote network destination specified as an [EndpointPair](../windows.networking/endpointpair.md) object.

## -parameters
### -param endpointPair
An [EndpointPair](../windows.networking/endpointpair.md) object that specifies local hostname or IP address, local service name or UDP port, the remote hostname or remote IP address, and the remote service name or remote UDP port for the remote network destination.

## -returns
An asynchronous connect operation on a [DatagramSocket](datagramsocket.md) object.

## -remarks
This [ConnectAsync(EndPointPair)](datagramsocket_connectasync_13692504.md) method on a [DatagramSocket](datagramsocket.md) is used to define the local and remote endpoint where datagrams will be sent when using the [OutputStream](datagramsocket_outputstream.md) property. This method also restricts remote IP addresses of packets that will be accepted to the remote hostname in the *endpointPair* parameter. Only incoming packets that match the remote endpoint in the *endpointPair* parameter will trigger the [MessageReceived](datagramsocket_messagereceived.md) event on the [DatagramSocket](datagramsocket.md).

The app can later send network data to the remote network destination by calling the [WriteAsync](../windows.storage.streams/ioutputstream_writeasync.md) method on the [OutputStream](datagramsocket_outputstream.md) property of the [DatagramSocket](datagramsocket.md) or by passing the [OutputStream](datagramsocket_outputstream.md) to a [DataWriter](../windows.storage.streams/datawriter.md) object and calling methods of the [DataWriter](../windows.storage.streams/datawriter.md) object.

The [RemoteHostName](../windows.networking/endpointpair_remotehostname.md) property of the [EndpointPair](../windows.networking/endpointpair.md) passed in the *endpointPair* parameter can contain either the hostname or IP address of the remote destination. The [RemoteServiceName](../windows.networking/endpointpair_remoteservicename.md) property of the [EndpointPair](../windows.networking/endpointpair.md) passed in the *endpointPair* parameter can contain either the service name or a UDP port of the remote destination. If the [RemoteHostName](../windows.networking/endpointpair_remotehostname.md) property contains a hostname, then the [ConnectAsync(EndPointPair)](datagramsocket_connectasync_13692504.md) method will resolve the remote hostname to an IP address. If the [RemoteServiceName](../windows.networking/endpointpair_remoteservicename.md) property of the [EndpointPair](../windows.networking/endpointpair.md) contains a service name, then the [ConnectAsync(EndPointPair)](datagramsocket_connectasync_13692504.md) method will resolve the remote service name to a UDP port number.

The service name strings that are recognized by default are those service names listed in the *%windir%\System32\drivers\etc\services* file on the local computer. Any other service name value results in a name service query to domain name system (DNS) servers for DNS SRV records.

The [RemoteHostName](../windows.networking/endpointpair_remotehostname.md) and [RemoteServiceName](../windows.networking/endpointpair_remoteservicename.md) properties must be provided. If the [RemoteHostName](../windows.networking/endpointpair_remotehostname.md) is null or if the [RemoteServiceName](../windows.networking/endpointpair_remoteservicename.md) is null or an empty string, an error will occur.

If the [EndpointPair](../windows.networking/endpointpair.md) object passed in the *endpointPair* parameter contains a null [LocalHostName](../windows.networking/endpointpair_localhostname.md) property, then the system will supply the local IP address that will be used. If the [EndpointPair](../windows.networking/endpointpair.md) object passed in the *endpointPair* parameter contains an empty [LocalServiceName](../windows.networking/endpointpair_localservicename.md) property, then the system will supply the local UDP port that will be used.

There are two ways of using a [DatagramSocket](datagramsocket.md) to send UDP datagrams to a remote network destination:
+ Using one of the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods.
+ After a successful call to the [ConnectAsync](datagramsocket_connectasync_13692504.md) method using the [OutputStream](datagramsocket_outputstream.md) property.


The [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods allow an app to send UDP datagrams using a [DatagramSocket](datagramsocket.md) object to multiple network destinations. Each time the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync_1619245957.md) method is called, the app can set different values for the *remoteHostName* and *remoteServiceName* parameters.

To receive data from a single remote endpoint on the [DatagramSocket](datagramsocket.md) object, an app must assign the [MessageReceived ](datagramsocket_messagereceived.md) event to an event handler and then call the [ConnectAsync(EndPointPair)](datagramsocket_connectasync_13692504.md) method with the *endpointPair* parameter set to the remote endpoint information. The [MessageReceived](datagramsocket_messagereceived.md) event handler must be set before any bind or connect operation, otherwise an error will occur.

The typical order of operations is as follows:


+ Create the [DatagramSocket](datagramsocket.md).
+ Use the [Control](datagramsocket_control.md) property on the [DatagramSocket](datagramsocket.md) to retrieve a [DatagramSocketControl](datagramsocketcontrol.md) object and set any advanced controls. This step is not normally needed by most apps.
+ Assign the [MessageReceived ](datagramsocket_messagereceived.md) event to an event handler.
+ Call the [ConnectAsync](datagramsocket_connectasync_1841953676.md) method to connect to the remote endpoint.
+ Use the [OutputStream](datagramsocket_outputstream.md) property on the [DatagramSocket](datagramsocket.md) with a [DataWriter](../windows.storage.streams/datawriter.md) object to send messages to the remote endpoint.
+ The [MessageReceived](datagramsocket_messagereceived.md) event handler will be invoked whenever a message from the remote endpoint arrives.
The [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods also differ from the [ConnectAsync](datagramsocket_connectasync.md) method when an app uses the [BindEndpointAsync](datagramsocket_bindendpointasync.md) or [BindServiceNameAsync](datagramsocket_bindservicenameasync.md) method to bind to a local service name or UDP port. With the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods, the app will receive packets from any remote destination sent to the local service name or UDP port. With the [ConnectAsync](datagramsocket_connectasync.md) methods, the app will only receive packets from the remote destination passed as parameters to the [ConnectAsync](datagramsocket_connectasync.md) methods.

The [BindServiceNameAsync(String, NetworkAdapter)](datagramsocket_bindservicenameasync_440542334.md) method can be used to specify a network adapter before calling the [ConnectAsync(EndPointPair)](datagramsocket_connectasync_13692504.md) method. The specified adapter is used for the bind operation. If after calling [BindServiceNameAsync(String, NetworkAdapter)](datagramsocket_bindservicenameasync_440542334.md) method and the *endpointPair* parameter passed to [ConnectAsync(EndPointPair)](datagramsocket_connectasync_13692504.md) specifies a [LocalHostName](../windows.networking/endpointpair_localhostname.md), the [ConnectAsync(EndPointPair)](datagramsocket_connectasync_13692504.md) method will fail.

The [ConnectAsync](datagramsocket_connectasync_13692504.md) method only works for unicast IP addresses. When trying to call the [ConnectAsync](datagramsocket_connectasync_13692504.md) method with a multicast IP address in the remote IP address set in the *endpointPair* parameter, the asynchronous operation will complete with an error. When passing the error to the [SocketError.GetStatus](socketerror_getstatus.md) method, the value returned will be [SocketErrorStatus.HostNotFound](socketerrorstatus.md).

## -examples

## -see-also
[ConnectAsync(HostName, String)](datagramsocket_connectasync_1841953676.md), [EndpointPair](../windows.networking/endpointpair.md), [OutputStream](datagramsocket_outputstream.md), [DataWriter](../windows.storage.streams/datawriter.md), [IOutputStream](../windows.storage.streams/ioutputstream.md)

## -capabilities
internetClientServer, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone]