---
-api-id: T:Windows.Networking.Sockets.DatagramSocketControl
-api-type: winrt class
---

<!-- Class syntax.
public class DatagramSocketControl : Windows.Networking.Sockets.IDatagramSocketControl, Windows.Networking.Sockets.IDatagramSocketControl2, Windows.Networking.Sockets.IDatagramSocketControl3
-->

# Windows.Networking.Sockets.DatagramSocketControl

## -description

Provides socket control data on a [DatagramSocket](datagramsocket.md) object.

## -remarks

The DatagramSocketControl class provides access to advanced socket control data on a [DatagramSocket](datagramsocket.md) object.

A DatagramSocketControl object is automatically created with the parent [DatagramSocket](datagramsocket.md) object. The [DatagramSocket.Control](datagramsocket_control.md) property provides access to the associated DatagramSocketControl object.

The [OutboundUnicastHopLimit](datagramsocketcontrol_outboundunicasthoplimit.md) property can be set before or after the [DatagramSocket](datagramsocket.md) is bound or connected. Before changing this value on a bound or connected [DatagramSocket](datagramsocket.md), any outgoing packets should first be flushed to ensure that all previously-written data is sent out with the previous hop limit.

Any changes to the other property values on the DatagramSocketControl must be set before the [DatagramSocket](datagramsocket.md) is bound or connected. As a result if you need to make changes to the [DontFragment](datagramsocketcontrol_dontfragment.md), [InboundBufferSizeInBytes](datagramsocketcontrol_inboundbuffersizeinbytes.md), or [QualityOfService](datagramsocketcontrol_qualityofservice.md) properties, then these changes must occur before a successful call to the [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md), [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md), or one of the [ConnectAsync](datagramsocket_connectasync_13692504.md) methods on the [DatagramSocket](datagramsocket.md).

The following example creates a [DatagramSocket](datagramsocket.md), and then demonstrates how to set the [QualityOfService](datagramsocketcontrol_qualityofservice.md) property to **LowLatency**. Other properties may be set in a similar manner. After this is done, the app can connect the [DatagramSocket](datagramsocket.md) or send data on the socket.

```csharp
using Windows.Networking.Sockets;

DatagramSocket clientSocket = new DatagramSocket();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
var currentSetting = clientSocket.Control.QualityOfService;

// Set QualityOfService to LowLatency.
clientSocket.Control.QualityOfService = SocketQualityOfService.LowLatency;

// Now you can call the ConnectAsync method to connect the DatagramSocket.
```

```cppwinrt
#include <winrt/Windows.Networking.Sockets.h>
using namespace winrt;
...
Windows::Networking::Sockets::DatagramSocket clientSocket;

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
auto currentSetting{ clientSocket.Control().QualityOfService() };

// Set QualityOfService to LowLatency.
clientSocket.Control().QualityOfService(Windows::Networking::Sockets::SocketQualityOfService::LowLatency);

// Now you can call the ConnectAsync function to connect the DatagramSocket.
```

```cppcx
using namespace Windows::Networking::Sockets;

DatagramSocket^ clientSocket = ref new DatagramSocket();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
auto currentSetting = clientSocket->Control->QualityOfService;

// Set QualityOfService to LowLatency.
clientSocket->Control->QualityOfService = SocketQualityOfService::LowLatency;

// Now you can call the ConnectAsync method to connect the DatagramSocket.
```
For more information on using DatagramSocketControl, see [How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)).

## -examples

## -see-also

[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [DatagramSocket](datagramsocket.md), [DatagramSocket.Control](datagramsocket_control.md), [DatagramSocketInformation](datagramsocketinformation.md), [DatagramSocket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/DatagramSocket%20sample), [DatagramSocket sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DatagramSocket)

## -capabilities

ID_CAP_NETWORKING [Windows Phone]
