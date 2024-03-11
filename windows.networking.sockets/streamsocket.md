---
-api-id: T:Windows.Networking.Sockets.StreamSocket
-api-type: winrt class
---

<!-- Class syntax.
public class StreamSocket : Windows.Foundation.IClosable, Windows.Networking.Sockets.IStreamSocket, Windows.Networking.Sockets.IStreamSocket2, Windows.Networking.Sockets.IStreamSocket3
-->

# Windows.Networking.Sockets.StreamSocket

## -description

Supports network communication using a stream socket over TCP or Bluetooth RFCOMM in UWP apps.

## -remarks

The StreamSocket class supports network communications that use a stream socket over TCP or Bluetooth RFCOMM in UWP apps.

For a client app, the most common sequence of operations using a StreamSocket are the following:

+ Create the StreamSocket.
+ Get a [StreamSocketControl](streamsocketcontrol.md) object using the [Control](streamsocket_control.md) property and set any properties on the [StreamSocketControl](streamsocketcontrol.md) object before calling one of the [ConnectAsync](streamsocket_connectasync_13692504.md) methods.
+ Call one of the [ConnectAsync](streamsocket_connectasync_13692504.md) methods to establish a connection with the remote endpoint. For Bluetooth, the remote service name is a Bluetooth Service ID. If an SSL/TLS connection for TCP or a level of encryption for Bluetooth is required immediately, this can be specified using some of the [ConnectAsync](streamsocket_connectasync_13692504.md) methods. If an SSL/TLS connection is desired after sending and receiving some initial data for a TCP socket, then the [UpgradeToSslAsync](streamsocket_upgradetosslasync_746090393.md) method can be called later to upgrade the connection to use SSL.
+ Get the [OutputStream](streamsocket_outputstream.md) property to write data to the remote host.
+ Get the [InputStream](streamsocket_inputstream.md) property to read data from the remote host.
+ Read and write data as needed.
+ Call the [Close](streamsocket_close_811482585.md) method to disconnect the socket, abort any pending operations, and release all unmanaged resources associated with the StreamSocket object.
> [!NOTE]
> The [Close](streamsocket_close_811482585.md) method is used by UWP apps written in JavaScript. For apps written using the .NET Framework 4.5 in C# and VB.NET, the [Close](streamsocket_close_811482585.md) method is exposed as the  method on the StreamSocket. For apps written in C++, the [Close](streamsocket_close_811482585.md) method will be called when using the delete keyword on the object.

Explicitly closing a StreamSocket object (calling the [Close](streamsocket_close_811482585.md) method) will ensure a graceful disconnect if no pending read or write operations exist on the socket. All pending reads are automatically aborted and the StreamSocket waits for any ongoing I/O to complete before tearing down the connection. If no unread data remains on the socket after the ongoing I/O is finished, a graceful disconnect (FIN) is guaranteed to occur. Otherwise, an ungraceful disconnect (RST) occurs.

