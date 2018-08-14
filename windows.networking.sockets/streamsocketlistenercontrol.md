---
-api-id: T:Windows.Networking.Sockets.StreamSocketListenerControl
-api-type: winrt class
---

<!-- Class syntax.
public class StreamSocketListenerControl : Windows.Networking.Sockets.IStreamSocketListenerControl, Windows.Networking.Sockets.IStreamSocketListenerControl2
-->

# Windows.Networking.Sockets.StreamSocketListenerControl

## -description
Provides socket control data on a [StreamSocketListener](streamsocketlistener.md) object.

## -remarks
The [StreamSocketListenerControl](streamsocketlistenercontrol.md) class provides access to advanced socket control data on a [StreamSocketListener](streamsocketlistener.md) object.

A [StreamSocketListenerControl](streamsocketlistenercontrol.md) object is automatically created with the parent [StreamSocketListener](streamsocketlistener.md) object. The [StreamSocketListener.Control](streamsocketlistener_control.md) property provides access to the associated [StreamSocketListenerControl](streamsocketlistenercontrol.md) object.

Any changes to the [StreamSocketListenerControl](streamsocketlistenercontrol.md) property values must be set before the [StreamSocketListener](streamsocketlistener.md) is bound. So changes to the [QualityOfService](streamsocketlistenercontrol_qualityofservice.md) property must be set before the [BindServiceNameAsync](streamsocketlistener_bindservicenameasync_1713574846.md) or [BindEndpointAsync](streamsocketlistener_bindendpointasync_1396029045.md) method is called on the [StreamSocketListener](streamsocketlistener.md).

The following example creates a [StreamSocketListener](streamsocketlistener.md), and then demonstrates how to set the [QualityOfService](datagramsocketcontrol_qualityofservice.md) property to **LowLatency**. After this is done, the app can bind and listen on the [StreamSocketListener](streamsocketlistener.md).

```csharp
using Windows.Networking.Sockets;

StreamSocketListener listenerSocket = new StreamSocketListener();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
var currentSetting = listenerSocket.Control.QualityOfService;

// Set QualityOfService to LowLatency.
listenerSocket.Control.QualityOfService = SocketQualityOfService.LowLatency;

// Now you can call the BindServiceNameAsync or BindEndpointAsync method to listen for connections.
```

```cppwinrt
#include <winrt/Windows.Networking.Sockets.h>
using namespace winrt;
...
Windows::Networking::Sockets::StreamSocketListener listenerSocket;

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
auto currentSetting{ listenerSocket.Control().QualityOfService() };

// Set QualityOfService to LowLatency.
listenerSocket.Control().QualityOfService(Windows::Networking::Sockets::SocketQualityOfService::LowLatency);

// Now you can call the BindServiceNameAsync or BindEndpointAsync method to listen for connections.
```

```cpp
using namespace Windows::Networking::Sockets;

StreamSocketListener^ listenerSocket = ref new StreamSocketListener();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
auto currentSetting = listenerSocket->Control->QualityOfService;

// Set QualityOfService to LowLatency.
listenerSocket->Control->QualityOfService = SocketQualityOfService::LowLatency;

// Now you can call the BindServiceNameAsync or BindEndpointAsync method to listen for connections.
```

```javascript
var listenerSocket = new Windows.Networking.Sockets.StreamSocketListener();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
var currentSetting = listenerSocket.Control.QualityOfService; 

// Set QualityOfService to lowLatency.
listenerSocket.Control.QualityOfService = SocketQualityOfService.lowLatency;
   
// Now you can call the BindServiceNameAsync or BindEndpointAsync method to listen for connections.
```

For more information on using [StreamSocketListenerControl](streamsocketlistenercontrol.md), see [How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4) and [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682).

## -examples

## -see-also
[Connecting with sockets ](http://msdn.microsoft.com/library/67cfa78f-570f-4dd4-a0f2-cd6c891f5446), [Connecting with sockets ](http://msdn.microsoft.com/library/2a6448d0-e21f-4963-bca5-aae001ae4fc7), [How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [StreamSocketListener](streamsocketlistener.md), [StreamSocketListener.Control](streamsocketlistener_control.md), [StreamSocketListenerInformation](streamsocketlistenerinformation.md), [Bluetooth Rfcomm Chat sample](http://go.microsoft.com/fwlink/p/?LinkID=306047), [ControlChannelTrigger StreamSocket sample](http://go.microsoft.com/fwlink/p/?linkid=243039), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082), [StreamSocket sample](http://go.microsoft.com/fwlink/p/?linkid=243037)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
