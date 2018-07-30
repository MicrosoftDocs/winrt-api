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

The [DatagramSocketControl](datagramsocketcontrol.md) class provides access to advanced socket control data on a [DatagramSocket](datagramsocket.md) object.

A [DatagramSocketControl](datagramsocketcontrol.md) object is automatically created with the parent [DatagramSocket](datagramsocket.md) object. The [DatagramSocket.Control](datagramsocket_control.md) property provides access to the associated [DatagramSocketControl](datagramsocketcontrol.md) object.

The [OutboundUnicastHopLimit](datagramsocketcontrol_outboundunicasthoplimit.md) property can be set before or after the [DatagramSocket](datagramsocket.md) is bound or connected. Before changing this value on a bound or connected [DatagramSocket](datagramsocket.md), any outgoing packets should first be flushed to ensure that all previously-written data is sent out with the previous hop limit.

Any changes to the other property values on the [DatagramSocketControl](datagramsocketcontrol.md) must be set before the [DatagramSocket](datagramsocket.md) is bound or connected. As a result if you need to make changes to the [DontFragment](datagramsocketcontrol_dontfragment.md), [InboundBufferSizeInBytes](datagramsocketcontrol_inboundbuffersizeinbytes.md), or [QualityOfService](datagramsocketcontrol_qualityofservice.md) properties, then these changes must occur before a successful call to the [BindEndpointAsync](datagramsocket_bindendpointasync.md), [BindServiceNameAsync](datagramsocket_bindservicenameasync.md), or one of the [ConnectAsync](datagramsocket_connectasync.md) methods on the [DatagramSocket](datagramsocket.md).

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

```cpp
using namespace Windows::Networking::Sockets;

DatagramSocket^ clientSocket = ref new DatagramSocket();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
auto currentSetting = clientSocket->Control->QualityOfService;

// Set QualityOfService to LowLatency.
clientSocket->Control->QualityOfService = SocketQualityOfService::LowLatency;

// Now you can call the ConnectAsync method to connect the DatagramSocket.
```

```javascript
var clientSocket = new Windows.Networking.Sockets.DatagramSocket();

// Get the current setting for this option
// This isn't required, but it shows how to get the current setting
var currentSetting = clientSocket.Control.QualityOfService; 

// Set QualityOfService to lowLatency
clientSocket.control.QualityOfService = SocketQualityOfService.lowLatency;
   
// Now you can call the ConnectAsync method to connect the DatagramSocket.
```

For more information on using [DatagramSocketControl](datagramsocketcontrol.md), see [How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4) and [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682).

## -examples

## -see-also

[How to use advanced socket controls  ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls  ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [DatagramSocket](datagramsocket.md), [DatagramSocket.Control](datagramsocket_control.md), [DatagramSocketInformation](datagramsocketinformation.md), [DatagramSocket sample](http://go.microsoft.com/fwlink/p/?LinkID=243037), [DatagramSocket sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DatagramSocket)

## -capabilities

ID_CAP_NETWORKING [Windows Phone]