When an active (still connected) StreamSocket object goes out of scope, an abortive (non-graceful) disconnect may result, which can lead to previously-sent data being discarded before it is read by the remote peer. It is strongly recommended that [Close](streamsocket_close_811482585.md) (the [Close](streamsocket_close_811482585.md) method in JavaScript, the  method in C# and VB.NET, or the delete operator in C++) be called on a StreamSocket object before it goes out of scope.

Whenever a read or write operation is cancelled, the I/O operation completes with Error state and the associated StreamSocket object immediately tears down the connection, which leads to an ungraceful disconnect (RST) if any unread or unsent data remains on the socket.

Ungraceful disconnects (RST) will always occur if: An abnormal termination occurs (for example, the app crashes); or an abnormal connection failure is detected by the networking stack (for example, TCP retransmit timeout).

The StreamSocket object is also used in conjunction with the [StreamSocketListener](streamsocketlistener.md) object to listen for incoming connections over TCP or Bluetooth RFCOMM in server apps or peer-to-peer apps. A StreamSocket object is returned by the [Socket](streamsocketlistenerconnectionreceivedeventargs_socket.md) property on the [ConnectionReceived](streamsocketlistener_connectionreceived.md) event when a [StreamSocketListener](streamsocketlistener.md) object receives a TCP or Bluetooth RFCOMM connection request. For more information, see [StreamSocketListener](streamsocketlistener.md).

### Support for proxies

In a UWP app, the StreamSocket class supports connecting to a remote endpoint when proxies are required to complete the connection. This support for proxies is automatic and transparent to the app. A StreamSocket can establish a connection through authenticating proxies as well as through other proxies where authentication is not needed. Authenticating proxies only work if Internet Explorer or an app that uses the [HttpClient](../windows.web.http/httpclient.md) class in the [Windows.Web.Http](../windows.web.http/windows_web_http.md) namespace has previously successfully authenticated with the proxy and the credentials previously used for the authentication are still valid. The support for authenticating proxies does not work if a web browser other than Internet Explorer was used to provide the authentication credentials to the proxy. Connecting through proxies is not supported if a local host address or a specific network adapter is specified on the [ConnectAsync](streamsocket_connectasync_13692504.md) method.

In a UWP app, the [ConnectAsync](streamsocket_connectasync_13692504.md) methods on the StreamSocket object try to discover proxies and the current proxy configuration both before and after name resolution to help speed up connection establishment. If a port is specified for the endpoint rather than a service name, both proxy discovery and name resolution are initiated internally. If proxy discovery completes before name resolution and the [CanConnectDirectly](../windows.networking.connectivity/proxyconfiguration_canconnectdirectly.md) property on the [ProxyConfiguration](../windows.networking.connectivity/proxyconfiguration.md) object is **false**, then a proxy connection will be attempted. Once name resolution completes, proxy discovery is initiated again with the resolved endpoint address to determine the current proxy configuration. If [CanConnectDirectly](../windows.networking.connectivity/proxyconfiguration_canconnectdirectly.md) indicates after name resolution that the app can connect directly to the remote endpoint, then a socket connection will be attempted directly to the endpoint. If [CanConnectDirectly](../windows.networking.connectivity/proxyconfiguration_canconnectdirectly.md) is **false** after name resolution, then a socket connection will be attempted directly to the endpoint and a parallel socket connection is attempted through the proxy. The first connection to succeed is used by the StreamSocket and the other connection is canceled.

There may be cases where [CanConnectDirectly](../windows.networking.connectivity/proxyconfiguration_canconnectdirectly.md) returns **false**, yet it does not mean you cannot access the resource directly. A local network could be configured to have support for both a proxy and network address translation (NAT). The WPAD script used to supply proxy information to a web browser or [HttpClient](../windows.web.http/httpclient.md) tells Windows that it should use the proxy. This can cause problems when the remote endpoint is not expecting a proxy connection (an HTTP CONNECT request, for example). An app can use the [GetProxyConfigurationAsync](../windows.networking.connectivity/networkinformation_getproxyconfigurationasync_1451648549.md) method on the [NetworkInformation](../windows.networking.connectivity/networkinformation.md) object passing the remote endpoint and port for the *uri* parameter to retrieve proxy information to help determine when this condition is suspected. A way to avoid proxy connection requests from being sent when a server can only handle direct connections is to use the [ConnectAsync(HostName, String, SocketProtectionLevel, NetworkAdapter)](streamsocket_connectasync_238604852.md) method, since the proxy-related logic is disabled when a specific network adapter is selected.

In a Windows Phone 8.x app, the StreamSocket does not provide automatic support for proxies since the [ProxyConfiguration](../windows.networking.connectivity/proxyconfiguration.md) class is not supported on Windows Phone.

### Handling exceptions

You must write code to handle exceptions when you call asynchronous methods on the StreamSocket class. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime.

The [Windows.Networking.Sockets](windows_networking_sockets.md) namespace has features that simplify handling errors when using sockets. The [GetStatus](socketerror_getstatus_1856274933.md) method on the [SocketError](socketerror.md) class can convert the **HRESULT** from an exception to a [SocketErrorStatus](socketerrorstatus.md) enumeration value. This can be useful for handling specific network exceptions differently in your app. An app can also use the **HRESULT** from the exception on parameter validation errors to learn more detailed information on the error that caused the exception.

For more information on possible exceptions and how to handle exceptions, see [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)).

### Using StreamSocket with Proximity, Wi-Fi Direct, and Bluetooth

Your app can use a StreamSocket for network connections between devices that are within close range. Classes in the [Windows.Networking.Proximity](../windows.networking.proximity/windows_networking_proximity.md) namespace support network connections with a StreamSocket to nearby devices that use Bluetooth or Wi-Fi Direct. The [PeerFinder](../windows.networking.proximity/peerfinder.md) and related classes in the [ Windows.Networking.Proximity](../windows.networking.proximity/windows_networking_proximity.md) namespace let your app discover another instance of your app on a nearby device. The [PeerFinder.FindAllPeersAsync](../windows.networking.proximity/peerfinder_findallpeersasync_830195586.md) method browses for peer computers that are running the same app within wireless range. The [PeerFinder.ConnectAsync](../windows.networking.proximity/peerfinder_connectasync_380619906.md) method returns a connected StreamSocket that your app can use to transfer network data with the nearby peer app. For more information, see [Supporting proximity and tapping](/previous-versions/windows/apps/hh465229(v=win.10)), [Windows.Networking.Proximity](../windows.networking.proximity/windows_networking_proximity.md), [PeerFinder](../windows.networking.proximity/peerfinder.md), and the [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample).

