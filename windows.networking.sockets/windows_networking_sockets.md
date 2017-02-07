---
-api-id: N:Windows.Networking.Sockets
-api-type: winrt namespace
---

# Windows.Networking.Sockets

## -description
Provides sockets and WebSockets classes to use for network communications and classes for real-time network notifications received in the background for Windows Store app.

## -remarks
The [Windows.Networking.Sockets](windows_networking_sockets.md) namespace provides classes and interfaces for networking that use sockets and WebSockets. The primary classes include:


+ [DatagramSocket](datagramsocket.md) - A UDP datagram socket to use for network communication.
+ [StreamSocket](streamsocket.md) - A stream socket to use for incoming or outgoing network communication over TCP or over Bluetooth connections that use RFCOMM.
+ [StreamSocketListener](streamsocketlistener.md) - A stream socket listener to listen for incoming TCP network connections or incoming Bluetooth connections that use RFCOMM.
+ [MessageWebSocket](messagewebsocket.md) - A message-based WebSocket to read and write whole messages for network communication.
+ [StreamWebSocket](streamwebsocket.md) - A stream-based WebSocket to read and write streams for network communications.
These primary classes also have a number of related information and control classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace.

### Handling exceptions

You must write code to handle exceptions when you call asynchronous methods in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime.

The [Windows.Networking.Sockets](windows_networking_sockets.md) namespace has convenient helper methods and enumerations for handling errors when using sockets and WebSockets. This can be useful for handling specific network exceptions differently in your app. An app can also use the **HRESULT** from the exception on parameter validation errors to learn more detailed information on the error that caused the exception.

