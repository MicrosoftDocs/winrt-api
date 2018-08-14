---
-api-id: T:Windows.Networking.Sockets.StreamSocketListener
-api-type: winrt class
---

<!-- Class syntax.
public class StreamSocketListener : Windows.Foundation.IClosable, Windows.Networking.Sockets.IStreamSocketListener, Windows.Networking.Sockets.IStreamSocketListener2, Windows.Networking.Sockets.IStreamSocketListener3
-->

# Windows.Networking.Sockets.StreamSocketListener

## -description

Supports listening for an incoming network connection using a TCP stream socket or Bluetooth RFCOMM.

## -remarks

The [StreamSocketListener](streamsocketlistener.md) class supports listening for an incoming network connection using a stream socket and accepting the connection.

The typical order of operations is as follows:

+ Create the [StreamSocketListener](streamsocketlistener.md).
+ Use the [Control](streamsocketlistener_control.md) property to retrieve a [StreamSocketListenerControl](streamsocketlistenercontrol.md) object and set the socket quality of service required.
+ Assign the [ConnectionReceived](streamsocketlistener_connectionreceived.md) event to an event handler.
+ Call the [BindServiceNameAsync](streamsocketlistener_bindservicenameasync_1713574846.md) or [BindEndpointAsync](streamsocketlistener_bindendpointasync_1396029045.md) method to bind to a local TCP port number or service name. For Bluetooth RFCOMM, the local service name parameter is the Bluetooth Service ID.
+ When a connection is received, use the [StreamSocketListenerConnectionReceivedEventArgs](streamsocketlistenerconnectionreceivedeventargs.md) object to retrieve the [Socket](streamsocketlistenerconnectionreceivedeventargs_socket.md) property with the [StreamSocket](streamsocket.md) object created.
+ Use the [StreamSocket](streamsocket.md) object to send and receive data.
+ Call the [Close](streamsocketlistener_close_811482585.md) method to stop listening for and accepting incoming network connections and release all unmanaged resources associated with the [StreamSocketListener](streamsocketlistener.md) object. Any [StreamSocket](streamsocket.md) objects created when a connection is received are unaffected and can continue to be used as needed.

The [SocketProtectionLevel](socketprotectionlevel.md) enumeration allows a server to control protocol negotiation with clients when using the [StreamSocketListener](streamsocketlistener.md) object to listen and bind to sockets over Bluetooth. When the [StreamSocketListener](streamsocketlistener.md) object is used over Bluetooth, the supported [SocketProtectionLevel](socketprotectionlevel.md) values are **PlainSocket**, **BluetoothEncryptionAllowNullAuthentication**, or **BluetoothEncryptionWithAuthentication**. When the [StreamSocketListener](streamsocketlistener.md) object is used to listen and bind to sockets not using Bluetooth, the only supported [SocketProtectionLevel](socketprotectionlevel.md) value is **PlainSocket**.