Your app can also use a StreamSocket for network connections between devices that use Wi-Fi Direct with classes in the [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) namespace. The [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md) class can be used to locate other devices that have a Wi-Fi Direct (WFD) capable device. The [WiFiDirectDevice.GetDeviceSelector](../windows.devices.wifidirect/wifidirectdevice_getdeviceselector_185243134.md) method gets the device identifier for a nearby WFD device. Once you have a reference to a nearby WFD device, you can call the [WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs_1958888015.md) method to get an [EndpointPair](../windows.networking/endpointpair.md) object. The [ConnectAsync(EndpointPair)](streamsocket_connectasync_13692504.md) or [ConnectAsync(EndpointPair, SocketProtectionLevel)](streamsocket_connectasync_706428084.md) method on the StreamSocket class can then be used to establish a socket connection. For more information, see [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md) and [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md).

Bluetooth uses Bluetooth Service IDs as endpoints for StreamSocket connections, not hostnames or IP addresses. To use a StreamSocket with Bluetooth, the **bluetooth.rfcomm** device capability must be set in the app manifest. For more information, see the [Windows.Devices.Bluetooth.Rfcomm](../windows.devices.bluetooth.rfcomm/windows_devices_bluetooth_rfcomm.md) namespace, [How to specify device capabilities for Bluetooth](/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-bluetooth), and the [Bluetooth Rfcomm Chat sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Bluetooth%20Rfcomm%20Chat).

<!--<section  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
        <title>Using StreamSocket with Bluetooth and Wifi-Direct</title>
        <sectioncontents>
          <p>Your app can also use a <xref rid="w_net_sock.streamsocket" targtype="class_winrt">StreamSocket</xref> for network connections between devices that are within close range. Classes in the <xref rid="w_net_prox.windows_networking_proximity" targtype="namespace">Windows.Networking.Proximity</xref> namespace support network connections with a <xref rid="w_net_sock.streamsocket" targtype="class_winrt">StreamSocket</xref> that uses Bluetooth or Wi-Fi Direct to nearby devices. The <xref targtype="class_winrt" rid="w_net_prox.peerfinder">PeerFinder</xref> and related classes in the <xref rid="w_net_prox.windows_networking_proximity" targtype="namespace"> Windows.Networking.Proximity</xref> namespace let your app discover another instance of your app on a nearby device.  Your app can then create a <xref rid="w_net_sock.streamsocket" targtype="class_winrt">StreamSocket</xref> connection to the nearby peer app using a tap gesture or by browsing.  For more information, see <xref rid="m_proximity.tapping_portal" targtype="startpage" enabled="1">Supporting proximity and tapping</xref>, <xref rid="w_net_prox.windows_networking_proximity" targtype="namespace" enabled="1">Windows.Networking.Proximity</xref>, <xref targtype="class_winrt" rid="w_net_prox.peerfinder" enabled="1">PeerFinder</xref>, <xref targtype="namespace" rid="w_dvc_blue_rfcomm.windows_devices_bluetooth_rfcomm">Windows.Devices.Bluetooth.Rfcomm</xref>, the <xref hlink="http://go.microsoft.com/fwlink/p/?linkid=245082">Proximity sample</xref>, and the <xref hlink="http://go.microsoft.com/fwlink/p/?LinkID=306047">Bluetooth Rfcomm Chat sample</xref>.</p>
        </sectioncontents>
      </section>-->

### Using StreamSocket on Windows Server 2012

On Windows Server 2012 and Windows Server 2012 R2, the *Windows.Networking.dll* that implements most of the classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail to load unless the Media Foundation feature is enabled. As a result, apps that use StreamSocket and related socket classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail if the Media Foundation feature is disabled. Windows Server 2012 or Windows Server 2012 R2 installs with the Media Foundation feature disabled.

The Media Foundation feature can be enabled on Windows Server 2012 or Windows Server 2012 R2 using Server Manager or by entering the following text in a command prompt or a script:

`dism /online /enable-feature /featurename:ServerMediaFoundation `After the Media Foundation feature is enabled, the user is prompted to restart. Once the computer is restarted, classes for sockets and WebSockets in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will work as expected.

### Resolving DNS service records using StreamSocket