For more information on possible exceptions and how to handle exceptions, see [Handling exceptions in network apps](http://msdn.microsoft.com/library/76fafcc9-c674-4cf8-baa0-2400638fae35).

### Using StreamSocket with Proximity, Wi-Fi Direct, and Bluetooth

Your app can use a [StreamSocket](streamsocket.md) for network connections between devices that are within close range. Classes in the [Windows.Networking.Proximity](../windows.networking.proximity/windows_networking_proximity.md) namespace support network connections with a [StreamSocket](streamsocket.md) to nearby devices that use Bluetooth or Wi-Fi Direct. The [PeerFinder](../windows.networking.proximity/peerfinder.md) and related classes in the [ Windows.Networking.Proximity](../windows.networking.proximity/windows_networking_proximity.md) namespace let your app discover another instance of your app on a nearby device. The [PeerFinder.FindAllPeersAsync](../windows.networking.proximity/peerfinder_findallpeersasync.md) method browses for peer computers that are running the same app within wireless range. The [PeerFinder.ConnectAsync](../windows.networking.proximity/peerfinder_connectasync.md) method returns a connected [StreamSocket](streamsocket.md) that your app can use to transfer network data with the nearby peer app. For more information, see [Supporting proximity and tapping](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Windows.Networking.Proximity](../windows.networking.proximity/windows_networking_proximity.md), [PeerFinder](../windows.networking.proximity/peerfinder.md), and the [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082).

Your app can also use a [StreamSocket](streamsocket.md) for network connections between devices that use Wi-Fi Direct with classes in the [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) namespace. The [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md) class can be used to locate other devices that have a Wi-Fi Direct (WFD) capable device. The [WiFiDirectDevice.GetDeviceSelector](../windows.devices.wifidirect/wifidirectdevice_getdeviceselector.md) method gets the device identifier for a nearby WFD device. Once you have a reference to a nearby WFD device, you can call the [WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs.md) method to get an [EndpointPair](../windows.networking/endpointpair.md) object. The [ConnectAsync(EndpointPair)](streamsocket_connectasync_13692504.md) or [ConnectAsync(EndpointPair, SocketProtectionLevel)](streamsocket_connectasync_706428084.md) method on the [StreamSocket](streamsocket.md) class can then be used to establish a socket connection. For more information, see [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) and [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md).

Bluetooth uses Bluetooth Service IDs as endpoints for [StreamSocket](streamsocket.md) connections, not hostnames or IP addresses. To use a [StreamSocket](streamsocket.md) with Bluetooth, the **bluetooth.rfcomm** device capability must be set in the app manifest. For more information, see the [Windows.Devices.Bluetooth.Rfcomm](../windows.devices.bluetooth.rfcomm/windows_devices_bluetooth_rfcomm.md) namespace, [How to specify device capabilities for Bluetooth](XREF:TODO:AppxManifestSchema.how_to_specify_device_capabilities_for_bluetooth), and the [Bluetooth Rfcomm Chat sample](http://go.microsoft.com/fwlink/p/?LinkID=306047).

### Using DatagramSocket with Wi-Fi Direct

Your app can use a [DatagramSocket](datagramsocket.md) for network data transfers between devices that use Wi-Fi Direct using classes in the [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) namespace. The [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md) class can be used to locate other devices that have a Wi-Fi Direct (WFD) capable device. The [WiFiDirectDevice.GetDeviceSelector](../windows.devices.wifidirect/wifidirectdevice_getdeviceselector.md) method gets the device identifier for a nearby WFD device. Once you have a reference to a nearby WFD device, you can call the [WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs.md) method to get an [EndpointPair](../windows.networking/endpointpair.md) object. Methods on the [DatagramSocket](datagramsocket.md) class can be used to send and receive data to the [EndpointPair](../windows.networking/endpointpair.md) object. For more information, see [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) and [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md).

### Using network triggers

The [Windows.Networking.Sockets](windows_networking_sockets.md) namespace offers two kinds of triggers that your app can use for background networking: [ControlChannelTrigger](controlchanneltrigger.md) and [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md).

### Control channel triggers

The [ControlChannelTrigger](controlchanneltrigger.md) lets your app receive network data packets and network keepalives when the app is in the background. This lets your app provide real-time status and network notifications for [StreamSocket](streamsocket.md) in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace and other network classes in related namespaces.

Network triggers are used by long-running network apps (for example, an email app) to minimize network and system resource usage. Network triggers let an app drop to a low-power mode for periods of time, keeping network connections intact but in a low-power state. You can set a keepalive interval to let the system know when the app should wake up. You can also set a trigger to be notified when a packet is received for the app. These notification features can help extend battery life when using long-running network apps on mobile devices.

For more information, see the [ControlChannelTrigger](controlchanneltrigger.md) class and [How to set background connectivity options](http://msdn.microsoft.com/library/b6042b5f-5cee-4dee-8cb4-8f376f878e97).

### Socket activity triggers

The [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md) lets your app receive network data packets when it is not active (even if it is suspended or terminated), and even when it is not currently loaded in memory. It is provided particularly for apps that provide network services, where the app would register as a service provider through DNS-SD, and then become inactive. A [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md) would notify the app when a client connected to the service, so that the service could activate and provide requested services. [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md) can be used in other circumstances, too. Use it whenever you want to be able to activate your app in response to received network traffic.

If your app uses socket activity triggers, you must specify the pushNotifications capability in the app manifest.

### Choosing a network trigger

There are some scenarios where either kind of trigger would be suitable. When you are choosing which kind of trigger to use in your app, consider the following advice.

+ If you are using [IXMLHTTPRequest2](XREF:TODO:ixhr2.ixmlhttprequest2), [System.Net.Http.HttpClient](../windows.web.http/httpclient.md) or [System.Net.Http.HttpClientHandler](http://go.microsoft.com/fwlink/p/?linkid=241638), you must use [ControlChannelTrigger](controlchanneltrigger.md).
+ If you are using push-enabled **StreamSockets**, prefer [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md). It allows the system to free up memory and reduce power requirements when the connection is not being actively used.
+ If you want to minimize the memory footprint of your app when it is not actively servicing network requests, prefer [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md).
+ If you want your app to be able to receive data while the system is in Connected Standby mode, use [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md).


### Using sockets and WebSockets on Windows Server 2012

On Windows Server 2012 and Windows Server 2012 R2, the *Windows.Networking.dll* that implements most of the classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail to load unless the Media Foundation feature is enabled. As a result, apps that uses sockets or WebSockets classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail if the Media Foundation feature is disabled. Windows Server 2012 or Windows Server 2012 R2 installs with the Media Foundation feature disabled.

The Media Foundation feature can be enabled on Windows Server 2012 or Windows Server 2012 R2 using Server Manager or by entering the following text in a command prompt or a script:

`dism /online /enable-feature /featurename:ServerMediaFoundation `After the Media Foundation feature is enabled, the user is prompted to restart. Once the computer is restarted, classes for sockets and WebSockets in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will work as expected.

### Using sockets and WebSockets with network isolation

Network isolation in Windows 8 lets you fully control the security profile of a Windows Store app.

Network isolation lets you define the network access needed for each app by choosing the appropriate capabilities. An app without the appropriate capabilities set is prevented from using specific network types (Internet or Home/Work Network) and specific network requests (outbound client-initiated requests, or both inbound unsolicited requests and outbound client-initiated requests). The ability to enforce network isolation ensures that even if an app becomes compromised, the app can only use features (network types and network requests, for example) that the app was granted as capabilities. This significantly reduces the possible impact on other apps and on the operating system.

Windows 8 actively enforces network isolation. A call to a method or any access to a property in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace (or related namespaces that require network access) may fail if the appropriate network capability has not been enabled.

The network capabilities for an app are configured in the app manifest when the app is built. Network capabilities are usually added using Visual Studio when you develop your app. They may also be set manually in the app manifest file using a text editor.

For more detailed information on network isolation, see [How to configure network isolation capabilities](http://msdn.microsoft.com/library/0a97956e-fda9-4791-b87b-9e03ae135382).

## -examples

## -see-also
[Adding support for networking](http://msdn.microsoft.com/library/1c5819d6-bed7-4d65-b9d7-af5a2239b43f), [Connecting to network services](http://msdn.microsoft.com/library/67cfa78f-570f-4dd4-a0f2-cd6c891f5446), [Connecting to a WebSocket service](http://msdn.microsoft.com/library/a472f6c2-3d26-4bc8-8bc9-2e180afe61e5), [Handling exceptions in network apps](http://msdn.microsoft.com/library/76fafcc9-c674-4cf8-baa0-2400638fae35), [How to configure network isolation capabilities](http://msdn.microsoft.com/library/0a97956e-fda9-4791-b87b-9e03ae135382), [How to set background connectivity options](http://msdn.microsoft.com/library/b6042b5f-5cee-4dee-8cb4-8f376f878e97), [How to specify device capabilities for Bluetooth](XREF:TODO:AppxManifestSchema.how_to_specify_device_capabilities_for_bluetooth), [Supporting proximity and tapping](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Troubleshooting and debugging network connections](http://msdn.microsoft.com/library/ae3fce58-43ab-4258-9146-755a150e6b50), [PeerFinder](../windows.networking.proximity/peerfinder.md), [SetSocketMediaStreamingMode](http://msdn.microsoft.com/library/5d1c18fc-2f25-44c0-ad3c-f1e7744c4963), [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md), [Windows.Devices.Bluetooth.Rfcomm](../windows.devices.bluetooth.rfcomm/windows_devices_bluetooth_rfcomm.md), [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md), [Windows.Networking Namespace](../windows.networking/windows_networking.md), [Windows.Networking.Connectivity Namespace](../windows.networking.connectivity/windows_networking_connectivity.md), [Windows.Networking.Proximity](../windows.networking.proximity/windows_networking_proximity.md), [Bluetooth Rfcomm Chat sample](http://go.microsoft.com/fwlink/p/?LinkID=306047), [DatagramSocket sample](http://go.microsoft.com/fwlink/p/?LinkID=243037), [Connecting with WebSockets sample](http://go.microsoft.com/fwlink/p/?linkid=239964), [ControlChannelTrigger StreamWebSocket sample](http://go.microsoft.com/fwlink/p/?LinkID=251353), [ControlChannelTrigger TCP socket sample](http://go.microsoft.com/fwlink/p/?linkid=243039), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082), [StreamSocket sample](http://go.microsoft.com/fwlink/p/?linkid=243037), [DatagramSocket sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620534), [WebSocket sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620623), [StreamSocket sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620609), [Wi-Fi Direct sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620626), [Wi-Fi Direct services sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620627)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]