To use [StreamSocketListener](streamsocketlistener.md) with Bluetooth, the **bluetooth.rfcomm** device capability must be set in the app manifest. For more information, see [How to specify device capabilities for Bluetooth](https://docs.microsoft.com/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-bluetooth).

### Handling exceptions

You must write code to handle exceptions when you call asynchronous methods on the [StreamSocketListener](streamsocketlistener.md) class. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime.

The [Windows.Networking.Sockets](windows_networking_sockets.md) namespace has features that simplify handling errors when using sockets. The [GetStatus](socketerror_getstatus_1856274933.md) method on the [SocketError](socketerror.md) class can convert the **HRESULT** from an exception to a [SocketErrorStatus](socketerrorstatus.md) enumeration value. This can be useful for handling specific network exceptions differently in your app. An app can also use the **HRESULT** from the exception on parameter validation errors to learn more detailed information on the error that caused the exception.

For more information on possible exceptions and how to handle exceptions, see [Handling exceptions in network apps](http://msdn.microsoft.com/library/76fafcc9-c674-4cf8-baa0-2400638fae35).

### Using StreamSocketListener with Bluetooth

Your app can use [StreamSocketListener](streamsocketlistener.md) to listen for network connections over Bluetooth RFCOMM. Network connections over Bluetooth use a Bluetooth Service ID as the endpoint for connections, not an IP port or a service name. To listen for Bluetooth, your app would call one of the [BindServiceNameAsync](streamsocketlistener_bindservicenameasync_1713574846.md) methods on [StreamSocketListener](streamsocketlistener.md) with the *localServiceName* parameter set to a Bluetooth Service ID.

To use [StreamSocketListener](streamsocketlistener.md) and [StreamSocket](streamsocket.md) with Bluetooth, the **bluetooth.rfcomm** device capability must be set in the app manifest. For more information, see the [Windows.Devices.Bluetooth.Rfcomm](../windows.devices.bluetooth.rfcomm/windows_devices_bluetooth_rfcomm.md) namespace, [How to specify device capabilities for Bluetooth](https://docs.microsoft.com/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-bluetooth), and the [Bluetooth Rfcomm Chat sample](http://go.microsoft.com/fwlink/p/?LinkID=306047).

### Using StreamSocketListener on Windows Server 2012

On Windows Server 2012 and Windows Server 2012 R2, the *Windows.Networking.dll* that implements most of the classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail to load unless the Media Foundation feature is enabled. As a result, apps that use [StreamSocketListener](streamsocketlistener.md) and related socket classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail if the Media Foundation feature is disabled. Windows Server 2012 or Windows Server 2012 R2 installs with the Media Foundation feature disabled.

The Media Foundation feature can be enabled on Windows Server 2012 or Windows Server 2012 R2 using Server Manager or by entering the following text in a command prompt or a script:

`dism /online /enable-feature /featurename:ServerMediaFoundation `After the Media Foundation feature is enabled, the user is prompted to restart. Once the computer is restarted, classes for sockets and WebSockets in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will work as expected.

## -examples

## -see-also

[Connecting with sockets ](http://msdn.microsoft.com/library/67cfa78f-570f-4dd4-a0f2-cd6c891f5446), [Connecting with sockets ](http://msdn.microsoft.com/library/2a6448d0-e21f-4963-bca5-aae001ae4fc7), [Handling exceptions in network apps](http://msdn.microsoft.com/library/76fafcc9-c674-4cf8-baa0-2400638fae35), [How to connect with a stream socket ](http://msdn.microsoft.com/library/34f2c556-4cd4-4deb-83fb-1b8fae8a9eb8), [How to connect with a stream socket ](http://msdn.microsoft.com/library/e99c35f6-5aa8-4abf-8e1d-eea46a95d963), [How to specify device capabilities for Bluetooth](https://docs.microsoft.com/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-bluetooth), [How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [Troubleshoot and debug network connections](http://msdn.microsoft.com/library/ae3fce58-43ab-4258-9146-755a150e6b50), [IClosable](../windows.foundation/iclosable.md), [SocketError](socketerror.md), [SocketErrorStatus](socketerrorstatus.md), [StreamSocket](streamsocket.md), [StreamSocketListenerConnectionReceivedEventArgs](streamsocketlistenerconnectionreceivedeventargs.md), [StreamSocketListenerControl](streamsocketlistenercontrol.md), [StreamSocketListenerInformation](streamsocketlistenerinformation.md), [Bluetooth Rfcomm Chat sample](http://go.microsoft.com/fwlink/p/?LinkID=306047), [ControlChannelTrigger StreamSocket sample](http://go.microsoft.com/fwlink/p/?linkid=243039), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082), [StreamSocket sample](http://go.microsoft.com/fwlink/p/?linkid=243037), [StreamSocket sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620609)

## -capabilities

internetClientServer, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone], bluetooth.rfcomm
