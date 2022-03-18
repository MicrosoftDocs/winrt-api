---
-api-id: N:Windows.Networking
-api-type: winrt namespace
---

# Windows.Networking

## -description

Provides access to hostnames and endpoints used by network apps.

## -remarks

The Windows.Networking namespace provides classes that are used to initialize and provide data for a hostname or IP address and for a network endpoint pair used in network apps. The [HostName](hostname.md) and [EndpointPair](endpointpair.md) objects are used by many classes in other related namespaces. These include the following:

+ Classes in the [Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md) namespace used for network apps using sockets and WebSockets.
+ The [NetworkInformation](../windows.networking.connectivity/networkinformation.md) Class in the [Windows.Networking.Connectivity](../windows.networking.connectivity/windows_networking_connectivity.md) namespace.

On Windows Server 2012, the *Windows.Networking.dll* that implements the classes in the Windows.Networking namespace will fail to load unless the Media Foundation feature is enabled. As a result, apps using classes in the Windows.Networking namespace will fail if the Media Foundation feature is disabled (the default on Windows Server 2012).

The Media Foundation feature can be enabled on Windows Server 2012 using Server Manager or by entering the follow command in a CMD window or a script.

`dism /online /enable-feature /featurename:ServerMediaFoundation `The user is prompted to reboot after the Media Foundation feature is enabled on Windows Server 2012. Once the computer is rebooted, classes in the Windows.Networking namespace will work as expected.

### Using network isolation

The network isolation feature in Windows 8 enables a developer to fully control the network access of a UWP app. Not all apps may require access to the network. However for those apps that do, the Windows 8 provides different levels of access to the network that can be enabled by selecting appropriate capabilities.

Network isolation allows a developer to define for each app the scope of required network access. An app without the appropriate scope defined is prevented from accessing the specified type of network, and specific type of network request (outbound client-initiated requests or both inbound unsolicited requests and outbound client-initiated requests). The ability to set and enforce network isolation ensures that if an app does get compromised, it can only access networks where the app has explicitly been granted access. This significantly reduces the scope of the impact on other apps and on Windows.

Network isolation affects any methods and properties in the [Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md), [Windows.Networking.BackgroundTransfer](../windows.networking.backgroundtransfer/windows_networking_backgroundtransfer.md), [Windows.Web.AtomPub](../windows.web.atompub/windows_web_atompub.md), and [Windows.Web.Syndication](../windows.web.syndication/windows_web_syndication.md) namespaces that try to access the network. Windows actively enforces network isolation. A call to a method or any access to a property in these namespaces that results in network access may fail because of network isolation if the appropriate network capability has not been enabled.

The network capabilities for an app are configured in the app manifest when the app is built. Network capabilities are usually added using Microsoft Visual Studio 2012 when developing the app. Network capabilities may also be set manually in the app manifest file using a text editor.

<!--For more information, see <xref targtype="ovw" rid="m_getstarted.adding_capabilities__controls__and_layout_to_your_app"  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">Adding Capabilities, Controls, and Layout to Your App</xref>.-->
For more detailed information on network isolation, see the [How to configure network isolation capabilities](/previous-versions/windows/apps/hh770532(v=win.10)).

## -examples

## -see-also

[How to configure network isolation capabilities](/previous-versions/windows/apps/hh770532(v=win.10)), [Windows.Networking.BackgroundTransfer](../windows.networking.backgroundtransfer/windows_networking_backgroundtransfer.md), [Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md), [Windows.Web.AtomPub](../windows.web.atompub/windows_web_atompub.md), [Windows.Web.Syndication](../windows.web.syndication/windows_web_syndication.md), [StreamSocket sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/StreamSocket), [DatagramSocket sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620534)
