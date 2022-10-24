---
-api-id: N:Windows.Networking.Sockets
-api-type: winrt namespace
---

# Windows.Networking.Sockets

## -description

Provides sockets and WebSockets classes to use for network communications and classes for real-time network notifications received in the background for UWP apps.

## -remarks

The Windows.Networking.Sockets namespace provides classes and interfaces for networking that use sockets and WebSockets. Here are the primary classes.

+ [DatagramSocket](datagramsocket.md). A UDP datagram socket to use for network communication.
+ [StreamSocket](streamsocket.md). A stream socket to use for incoming or outgoing network communication over TCP or over Bluetooth connections that use RFCOMM.
+ [StreamSocketListener](streamsocketlistener.md). A stream socket listener to listen for incoming TCP network connections or incoming Bluetooth connections that use RFCOMM.
+ [MessageWebSocket](messagewebsocket.md). A message-based WebSocket to read and write whole messages for network communication. See [WebSockets](/windows/uwp/networking/websockets).
+ [StreamWebSocket](streamwebsocket.md). A stream-based WebSocket to read and write streams for network communications. See [WebSockets](/windows/uwp/networking/websockets).

These primary classes also have a number of related information and control classes in the Windows.Networking.Sockets namespace.

### Handling exceptions

You must write code to handle exceptions when you call asynchronous methods in the Windows.Networking.Sockets namespace. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime.

The Windows.Networking.Sockets namespace has convenient helper methods and enumerations for handling errors when using sockets and WebSockets. This can be useful for handling specific network exceptions differently in your app. An app can also use the **HRESULT** from the exception on parameter validation errors to learn more detailed information on the error that caused the exception.

For more information on possible exceptions and how to handle exceptions, see [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)).

### Using StreamSocket with Proximity, Wi-Fi Direct, and Bluetooth

Your app can use a [StreamSocket](streamsocket.md) for network connections between devices that are within close range. Classes in the [Windows.Networking.Proximity](../windows.networking.proximity/windows_networking_proximity.md) namespace support network connections with a [StreamSocket](streamsocket.md) to nearby devices that use Bluetooth or Wi-Fi Direct. The [PeerFinder](../windows.networking.proximity/peerfinder.md) and related classes in the [ Windows.Networking.Proximity](../windows.networking.proximity/windows_networking_proximity.md) namespace let your app discover another instance of your app on a nearby device. The [PeerFinder.FindAllPeersAsync](../windows.networking.proximity/peerfinder_findallpeersasync_830195586.md) method browses for peer computers that are running the same app within wireless range. The [PeerFinder.ConnectAsync](../windows.networking.proximity/peerfinder_connectasync_380619906.md) method returns a connected [StreamSocket](streamsocket.md) that your app can use to transfer network data with the nearby peer app. For more information, see [Supporting proximity and tapping](/previous-versions/windows/apps/hh465229(v=win.10)), [Windows.Networking.Proximity](../windows.networking.proximity/windows_networking_proximity.md), [PeerFinder](../windows.networking.proximity/peerfinder.md), and the [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample).

Your app can also use a [StreamSocket](streamsocket.md) for network connections between devices that use Wi-Fi Direct with classes in the [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) namespace. The [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md) class can be used to locate other devices that have a Wi-Fi Direct (WFD) capable device. The [WiFiDirectDevice.GetDeviceSelector](../windows.devices.wifidirect/wifidirectdevice_getdeviceselector_185243134.md) method gets the device identifier for a nearby WFD device. Once you have a reference to a nearby WFD device, you can call the [WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs_1958888015.md) method to get an [EndpointPair](../windows.networking/endpointpair.md) object. The [ConnectAsync(EndpointPair)](streamsocket_connectasync_13692504.md) or [ConnectAsync(EndpointPair, SocketProtectionLevel)](streamsocket_connectasync_706428084.md) method on the [StreamSocket](streamsocket.md) class can then be used to establish a socket connection. For more information, see [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) and [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md).

