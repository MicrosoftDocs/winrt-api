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

The StreamWebSocketControl class provides access to advanced socket control data on a [StreamWebSocket](streamwebsocket.md) object.

A StreamWebSocketControl object is automatically created with the parent [StreamWebSocket](streamwebsocket.md) object. The [StreamWebSocket.Control](streamwebsocket_control.md) property provides access to the associated StreamWebSocketControl object.

Any changes to the StreamWebSocketControl property values must be set before the [StreamWebSocket](streamwebsocket.md) is connected. As a result if you need to make changes to the [NoDelay](streamwebsocketcontrol_nodelay.md), [OutboundBufferSizeInBytes](streamwebsocketcontrol_outboundbuffersizeinbytes.md), [ProxyCredential](streamwebsocketcontrol_proxycredential.md), [ServerCredential](streamwebsocketcontrol_servercredential.md), or [SupportedProtocols](streamwebsocketcontrol_supportedprotocols.md) properties, then these changes must occur before a successful call to the [ConnectAsync](streamsocket_connectasync_13692504.md) method on the [StreamWebSocket](streamwebsocket.md).

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

```cppcx
using namespace Windows::Networking::Sockets;

StreamWebSocket^ clientWebSocket = ref new StreamWebSocket();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting .
bool currentSetting = clientWebSocket->Control->NoDelay;

// Set NoDelay to false so that the Nagle algorithm is not disabled.
clientWebSocket->Control->NoDelay = false;

// Now you can call the ConnectAsync method to connect the StreamWebSocket.
```

For more information about using StreamWebSocketControl, see [How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IgnorableServerCertificateErrors |
| 1709 | 16299 | ActualUnsolicitedPongInterval |
| 1709 | 16299 | ClientCertificate |
| 1709 | 16299 | DesiredUnsolicitedPongInterval |

## -examples

## -see-also

[How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)),
[StreamWebSocket](streamwebsocket.md),
StreamWebSocketControl,
[StreamWebSocketInformation](streamwebsocketinformation.md),
[WebSockets](/windows/uwp/networking/websockets),
[WebSocket sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebSocket),
[ControlChannelTrigger StreamWebSocket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/ControlChannelTrigger%20StreamWebSocket%20sample/C%23)

## -capabilities

internetClient, privateNetworkClientServer
