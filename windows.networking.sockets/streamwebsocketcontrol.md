---
-api-id: T:Windows.Networking.Sockets.StreamWebSocketControl
-api-type: winrt class
---

<!-- Class syntax.
public class StreamWebSocketControl : Windows.Networking.Sockets.IStreamWebSocketControl, Windows.Networking.Sockets.IWebSocketControl, Windows.Networking.Sockets.IWebSocketControl2
-->

# Windows.Networking.Sockets.StreamWebSocketControl

## -description

Provides socket control data on a [StreamWebSocket](streamwebsocket.md) object.

## -remarks

The [StreamWebSocketControl](streamwebsocketcontrol.md) class provides access to advanced socket control data on a [StreamWebSocket](streamwebsocket.md) object.

A [StreamWebSocketControl](streamwebsocketcontrol.md) object is automatically created with the parent [StreamWebSocket](streamwebsocket.md) object. The [StreamWebSocket.Control](streamwebsocket_control.md) property provides access to the associated [StreamWebSocketControl](streamwebsocketcontrol.md) object.

Any changes to the [StreamWebSocketControl](streamwebsocketcontrol.md) property values must be set before the [StreamWebSocket](streamwebsocket.md) is connected. As a result if you need to make changes to the [NoDelay](streamwebsocketcontrol_nodelay.md), [OutboundBufferSizeInBytes](streamwebsocketcontrol_outboundbuffersizeinbytes.md), [ProxyCredential](streamwebsocketcontrol_proxycredential.md), [ServerCredential](streamwebsocketcontrol_servercredential.md), or [SupportedProtocols](streamwebsocketcontrol_supportedprotocols.md) properties, then these changes must occur before a successful call to the [ConnectAsync](streamsocket_connectasync_13692504.md) method on the [StreamWebSocket](streamwebsocket.md).

The following example creates a [StreamWebSocket](streamwebsocket.md), and then demonstrates how to set the [StreamWebSocketControl.NoDelay](streamwebsocketcontrol_nodelay.md) property to **false**. (Other properties may be set in a similar manner.) After this is done, the app can connect the [StreamWebSocket](streamwebsocket.md).

```csharp
using Windows.Networking.Sockets;

StreamWebSocket clientWebSocket = new StreamWebSocket();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
bool currentSetting = clientWebSocket.Control.NoDelay;

// Set NoDelay to false so that the Nagle algorithm is not disabled.
clientWebSocket.Control.NoDelay = false;

// Now you can call the ConnectAsync method to connect the StreamWebSocket.
```

```cppwinrt
#include <winrt/Windows.Networking.Sockets.h>
using namespace winrt;
...
Windows::Networking::Sockets::StreamWebSocket clientWebSocket;

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
bool currentSetting{ clientWebSocket.Control().NoDelay() };

// Set NoDelay to false so that the Nagle algorithm is not disabled.
clientWebSocket.Control().NoDelay(false);

// Now you can call the ConnectAsync method to connect the StreamWebSocket.
```

```cpp
using namespace Windows::Networking::Sockets;

StreamWebSocket^ clientWebSocket = ref new StreamWebSocket();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting .
bool currentSetting = clientWebSocket->Control->NoDelay;

// Set NoDelay to false so that the Nagle algorithm is not disabled.
clientWebSocket->Control->NoDelay = false;

// Now you can call the ConnectAsync method to connect the StreamWebSocket.
```

```javascript
var clientWebSocket = new Windows.Networking.Sockets.StreamWebSocket();

// Get the current setting for this option
// This isn't required, but it shows how to get the current setting
var currentSetting = clientWebSocket.control.noDelay; 

// Set noDelay to false so that the Nagle algorithm is not disabled
clientWebSocket.control.noDelay = false;
   
// Now you can call the ConnectAsync method to connect the StreamWebSocket.
```

For more information about using [StreamWebSocketControl](streamwebsocketcontrol.md), see [How to use advanced WebSocket controls ](https://msdn.microsoft.com/library/0a47f7c3-66f9-4315-886e-bd1afe77bf39) and [How to use advanced WebSocket controls ](https://msdn.microsoft.com/library/4ab9621e-90e5-420e-88d0-09f1c7239d7a).

## -examples

## -see-also

[How to use advanced WebSocket controls ](https://msdn.microsoft.com/library/0a47f7c3-66f9-4315-886e-bd1afe77bf39),
[How to use advanced WebSocket controls ](https://msdn.microsoft.com/library/4ab9621e-90e5-420e-88d0-09f1c7239d7a),
[StreamWebSocket](streamwebsocket.md),
[StreamWebSocketControl](streamwebsocketcontrol.md),
[StreamWebSocketInformation](streamwebsocketinformation.md),
[WebSockets](/windows/uwp/networking/websockets?branch=live),
[WebSocket sample](https://go.microsoft.com/fwlink/p/?LinkId=620623),
[ControlChannelTrigger StreamWebSocket sample](https://go.microsoft.com/fwlink/p/?linkid=251232)

## -capabilities

internetClient, privateNetworkClientServer
