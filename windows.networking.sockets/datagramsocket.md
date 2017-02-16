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

## -remarks
The [DatagramSocket](datagramsocket.md) class supports network communication using a UDP datagram socket. The [DatagramSocket](datagramsocket.md) object can be used for client apps that send UDP packets or for server apps that listen for incoming UDP data.

Several steps are needed to send or receive data using a [DatagramSocket](datagramsocket.md) object. Your app first assigns the [MessageReceived](datagramsocket_messagereceived.md) event to an event handler. To listen for incoming packets from a remote endpoint (a server scenario, for example), your app calls either the [BindEndpointAsync](datagramsocket_bindendpointasync.md) or [BindServiceNameAsync](datagramsocket_bindservicenameasync.md) method to bind the [DatagramSocket](datagramsocket.md) to a local service name or UDP port. However when your app needs to communicate with a single remote endpoint (client scenario, for example), your app calls the [ConnectAsync](datagramsocket_connectasync_1841953676.md) method. The [MessageReceived](datagramsocket_messagereceived.md) event handler must be set before any bind or connect operation, otherwise an error will occur.

The typical order of operations is as follows:


1. Create the [DatagramSocket](datagramsocket.md).
1. Use the [Control](datagramsocket_control.md) property to retrieve a [DatagramSocketControl](datagramsocketcontrol.md) object and set any advanced controls. This step is not normally needed by most apps.
1. Assign the [MessageReceived](datagramsocket_messagereceived.md) event to an event handler.
1. To listen for incoming packets from any remote endpoint (server scenario, for example), call the [BindEndpointAsync](datagramsocket_bindendpointasync.md) or [BindServiceNameAsync](datagramsocket_bindservicenameasync.md) method to bind the [DatagramSocket](datagramsocket.md) to a local service name or UDP port.
1. To communicate with a single remote endpoint (client scenario, for example), call the [ConnectAsync](datagramsocket_connectasync_1841953676.md) method to bind the [DatagramSocket](datagramsocket.md) to a specific remote endpoint.
1. The [MessageReceived](datagramsocket_messagereceived.md) event handler will be invoked whenever a message from the remote endpoint arrives.
This class can also be used to join a multicast group and send UDP packets to the multicast group. For more information, see the [JoinMulticastGroup](datagramsocket_joinmulticastgroup.md) method.

### Handling exceptions

You must write code to handle exceptions when you call asynchronous methods on the [DatagramSocket](datagramsocket.md) class. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime.

The [Windows.Networking.Sockets](windows_networking_sockets.md) namespace has a convenient helper method and enumeration for handling errors when using sockets. This can be useful for handling specific network exceptions differently in your app. An app can also use the **HRESULT** from the exception on parameter validation errors to learn more detailed information on the error that caused the exception.

For more information on possible exceptions and how to handle exceptions, see [Handling exceptions in network apps](http://msdn.microsoft.com/library/76fafcc9-c674-4cf8-baa0-2400638fae35).

### Using DatagramSocket with Wi-Fi Direct

Your app can use a [DatagramSocket](datagramsocket.md) for network data transfers between devices that use Wi-Fi Direct using classes in the [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) namespace. The [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md) class can be used to locate other devices that have a Wi-Fi Direct (WFD) capable device. The [WiFiDirectDevice.GetDeviceSelector](../windows.devices.wifidirect/wifidirectdevice_getdeviceselector.md) method gets the device identifier for a nearby WFD device. Once you have a reference to a nearby WFD device, you can call the [WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs.md) method to get an [EndpointPair](../windows.networking/endpointpair.md) object. Methods on the [DatagramSocket](datagramsocket.md) class can be used to send and receive data to the [EndpointPair](../windows.networking/endpointpair.md) object. For more information, see [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) and [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md).

### Using DatagramSocket on Windows Server 2012

On Windows Server 2012 and Windows Server 2012 R2, the *Windows.Networking.dll* that implements most of the classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail to load unless the Media Foundation feature is enabled. As a result, apps that use [DatagramSocket](datagramsocket.md) and related socket classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail if the Media Foundation feature is disabled. Windows Server 2012 or Windows Server 2012 R2 installs with the Media Foundation feature disabled.

The Media Foundation feature can be enabled on Windows Server 2012 or Windows Server 2012 R2 using Server Manager or by entering the following text in a command prompt or a script:

`dism /online /enable-feature /featurename:ServerMediaFoundation `After the Media Foundation feature is enabled, the user is prompted to restart. Once the computer is restarted, classes for sockets and WebSockets in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will work as expected.

## -examples

## -see-also
[Connecting with sockets ](http://msdn.microsoft.com/library/67cfa78f-570f-4dd4-a0f2-cd6c891f5446), [Connecting with sockets ](http://msdn.microsoft.com/library/2a6448d0-e21f-4963-bca5-aae001ae4fc7), [Handling exceptions in network apps](http://msdn.microsoft.com/library/76fafcc9-c674-4cf8-baa0-2400638fae35), [How to connect with a datagram socket  ](http://msdn.microsoft.com/library/63495298-a017-484a-ac17-0655379248ff), [How to connect with a datagram socket ](http://msdn.microsoft.com/library/fd9bd4d7-308b-4cdd-94bb-0632a29e2131), [How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [Troubleshoot and debug network connections](http://msdn.microsoft.com/library/ae3fce58-43ab-4258-9146-755a150e6b50), [DatagramSocketControl](datagramsocketcontrol.md), [DatagramSocketInformation](datagramsocketinformation.md), [DatagramSocketMessageReceivedEventArgs](datagramsocketmessagereceivedeventargs.md), [IClosable](../windows.foundation/iclosable.md), [SetSocketMediaStreamingMode](http://msdn.microsoft.com/library/5d1c18fc-2f25-44c0-ad3c-f1e7744c4963), [DatagramSocket sample](http://go.microsoft.com/fwlink/p/?LinkID=243037), [DatagramSocket sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620534)

## -capabilities
internetClient, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone]