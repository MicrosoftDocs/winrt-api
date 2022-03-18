---
-api-id: T:Windows.Networking.Sockets.DatagramSocket
-api-type: winrt class
---

<!-- Class syntax.
public class DatagramSocket : Windows.Foundation.IClosable, Windows.Networking.Sockets.IDatagramSocket, Windows.Networking.Sockets.IDatagramSocket2, Windows.Networking.Sockets.IDatagramSocket3
-->

# Windows.Networking.Sockets.DatagramSocket

## -description

Supports network communication using a UDP datagram socket.

For a code example, see [Sockets](/windows/uwp/networking/sockets).

## -remarks

The DatagramSocket class supports network communication using a UDP datagram socket. The DatagramSocket object can be used for client apps that send UDP packets or for server apps that listen for incoming UDP data.

Several steps are needed to send or receive data using a DatagramSocket object. Your app first assigns the [MessageReceived](datagramsocket_messagereceived.md) event to an event handler. To listen for incoming packets from a remote endpoint (a server scenario, for example), your app calls either the [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) or [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md) method to bind the DatagramSocket to a local service name or UDP port. However when your app needs to communicate with a single remote endpoint (client scenario, for example), your app calls the [ConnectAsync](datagramsocket_connectasync_1841953676.md) method. The [MessageReceived](datagramsocket_messagereceived.md) event handler must be set before any bind or connect operation, otherwise an error will occur.

The typical order of operations is as follows:

1. Create the DatagramSocket.
1. Use the [Control](datagramsocket_control.md) property to retrieve a [DatagramSocketControl](datagramsocketcontrol.md) object and set any advanced controls. This step is not normally needed by most apps.
1. Assign the [MessageReceived](datagramsocket_messagereceived.md) event to an event handler.
1. To listen for incoming packets from any remote endpoint (server scenario, for example), call the [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) or [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md) method to bind the DatagramSocket to a local service name or UDP port.
1. To communicate with a single remote endpoint (client scenario, for example), call the [ConnectAsync](datagramsocket_connectasync_1841953676.md) method to bind the DatagramSocket to a specific remote endpoint.
1. The [MessageReceived](datagramsocket_messagereceived.md) event handler will be invoked whenever a message from the remote endpoint arrives.
This class can also be used to join a multicast group and send UDP packets to the multicast group. For more information, see the [JoinMulticastGroup](datagramsocket_joinmulticastgroup_1508568147.md) method.

### Handling exceptions

You must write code to handle exceptions when you call asynchronous methods on the DatagramSocket class. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime.

The [Windows.Networking.Sockets](windows_networking_sockets.md) namespace has a convenient helper method and enumeration for handling errors when using sockets. This can be useful for handling specific network exceptions differently in your app. An app can also use the **HRESULT** from the exception on parameter validation errors to learn more detailed information on the error that caused the exception.

For more information on possible exceptions and how to handle exceptions, see [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)).

### Using DatagramSocket with Wi-Fi Direct

Your app can use a DatagramSocket for network data transfers between devices that use Wi-Fi Direct using classes in the [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) namespace. The [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md) class can be used to locate other devices that have a Wi-Fi Direct (WFD) capable device. The [WiFiDirectDevice.GetDeviceSelector](../windows.devices.wifidirect/wifidirectdevice_getdeviceselector_185243134.md) method gets the device identifier for a nearby WFD device. Once you have a reference to a nearby WFD device, you can call the [WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs_1958888015.md) method to get an [EndpointPair](../windows.networking/endpointpair.md) object. Methods on the DatagramSocket class can be used to send and receive data to the [EndpointPair](../windows.networking/endpointpair.md) object. For more information, see [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) and [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md).

### Using DatagramSocket on Windows Server 2012

On Windows Server 2012 and Windows Server 2012 R2, the *Windows.Networking.dll* that implements most of the classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail to load unless the Media Foundation feature is enabled. As a result, apps that use DatagramSocket and related socket classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail if the Media Foundation feature is disabled. Windows Server 2012 or Windows Server 2012 R2 installs with the Media Foundation feature disabled.

The Media Foundation feature can be enabled on Windows Server 2012 or Windows Server 2012 R2 using Server Manager or by entering the following text in a command prompt or a script:

`dism /online /enable-feature /featurename:ServerMediaFoundation `After the Media Foundation feature is enabled, the user is prompted to restart. Once the computer is restarted, classes for sockets and WebSockets in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will work as expected.

### Resolving DNS service records using DatagramSocket

An app can communicate with the target DNS address that belongs to a SRV record.
For example, a Simple Traversal of UDP through Network Address Translation (NAT) (STUN) service in the Contoso domain corresponds to `_stun._udp.contoso.com`.
That service name corresponds to a server DNS name, for example, `stunServer01.contoso.com`.

To connect to the DNS address for the server for that service, use the following method call on a DatagramSocket instance:

```csharp
using Windows.Networking.Sockets;

DatagramSocket socket = new DatagramSocket();
socket.ConnectAsync(new HostName("contoso.com"), "stun");
```

The protocol is inferred to be UDP for DatagramSocket instances. 
The method deals with the underscore characters.

A DNS can be configured to have an SRV hierarchy. 
A DNS SRV resource records could have the following form: `_stun._service01._udp.contoso.com`. 
For this example, use the following method call on a DatagramSocket instance:

```csharp
socket.ConnectAsync(new HostName("contoso.com"), "stun._service01");
```

These code snippets use [ConnectAsync](datagramsocket_connectasync_1841953676.md).
The [GetOutputStreamAsync](datagramsocket_getoutputstreamasync_1619245957.md) and [GetEndpointPairsAsync](datagramsocket_getendpointpairsasync_1796487528.md) methods support similar usage to connect to services.

## -examples

## -see-also

[Sockets](/windows/uwp/networking/sockets), [Connecting with sockets](/previous-versions/windows/apps/hh452976(v=win.10)), [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)), [How to connect with a datagram socket  ](/previous-versions/windows/apps/hh452986(v=win.10)), [How to connect with a datagram socket ](/previous-versions/windows/apps/jj635238(v=win.10)), [How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [Troubleshoot and debug network connections](/previous-versions/windows/apps/hh770534(v=win.10)), [DatagramSocketControl](datagramsocketcontrol.md), [DatagramSocketInformation](datagramsocketinformation.md), [DatagramSocketMessageReceivedEventArgs](datagramsocketmessagereceivedeventargs.md), [IClosable](../windows.foundation/iclosable.md), [SetSocketMediaStreamingMode](/windows/desktop/api/socketapi/nf-socketapi-setsocketmediastreamingmode), [DatagramSocket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/DatagramSocket%20sample), [DatagramSocket sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620534)

## -capabilities

internetClient, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone]