Bluetooth uses Bluetooth Service IDs as endpoints for [StreamSocket](streamsocket.md) connections, not hostnames or IP addresses. To use a [StreamSocket](streamsocket.md) with Bluetooth, the **bluetooth.rfcomm** device capability must be set in the app manifest. For more information, see the [Windows.Devices.Bluetooth.Rfcomm](../windows.devices.bluetooth.rfcomm/windows_devices_bluetooth_rfcomm.md) namespace, [How to specify device capabilities for Bluetooth](/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-bluetooth), and the [Bluetooth Rfcomm Chat sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Bluetooth%20Rfcomm%20Chat).

### Using DatagramSocket with Wi-Fi Direct

Your app can use a [DatagramSocket](datagramsocket.md) for network data transfers between devices that use Wi-Fi Direct using classes in the [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) namespace. The [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md) class can be used to locate other devices that have a Wi-Fi Direct (WFD) capable device. The [WiFiDirectDevice.GetDeviceSelector](../windows.devices.wifidirect/wifidirectdevice_getdeviceselector_185243134.md) method gets the device identifier for a nearby WFD device. Once you have a reference to a nearby WFD device, you can call the [WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs_1958888015.md) method to get an [EndpointPair](../windows.networking/endpointpair.md) object. Methods on the [DatagramSocket](datagramsocket.md) class can be used to send and receive data to the [EndpointPair](../windows.networking/endpointpair.md) object. For more information, see [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) and [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md).

### Using network triggers

The Windows.Networking.Sockets namespace offers two kinds of triggers that your app can use for background networking: [ControlChannelTrigger](controlchanneltrigger.md) and [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md).

### Control channel triggers

The [ControlChannelTrigger](controlchanneltrigger.md) lets your app receive network data packets and network keepalives when the app is in the background. This lets your app provide real-time status and network notifications for [StreamSocket](streamsocket.md) in the Windows.Networking.Sockets namespace and other network classes in related namespaces.

Network triggers are used by long-running network apps (for example, an email app) to minimize network and system resource usage. Network triggers let an app drop to a low-power mode for periods of time, keeping network connections intact but in a low-power state. You can set a keepalive interval to let the system know when the app should wake up. You can also set a trigger to be notified when a packet is received for the app. These notification features can help extend battery life when using long-running network apps on mobile devices.

For more information, see the [ControlChannelTrigger](controlchanneltrigger.md) class and [How to set background connectivity options](/previous-versions/windows/apps/hh771189(v=win.10)).

### Socket activity triggers

The [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md) lets your app receive network data packets when it is not active (even if it is suspended or terminated), and even when it is not currently loaded in memory. It is provided particularly for apps that provide network services, where the app would register as a service provider through DNS-SD, and then become inactive. A [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md) would notify the app when a client connected to the service, so that the service could activate and provide requested services. [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md) can be used in other circumstances, too. Use it whenever you want to be able to activate your app in response to received network traffic.

If your app uses socket activity triggers, you must specify the pushNotifications capability in the app manifest.

### Choosing a network trigger

There are some scenarios where either kind of trigger would be suitable. When you are choosing which kind of trigger to use in your app, consider the following advice.

+ If you are using [IXMLHTTPRequest2](/previous-versions/windows/desktop/api/msxml6/nn-msxml6-ixmlhttprequest2), [System.Net.Http.HttpClient](../windows.web.http/httpclient.md) or [System.Net.Http.HttpClientHandler](/dotnet/api/system.net.http.httpclienthandler?view=dotnet-uwp-10.0&preserve-view=true), you must use [ControlChannelTrigger](controlchanneltrigger.md).
+ If you are using push-enabled **StreamSockets**, prefer [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md). It allows the system to free up memory and reduce power requirements when the connection is not being actively used.
+ If you want to minimize the memory footprint of your app when it is not actively servicing network requests, prefer [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md).
+ If you want your app to be able to receive data while the system is in Connected Standby mode, use [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md).

### Using sockets and WebSockets on Windows Server 2012

