---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.GetOutputStreamAsync(Windows.Networking.HostName,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IOutputStream> GetOutputStreamAsync(Windows.Networking.HostName remoteHostName, System.String remoteServiceName)
-->

# Windows.Networking.Sockets.DatagramSocket.GetOutputStreamAsync

## -description
Starts an operation to get an [IOutputStream](../windows.storage.streams/ioutputstream.md) to a remote destination specified by a remote hostname and a remote service name that can then be used to send network data.

## -parameters
### -param remoteHostName
The remote hostname or remote IP address.

### -param remoteServiceName
The remote service name or remote UDP port.

## -returns
An [IOutputStream](../windows.storage.streams/ioutputstream.md) that representing the asynchronous operation.

## -remarks
The [GetOutputStreamAsync(HostName, String) method on a [DatagramSocket](datagramsocket.md) is used to start an operation to get an [IOutputStream](../windows.storage.streams/ioutputstream.md) to a remote network destination specified by a remote hostname and a remote service name. The [IOutputStream](../windows.storage.streams/ioutputstream.md) can then be used to send data to the remote destination.

The [GetOutputStreamAsync(HostName, String) method will return an [IOutputStream](../windows.storage.streams/ioutputstream.md) when it completes successfully. Writing to that stream will send datagrams to the remote host and service name specified. The [IOutputStream](../windows.storage.streams/ioutputstream.md) will always send to the remote hostname and remote service name specified in the [ConnectAsync](datagramsocket_connectasync_1841953676.md) method.

The *remoteHostName* parameter can contain either the hostname or IP address of the remote destination. The *remoteServiceName* parameter can contain either the service name or a UDP port of the remote destination. If the *remoteHostName* parameter contains a hostname, then the [GetOutputStreamAsync(HostName, String) method results in name resolution of the remote hostname. If the *remoteServiceName* parameter contains a service name, then the [GetOutputStreamAsync(HostName, String) method results in resolution of the remote service name to a UDP port.

The *remoteHostName* and *remoteServiceName* parameters must be provided. If the *remoteHostName* parameter is null or the *remoteServiceName* parameter is null or an empty string, an error will occur.

There are two ways of using a [DatagramSocket](datagramsocket.md) to send UDP datagrams to a remote network destination:
+ Use one of the GetOutputStreamAsync methods.
+ After a successful call to one of the [ConnectAsync](datagramsocket_connectasync_13692504.md) methods, pass the [OutputStream](datagramsocket_outputstream.md) property to a [DataWriter](../windows.storage.streams/datawriter.md) object and use methods on the [DataWriter](../windows.storage.streams/datawriter.md) object to send data.


The GetOutputStreamAsync methods allow an app to send UDP datagrams using a [DatagramSocket](datagramsocket.md) object to multiple network destinations. Each time the [GetOutputStreamAsync(HostName, String) method is called, the app can set different values for the *remoteHostName* and *remoteServiceName* parameters.

The [ConnectAsync](datagramsocket_connectasync_13692504.md) methods allow an app to send UDP datagrams using a [DatagramSocket](datagramsocket.md) object to a single network destination.

To receive data from any remote endpoint on the [DatagramSocket](datagramsocket.md) object, an app must assign the [MessageReceived ](datagramsocket_messagereceived.md) event to an event handler and then call either [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) or [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md) method to bind the [DatagramSocket](datagramsocket.md) to a local service name or UDP port before calling the GetOutputStreamAsync method. The [MessageReceived](datagramsocket_messagereceived.md) event handler must be set before any bind or connect operation, otherwise an error will occur.

The typical order of operations is as follows:


1. Create the [DatagramSocket](datagramsocket.md).
1. Use the [Control](datagramsocket_control.md) property to retrieve a [DatagramSocketControl](datagramsocketcontrol.md) object and set any advanced controls. This step is not normally needed by most apps.
1. Assign the [MessageReceived](datagramsocket_messagereceived.md) event to an event handler.
1. Bind the [DatagramSocket](datagramsocket.md) to a local service name or UDP port.
1. The [MessageReceived](datagramsocket_messagereceived.md) event handler will be invoked whenever a message from the remote endpoint arrives.
1. Call the GetOutputStreamAsync method to get the [OutputStream](datagramsocket_outputstream.md) to send data to the remote endpoint. You can use the information contained in the [DatagramSocketMessageReceivedEventArgs](datagramsocketmessagereceivedeventargs.md) from the [MessageReceived](datagramsocket_messagereceived.md) event handler to establish an [OutputStream](datagramsocket_outputstream.md) with the remote endpoint that authored a specific incoming message.
The GetOutputStreamAsync methods also differ from the [ConnectAsync](datagramsocket_connectasync_13692504.md) method when an app uses the [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) or [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md) method to bind to a local service name or UDP port. With the GetOutputStreamAsync methods, the app will receive packets from any remote destination sent to the local service name or UDP port. With the [ConnectAsync](datagramsocket_connectasync_13692504.md) methods, the app will only receive packets from the remote destination passed as parameters to the [ConnectAsync](datagramsocket_connectasync_13692504.md) methods.

## -examples

## -see-also
[HostName](../windows.networking/hostname.md), [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md), [IOutputStream](../windows.storage.streams/ioutputstream.md), [DatagramSocket sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DatagramSocket)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
