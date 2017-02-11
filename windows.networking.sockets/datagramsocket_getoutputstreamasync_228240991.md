---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.GetOutputStreamAsync(Windows.Networking.EndpointPair)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IOutputStream> GetOutputStreamAsync(Windows.Networking.EndpointPair endpointPair)
-->

# Windows.Networking.Sockets.DatagramSocket.GetOutputStreamAsync

## -description
Starts an operation to get an [IOutputStream](../windows.storage.streams/ioutputstream.md) to a remote network destination specified by an [EndpointPair](../windows.networking/endpointpair.md) object that can then be used to send network data.

## -parameters
### -param endpointPair
An endpoint pair that represents the local hostname or local IP address, the local service name or local UDP port, the remote hostname or remote IP address, and the remote service name or remote UDP port.

## -returns
An [IOutputStream](../windows.storage.streams/ioutputstream.md) that represents the asynchronous operation.

## -remarks
The [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) method on a [DatagramSocket](datagramsocket.md) is used to start an operation to get an [IOutputStream](../windows.storage.streams/ioutputstream.md) to a remote network destination specified by an [EndpointPair](../windows.networking/endpointpair.md) object. The [IOutputStream](../windows.storage.streams/ioutputstream.md) can then be used to send data to the remote destination.

The [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) method will return an [IOutputStream](../windows.storage.streams/ioutputstream.md) when it completes successfully. Writing to that stream will send datagrams to the remote host and service name specified. The [IOutputStream](../windows.storage.streams/ioutputstream.md) will always send to the remote hostname and remote service name specified in the [ConnectAsync](datagramsocket_connectasync_1841953676.md) method.

The [RemoteHostName](../windows.networking/endpointpair_remotehostname.md) property of the [EndpointPair](../windows.networking/endpointpair.md) passed in the *endpointPair* parameter can contain either the hostname or IP address of the remote destination. The [RemoteServiceName](../windows.networking/endpointpair_remoteservicename.md) property of the [EndpointPair](../windows.networking/endpointpair.md) passed in the *endpointPair* parameter can contain either the service name or a UDP port of the remote destination. If the [RemoteHostName](../windows.networking/endpointpair_remotehostname.md) property contains a hostname, then the [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) method results in name resolution of the remote hostname. If the [RemoteServiceName](../windows.networking/endpointpair_remoteservicename.md) property contains a service name, then the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync_228240991.md) method results in resolution of the remote service name to a UDP port.

The [RemoteHostName](../windows.networking/endpointpair_remotehostname.md) and [RemoteServiceName](../windows.networking/endpointpair_remoteservicename.md) properties must be provided on the [EndpointPair](../windows.networking/endpointpair.md) object passed in the *endpointPair* parameter. If the [RemoteHostName](../windows.networking/endpointpair_remotehostname.md) is **null** or the [RemoteServiceName](../windows.networking/endpointpair_remoteservicename.md) is **null** or an empty string, an error will occur.

If the [EndpointPair](../windows.networking/endpointpair.md) object passed in the *endpointPair* parameter contains a null [LocalHostName](../windows.networking/endpointpair_localhostname.md) property, then the system will supply the local IP address that will be used. If the [EndpointPair](../windows.networking/endpointpair.md) object passed in the *endpointPair* parameter contains an empty string for the [LocalServiceName](../windows.networking/endpointpair_localservicename.md) property, then the system will supply the local UDP port that will be used.

There are two ways of using a [DatagramSocket](datagramsocket.md) to send UDP datagrams to a remote network destination:
+ Use one of the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods.
+ After a successful call to one of the [ConnectAsync](datagramsocket_connectasync.md) methods, pass the [OutputStream](datagramsocket_outputstream.md) property to a [DataWriter](../windows.storage.streams/datawriter.md) object and use methods on the [DataWriter](../windows.storage.streams/datawriter.md) object to send data.


The [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods allow an app to send UDP datagrams using a [DatagramSocket](datagramsocket.md) object to multiple network destinations. Each time the [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) method is called, the app can set different values for the **RemoteHostName** and **RemoteServiceName** members in the *endpointPair* parameter.

To receive data from any remote endpoint on the [DatagramSocket](datagramsocket.md) object, an app must assign the [MessageReceived ](datagramsocket_messagereceived.md) event to an event handler and then call either [BindEndpointAsync](datagramsocket_bindendpointasync.md) or [BindServiceNameAsync](datagramsocket_bindservicenameasync.md) method to bind the [DatagramSocket](datagramsocket.md) to a local service name or UDP port before calling the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync_228240991.md) method. The [MessageReceived](datagramsocket_messagereceived.md) event handler must be set before any bind or connect operation, otherwise an error will occur.

The typical order of operations is as follows:


1. Create the [DatagramSocket](datagramsocket.md).
1. Use the [Control](datagramsocket_control.md) property to retrieve a [DatagramSocketControl](datagramsocketcontrol.md) object and set any advanced controls. This step is not normally needed by most apps.
1. Assign the [MessageReceived](datagramsocket_messagereceived.md) event to an event handler.
1. Call the [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) method to get the [OutputStream](datagramsocket_outputstream.md) to send data to the remote endpoint. The [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) method will also bind the [DatagramSocket](datagramsocket.md) to a local service name or UDP port and a local hostname or IP address using the *endpointPair* parameter.
1. The [MessageReceived](datagramsocket_messagereceived.md) event handler will be invoked whenever a message from the remote endpoint arrives.
The [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods also differ from the [ConnectAsync](datagramsocket_connectasync.md) methods when an app uses the [BindEndpointAsync](datagramsocket_bindendpointasync.md) or [BindServiceNameAsync](datagramsocket_bindservicenameasync.md) method to bind a local service name or UDP port. With the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync.md) methods, the app will receive packets from any remote destination sent to the local service name or UDP port. With the [ConnectAsync](datagramsocket_connectasync.md) methods, the app will only receive packets from the remote destination passed as parameters to the [ConnectAsync](datagramsocket_connectasync.md) methods.

The [BindServiceNameAsync(String, NetworkAdapter)](datagramsocket_bindservicenameasync_440542334.md) method can be used to specify a network adapter before calling the [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) method. The specified adapter is used for the bind operation. If after calling [BindServiceNameAsync(String, NetworkAdapter)](datagramsocket_bindservicenameasync_440542334.md) and the *endpointPair* parameter passed to [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) specifies a [LocalHostName](../windows.networking/endpointpair_localhostname.md), the [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) method will fail.

## -examples

## -see-also
[GetOutputStreamAsync(HostName, String)](datagramsocket_getoutputstreamasync_1619245957.md), [EndpointPair](../windows.networking/endpointpair.md), [IOutputStream](../windows.storage.streams/ioutputstream.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]