An app can communicate with the target DNS address that belongs to a SRV record.
For example, an extensible Messaging and Presence Protocol (XMPP) service in the Contoso domain corresponds to `_xmpp-client._tcp.contoso.com`.
That service name corresponds to a server DNS name, for example, `xmpp-client01.contoso.com`.

To connect to the DNS address for the server for that service, use the following method call on a StreamSocket instance:

```csharp
using Windows.Networking.Sockets;

StreamSocket socket = new StreamSocket();
socket.ConnectAsync(new HostName("contoso.com"), "xmpp-client");
```

The protocol is inferred to be TCP for StreamSocket instances. 
The method deals with the underscore characters.

A DNS can be configured to have an SRV hierarchy. 
A DNS SRV resource records could have the following form: `_xmpp-client._service01._tcp.contoso.com`. 
For this example, use the following method call on a StreamSocket instance:

```csharp
socket.ConnectAsync(new HostName("contoso.com"), "xmpp-client._service01");
```

These code snippets use [ConnectAsync](streamsocket_connectasync_1841953676.md).
The [GetEndpointPairsAsync](streamsocket_getendpointpairsasync_1796487528.md) method supports similar usage to connect to services.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | GetEndpointPairsAsync(HostName,String) |
| 1607 | 14393 | GetEndpointPairsAsync(HostName,String,HostNameSortOptions) |

## -examples

Sample applications that use this class include [Bluetooth RFCOMM chat sample](/samples/microsoft/windows-universal-samples/bluetoothrfcommchat/), [DatagramSocket sample (Windows 10)](/samples/microsoft/windows-universal-samples/datagramsocket/), [Socket activity trigger stream socket sample](/samples/microsoft/windows-universal-samples/socketactivitystreamsocket/), [StreamSocket sample (Windows 10)](/samples/microsoft/windows-universal-samples/streamsocket/), and [Wi-Fi Direct sample](/samples/microsoft/windows-universal-samples/wifidirect/).

## -see-also

[Connecting with sockets (XAML)](/previous-versions/windows/apps/hh452976(v=win.10)), [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)), [How to connect with a stream socket (HTML)](/previous-versions/windows/apps/hh452996(v=win.10)), [How to connect with a stream socket (XAML)](/previous-versions/windows/apps/jj150599(v=win.10)), [How to secure socket connections with TLS/SSL (HTML)](/previous-versions/windows/apps/hh780595(v=win.10)), [How to secure socket connections with TLS/SSL (XAML)](/previous-versions/windows/apps/jj150597(v=win.10)), [How to set background connectivity options](/previous-versions/windows/apps/hh771189(v=win.10)), [How to specify device capabilities for Bluetooth](/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-bluetooth), [How to use advanced socket controls (XAML)](/previous-versions/windows/apps/jj150598(v=win.10)), [Supporting proximity and tapping](/previous-versions/windows/apps/hh465229(v=win.10)), [Troubleshoot and debug network connections](/previous-versions/windows/apps/hh770534(v=win.10)), [ControlChannelTrigger](controlchanneltrigger.md), [IClosable](../windows.foundation/iclosable.md), [NetworkInformation.GetProxyConfigurationAsync](../windows.networking.connectivity/networkinformation_getproxyconfigurationasync_1451648549.md), [ProxyConfiguration.CanConnectDirectly](../windows.networking.connectivity/proxyconfiguration_canconnectdirectly.md), [PeerFinder](../windows.networking.proximity/peerfinder.md), [SetSocketMediaStreamingMode](/windows/desktop/api/socketapi/nf-socketapi-setsocketmediastreamingmode), [SocketError](socketerror.md), [SocketErrorStatus](socketerrorstatus.md), [StreamSocketControl](streamsocketcontrol.md), [StreamSocketInformation](datagramsocketinformation.md), [StreamSocketListener](streamsocketlistener.md), [StreamSocketListener.ConnectAsync](streamwebsocket_connectasync_682685111.md), [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md), [Windows.Devices.Bluetooth.Rfcomm](../windows.devices.bluetooth.rfcomm/windows_devices_bluetooth_rfcomm.md), [Windows.Devices.WiFiDirect](../windows.devices.wifidirect/windows_devices_wifidirect.md), [Windows.Networking.Proximity](../windows.networking.proximity/windows_networking_proximity.md), [Bluetooth Rfcomm Chat sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Bluetooth%20Rfcomm%20Chat), [ControlChannelTrigger StreamSocket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/ControlChannelTrigger%20StreamSocket%20sample), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample), [StreamSocket sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620609), [DatagramSocket sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620534), [Socket activity trigger stream socket sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SocketActivityStreamSocket)

## -capabilities

internetClient, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone], bluetooth.rfcomm