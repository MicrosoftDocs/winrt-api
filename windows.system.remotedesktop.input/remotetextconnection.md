---
-api-id: T:Windows.System.RemoteDesktop.Input.RemoteTextConnection
-api-type: winrt class
---

# Windows.System.RemoteDesktop.Input.RemoteTextConnection

<!--
public sealed class RemoteTextConnection : System.IDisposable
-->

## -description

Represents a connection between a Remote Desktop client application and the local computer's text input system. This connection can be used to enable text input virtualization.

## -remarks

**RemoteTextConnection** is designed to enable text input virtualization with remote applications integrated with a local desktop. This scenario is called *Remote Programs* or *Remote Applications Integrated Locally (RAIL)*. Using **RemoteTextConnection** with full desktop remoting is not currently recommended and may result in undesirable behavior. When text input virtualization is enabled, built-in input methods provided by Windows (including IMEs) can be used for entering text in remote applications.

To enable text input virtualization, a Remote Desktop client application creates one **RemoteTextConnection** object for each remote session it connects to. Data packets are delivered through this object to and from the local computer's text input system in the following ways:

- The text input system sends data packets to the Remote Desktop client application via the [RemoteTextConnectionDataHandler](remotetextconnectiondatahandler.md) delegate. The Remote Desktop client application is responsible for creating this delegate and passing it to the [RemoteTextConnection](remotetextconnection_remotetextconnection_1474280690.md) constructor. The data packets from the text input system will conform to the RDP text input virtualization protocol. Messages received on this delegate will arrive on a background thread. When the client application receives data packets from the delegate, it should forward the packets to the remote RAIL server via the unidirectional, client-to-server [Dynamic Virtual Channel (DVC)](/windows/win32/termserv/dynamic-virtual-channels) for virtualized text input. This DVC is named `TextInput_ClientToServerDVC`.

- The Remote Desktop client application also needs to listen for data packets from the remote machine on the server-to-client text input DVC (named `TextInput_ServerToClientDVC`) and forward those data packets to the local computer's text input system via the [ReportDataReceived](remotetextconnection_reportdatareceived_1719701080.md) method. For more information about how Remote Desktop client applications support DVCs, see [Dynamic Virtual Channel (DVC)](/windows/win32/termserv/dynamic-virtual-channels) and the [tsvirtualchannels.h header file](/windows/win32/api/tsvirtualchannels/).

The only local input methods that **RemoteTextConnection** will integrate with remote applications are built-in input methods provided by Windows that use the next version of the [Text Services Framework](/windows/win32/tsf/text-services-framework) (including IMEs). These input methods are hosted by the text input system in a centralized process making integration feasible. Older Text Services Framework version 1 or IMM IMEs are not hosted in a centralized process and are not supported by text input virtualization. These older input methods must be installed directly on a remote system in order to work with applications remoted from that system. This is the same way Text Services Framework version 1 and IMM input methods are utilized when text input virtualization is not used.

## -see-also

[Dynamic Virtual Channel (DVC)](/windows/win32/termserv/dynamic-virtual-channels)

## -examples


