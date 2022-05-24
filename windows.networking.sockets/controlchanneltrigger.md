---
-api-id: T:Windows.Networking.Sockets.ControlChannelTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class ControlChannelTrigger : Windows.Foundation.IClosable, Windows.Networking.Sockets.IControlChannelTrigger, Windows.Networking.Sockets.IControlChannelTrigger2
-->

# Windows.Networking.Sockets.ControlChannelTrigger

## -description
Enables real time notifications to be received in the background for objects that establish a TCP connection and wish to be notified of incoming traffic.

Call [**BackgroundExecutionManager.RequestAccessAsync**](../windows.applicationmodel.background/backgroundexecutionmanager_requestaccessasync_1328635663.md) before using **ControlChannelTrigger**.

> [!NOTE]
> This class is not supported on Windows Phone.

## -remarks
The ControlChannelTrigger class and related interfaces are used to enable your app to use the network when your app is not the foreground app. A Universal Windows app is normally suspended when it is no longer in the foreground app and moved to the background. There are some exceptions to suspending an app (actively printing, accessing an audio stream, and transferring files in the background, for example). The ControlChannelTrigger class allows a network app that has established a TCP connection to notify the system that an established network connection should be kept operational and the system should wake up the suspended app when network data is received for the app or the server keep-alive timer interval expires. Use control channel triggers when your app needs to maintain a network connection even if it is in the background.

While the ControlChannelTrigger class can be used with [DatagramSocket](datagramsocket.md), [StreamSocket](streamsocket.md), or [StreamSocketListener](streamsocketlistener.md), Windows 10 provides an improved mechanism for apps that use those classes and want to maintain connections while in the background. See [Network communications in the background](/windows/uwp/networking/network-communications-in-the-background) for details about [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md) and the socket broker.

The ControlChannelTrigger class is recommended to be used by instances of the following that establish a TCP connection:

+ The [HttpClient](../windows.web.http/httpclient.md) class in the [Windows.Web.Http](../windows.web.http/windows_web_http.md) namespace.
+ The [HttpClient](/dotnet/api/system.net.http.httpclient?view=dotnet-uwp-10.0&preserve-view=true) and [HttpClientHandler](/dotnet/api/system.net.http.httpclienthandler?view=dotnet-uwp-10.0&preserve-view=true) classes in the [System.Net.Http](/dotnet/api/system.net.http?view=dotnet-uwp-10.0&preserve-view=true) namespace in the .NET Framework. Custom classes that derive from these classes are also supported.
+ The [IXMLHTTPRequest2](/previous-versions/windows/desktop/api/msxml6/nn-msxml6-ixmlhttprequest2) interface. The [IXMLHTTPRequest2](/previous-versions/windows/desktop/api/msxml6/nn-msxml6-ixmlhttprequest2) interface is an extension to XMLHttpRequest object defined in several working drafts published by the World Wide Web Consortium (W3C)

There are several types of keep-alive intervals that may relate to network apps. At the lowest level, an app can set a TCP keep-alive option to send TCP keep-alive packets between a client app and a server to maintain an established TCP connection that is not being used. The [HttpClient](/dotnet/api/system.net.http.httpclient?view=dotnet-uwp-10.0&preserve-view=true) class and the XMLHttpRequest JavaScript object do not have an option to enable TCP keep-alive and this option is disabled by default. The TCP keep-alive must be disabled in order to use the ControlChannelTrigger class to support background network notifications.

In the context of the ControlChannelTrigger class, there are two other keep-alive intervals that have an impact.

+ Server keep-alive interval - This refers to a keep-alive interval in minutes that the app registers with the system for how often to be woken up when the app has been suspended. The system will wake up the app based on the value set for this keep-alive interval. This value is represented by the [ServerKeepAliveIntervalInMinutes](controlchanneltrigger_serverkeepaliveintervalinminutes.md) property on a ControlChannelTrigger class and is set as an argument to the ControlChannelTrigger constructor. This value is considered a server keep-alive interval since a network app might normally set this based on known behavior of the server to which the app has established a TCP connection. For example, if it is known that a web server will disconnect and drop TCP connections if there is no data sent by the app for 30 minutes, the network app could set this server keep-alive interval to 25 minutes.
+ Network keep-alive interval - This refers to an internal keep-alive timer maintained by low-level network components in the TCP stack based on current network conditions. This value represents the value needed by network intermediaries to keep the TCP connection intact. These network intermediaries represent hardware and devices such as network proxies and network address translators. A network app cannot set this value, since this value is determined dynamically by low-level system components in the TCP stack. The internal calculation of the network keep-alive interval does take account of the server keep-alive interval. A network app can indicate to the system that the network keep-alive timer should be decreased if established TCP connections are regularly dropped by calling the [DecreaseNetworkKeepAliveInterval](controlchanneltrigger_decreasenetworkkeepaliveinterval_1909166565.md) method on a ControlChannelTrigger class.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IsWakeFromLowPowerSupported |

## -examples

## -see-also
[Networking basics](/windows/uwp/networking/networking-basics), [Network communications in the background](/windows/uwp/networking/network-communications-in-the-background), [IXMLHTTPRequest2](/previous-versions/windows/desktop/api/msxml6/nn-msxml6-ixmlhttprequest2), [IClosable](../windows.foundation/iclosable.md), [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md), [System.Net.Http](/dotnet/api/system.net.http?view=dotnet-uwp-10.0&preserve-view=true), [System.Net.Http.HttpClient](/dotnet/api/system.net.http.httpclient?view=dotnet-uwp-10.0&preserve-view=true), [System.Net.Http.HttpClientHandler](/dotnet/api/system.net.http.httpclienthandler?view=dotnet-uwp-10.0&preserve-view=true), [Windows.Web.Http](../windows.web.http/windows_web_http.md), [Windows.Web.Http.HttpClient](../windows.web.http/httpclient.md), [Background task sample](https://go.microsoft.com/fwlink/p/?LinkId=618666)