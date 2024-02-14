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

The StreamSocketListener class supports listening for an incoming network connection using a stream socket and accepting the connection.

The typical order of operations is as follows:

+ Create the StreamSocketListener.
+ Use the [Control](streamsocketlistener_control.md) property to retrieve a [StreamSocketListenerControl](streamsocketlistenercontrol.md) object and set the socket quality of service required.
+ Assign the [ConnectionReceived](streamsocketlistener_connectionreceived.md) event to an event handler.
+ Call the [BindServiceNameAsync](streamsocketlistener_bindservicenameasync_1713574846.md) or [BindEndpointAsync](streamsocketlistener_bindendpointasync_1396029045.md) method to bind to a local TCP port number or service name. For Bluetooth RFCOMM, the local service name parameter is the Bluetooth Service ID.
+ When a connection is received, use the [StreamSocketListenerConnectionReceivedEventArgs](streamsocketlistenerconnectionreceivedeventargs.md) object to retrieve the [Socket](streamsocketlistenerconnectionreceivedeventargs_socket.md) property with the [StreamSocket](streamsocket.md) object created.
+ Use the [StreamSocket](streamsocket.md) object to send and receive data.
+ Call the [Close](streamsocketlistener_close_811482585.md) method to stop listening for and accepting incoming network connections and release all unmanaged resources associated with the StreamSocketListener object. Any [StreamSocket](streamsocket.md) objects created when a connection is received are unaffected and can continue to be used as needed.

The [SocketProtectionLevel](socketprotectionlevel.md) enumeration allows a server to control protocol negotiation with clients when using the StreamSocketListener object to listen and bind to sockets over Bluetooth. When the StreamSocketListener object is used over Bluetooth, the supported [SocketProtectionLevel](socketprotectionlevel.md) values are **PlainSocket**, **BluetoothEncryptionAllowNullAuthentication**, or **BluetoothEncryptionWithAuthentication**. When the StreamSocketListener object is used to listen and bind to sockets not using Bluetooth, the only supported [SocketProtectionLevel](socketprotectionlevel.md) value is **PlainSocket**.

To use StreamSocketListener with Bluetooth, the **bluetooth.rfcomm** device capability must be set in the app manifest. For more information, see [How to specify device capabilities for Bluetooth](/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-bluetooth).

### Handling exceptions

You must write code to handle exceptions when you call asynchronous methods on the StreamSocketListener class. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime.

The [Windows.Networking.Sockets](windows_networking_sockets.md) namespace has features that simplify handling errors when using sockets. The [GetStatus](socketerror_getstatus_1856274933.md) method on the [SocketError](socketerror.md) class can convert the **HRESULT** from an exception to a [SocketErrorStatus](socketerrorstatus.md) enumeration value. This can be useful for handling specific network exceptions differently in your app. An app can also use the **HRESULT** from the exception on parameter validation errors to learn more detailed information on the error that caused the exception.

For more information on possible exceptions and how to handle exceptions, see [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)).

### Using StreamSocketListener with Bluetooth

Your app can use StreamSocketListener to listen for network connections over Bluetooth RFCOMM. Network connections over Bluetooth use a Bluetooth Service ID as the endpoint for connections, not an IP port or a service name. To listen for Bluetooth, your app would call one of the [BindServiceNameAsync](streamsocketlistener_bindservicenameasync_1713574846.md) methods on StreamSocketListener with the *localServiceName* parameter set to a Bluetooth Service ID.

To use StreamSocketListener and [StreamSocket](streamsocket.md) with Bluetooth, the **bluetooth.rfcomm** device capability must be set in the app manifest. For more information, see the [Windows.Devices.Bluetooth.Rfcomm](../windows.devices.bluetooth.rfcomm/windows_devices_bluetooth_rfcomm.md) namespace, [How to specify device capabilities for Bluetooth](/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-bluetooth), and the [Bluetooth Rfcomm Chat sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Bluetooth%20Rfcomm%20Chat).

### Using StreamSocketListener on Windows Server 2012

On Windows Server 2012 and Windows Server 2012 R2, the *Windows.Networking.dll* that implements most of the classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail to load unless the Media Foundation feature is enabled. As a result, apps that use StreamSocketListener and related socket classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail if the Media Foundation feature is disabled. Windows Server 2012 or Windows Server 2012 R2 installs with the Media Foundation feature disabled.

The Media Foundation feature can be enabled on Windows Server 2012 or Windows Server 2012 R2 using Server Manager or by entering the following text in a command prompt or a script:

`dism /online /enable-feature /featurename:ServerMediaFoundation `After the Media Foundation feature is enabled, the user is prompted to restart. Once the computer is restarted, classes for sockets and WebSockets in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will work as expected.

## -examples

## -see-also

[Connecting with sockets](/previous-versions/windows/apps/hh452976(v=win.10)), [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)), [How to connect with a stream socket ](/previous-versions/windows/apps/hh452996(v=win.10)), [How to connect with a stream socket ](/previous-versions/windows/apps/jj150599(v=win.10)), [How to specify device capabilities for Bluetooth](/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-bluetooth), [How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [Troubleshoot and debug network connections](/previous-versions/windows/apps/hh770534(v=win.10)), [IClosable](../windows.foundation/iclosable.md), [SocketError](socketerror.md), [SocketErrorStatus](socketerrorstatus.md), [StreamSocket](streamsocket.md), [StreamSocketListenerConnectionReceivedEventArgs](streamsocketlistenerconnectionreceivedeventargs.md), [StreamSocketListenerControl](streamsocketlistenercontrol.md), [StreamSocketListenerInformation](streamsocketlistenerinformation.md), [Bluetooth Rfcomm Chat sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Bluetooth%20Rfcomm%20Chat), [ControlChannelTrigger StreamSocket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/ControlChannelTrigger%20StreamSocket%20sample), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Proximity%20sample), [StreamSocket sample](https://go.microsoft.com/fwlink/p/?LinkId=620609)

## -capabilities

internetClientServer, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone], bluetooth.rfcomm