On Windows Server 2012 and Windows Server 2012 R2, the *Windows.Networking.dll* that implements most of the classes in the Windows.Networking.Sockets namespace will fail to load unless the Media Foundation feature is enabled. As a result, apps that uses sockets or WebSockets classes in the Windows.Networking.Sockets namespace will fail if the Media Foundation feature is disabled. Windows Server 2012 or Windows Server 2012 R2 installs with the Media Foundation feature disabled.

The Media Foundation feature can be enabled on Windows Server 2012 or Windows Server 2012 R2 using Server Manager or by entering the following text in a command prompt or a script:

`dism /online /enable-feature /featurename:ServerMediaFoundation `After the Media Foundation feature is enabled, the user is prompted to restart. Once the computer is restarted, classes for sockets and WebSockets in the Windows.Networking.Sockets namespace will work as expected.

### Using sockets and WebSockets with network isolation

Network isolation in Windows 8 lets you fully control the security profile of a UWP app.

Network isolation lets you define the network access needed for each app by choosing the appropriate capabilities. An app without the appropriate capabilities set is prevented from using specific network types (Internet or Home/Work Network) and specific network requests (outbound client-initiated requests, or both inbound unsolicited requests and outbound client-initiated requests). The ability to enforce network isolation ensures that even if an app becomes compromised, the app can only use features (network types and network requests, for example) that the app was granted as capabilities. This significantly reduces the possible impact on other apps and on the operating system.

Windows 8 actively enforces network isolation. A call to a method or any access to a property in the Windows.Networking.Sockets namespace (or related namespaces that require network access) may fail if the appropriate network capability has not been enabled.

The network capabilities for an app are configured in the app manifest when the app is built. Network capabilities are usually added using Visual Studio when you develop your app. They may also be set manually in the app manifest file using a text editor.

For more detailed information on network isolation, see [How to configure network isolation capabilities](/previous-versions/windows/apps/hh770532(v=win.10)).

## -examples

## -see-also

[Adding support for networking](/previous-versions/windows/apps/hh452752(v=win.10)),
[Connecting with sockets](/previous-versions/windows/apps/hh452976(v=win.10)),
[WebSockets](/windows/uwp/networking/websockets),
[Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)),
[How to configure network isolation capabilities](/previous-versions/windows/apps/hh770532(v=win.10)),
[How to set background connectivity options](/previous-versions/windows/apps/hh771189(v=win.10)),
[How to specify device capabilities for Bluetooth](/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-bluetooth), [Supporting proximity and tapping](/previous-versions/windows/apps/hh465229(v=win.10)),
[Troubleshooting and debugging network connections](/previous-versions/windows/apps/hh770534(v=win.10)),
[PeerFinder](../windows.networking.proximity/peerfinder.md),
[SetSocketMediaStreamingMode](/windows/desktop/api/socketapi/nf-socketapi-setsocketmediastreamingmode),
[WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md),
[Windows.Devices.Bluetooth.Rfcomm](../windows.devices.bluetooth.rfcomm/windows_devices_bluetooth_rfcomm.md),
[Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md),
[Windows.Networking Namespace](../windows.networking/windows_networking.md),
[Windows.Networking.Connectivity Namespace](../windows.networking.connectivity/windows_networking_connectivity.md),
[Windows.Networking.Proximity](../windows.networking.proximity/windows_networking_proximity.md),
[Bluetooth Rfcomm Chat sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Bluetooth%20Rfcomm%20Chat),
[DatagramSocket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/DatagramSocket%20sample),
[ControlChannelTrigger StreamWebSocket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/ControlChannelTrigger%20StreamWebSocket%20sample/C%23),
[ControlChannelTrigger TCP socket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/ControlChannelTrigger%20StreamSocket%20sample/C%23),
[Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample),
[StreamSocket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/DatagramSocket%20sample),
[DatagramSocket sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DatagramSocket),
[WebSocket sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebSocket),
[StreamSocket sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/StreamSocket),
[Wi-Fi Direct sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WiFiDirect),
[Wi-Fi Direct services sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WiFiDirectServices),
[Socket activity trigger stream socket sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SocketActivityStreamSocket)

## -capabilities

ID_CAP_NETWORKING [Windows Phone]
