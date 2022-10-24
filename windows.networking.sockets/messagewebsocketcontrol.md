---
-api-id: T:Windows.Networking.Sockets.MessageWebSocketControl
-api-type: winrt class
---

<!-- Class syntax.
public class MessageWebSocketControl : Windows.Networking.Sockets.IMessageWebSocketControl, Windows.Networking.Sockets.IWebSocketControl, Windows.Networking.Sockets.IWebSocketControl2
-->

# Windows.Networking.Sockets.MessageWebSocketControl

## -description
Provides socket control data on a [MessageWebSocket](messagewebsocket.md).

## -remarks
The MessageWebSocketControl class provides access to advanced socket control data on a [MessageWebSocket](messagewebsocket.md) object.

A MessageWebSocketControl object is automatically created with the parent [MessageWebSocket](messagewebsocket.md) object. The [MessageWebSocket.Control](messagewebsocket_control.md) property provides access to the associated [MessageWebSocket](messagewebsocket.md) object.

The [SupportedProtocols](messagewebsocketcontrol_supportedprotocols.md) property gets the value of this property and can be called at any time.

The [MessageType](messagewebsocketcontrol_messagetype.md) property can be changed at any time before or after the [MessageWebSocket](messagewebsocket.md) is connected. This allows an app to switch between binary and UTF-8 messages when needed.

The [OutboundBufferSizeInBytes](messagewebsocketcontrol_outboundbuffersizeinbytes.md) property must be set before the [MessageWebSocket](messagewebsocket.md) is connected. Setting this property after the [MessageWebSocket](messagewebsocket.md) is connected has no effect.

Any changes to the other property values on the MessageWebSocketControl must be set before the [DatagramSocket](datagramsocket.md) is bound or connected. As a result if you need to make changes to the [MaxMessageSize](messagewebsocketcontrol_maxmessagesize.md), [ProxyCredential](messagewebsocketcontrol_proxycredential.md), [OutboundBufferSizeInBytes](messagewebsocketcontrol_outboundbuffersizeinbytes.md), or [ServerCredential](messagewebsocketcontrol_servercredential.md) properties, then these changes must occur before a successful call to the [ConnectAsync](messagewebsocket_connectasync_682685111.md) method on the [MessageWebSocket](messagewebsocket.md).

The following example creates a [MessageWebSocket](messagewebsocket.md), and then demonstrates how to set the [MessageWebSocketControl.MessageType](messagewebsocketcontrol_messagetype.md) property to **binary**. (Other properties may be set in a similar manner.) After this is done, the app can connect the [MessageWebSocket](messagewebsocket.md).

```csharp
using Windows.Networking.Sockets;

MessageWebSocket clientWebSocket = new MessageWebSocket();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
SocketMessageType currentSetting = clientWebSocket.Control.MessageType;

// Set messageType to Binary.
clientWebSocket.Control.MessageType = SocketMessageType.Binary;

// Now you can call the ConnectAsync method to connect the MessageWebSocket.
```

```cppwinrt
#include <winrt/Windows.Networking.Sockets.h>
using namespace winrt;
...
Windows::Networking::Sockets::MessageWebSocket clientSocket;

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
auto currentSetting{ clientSocket.Control().MessageType() };

// Set QualityOfService to Binary.
clientSocket.Control().MessageType(Windows::Networking::Sockets::SocketMessageType::Binary);

// Now you can call the ConnectAsync function to connect the MessageWebSocket.
```

```cppcx
using namespace Windows::Networking::Sockets;

MessageWebSocket^ clientWebSocket = ref new MessageWebSocket();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
SocketMessageType currentSetting = clientWebSocket->Control->MessageType;

// Set messageType to Binary.
clientWebSocket->Control->MessageType = SocketMessageType::Binary;

// Now you can call the ConnectAsync method to connect the MessageWebSocket.
```

For more information on using MessageWebSocketControl, see [How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IgnorableServerCertificateErrors |
| 1709 | 16299 | ActualUnsolicitedPongInterval |
| 1709 | 16299 | ClientCertificate |
| 1709 | 16299 | DesiredUnsolicitedPongInterval |
| 1709 | 16299 | ReceiveMode |

## -examples

## -see-also

[How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)),
[MessageWebSocket](messagewebsocket.md),
[MessageWebSocket.Control](messagewebsocket_control.md),
[MessageWebSocketInformation](messagewebsocketinformation.md),
[WebSockets](/windows/uwp/networking/websockets),
[WebSocket sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebSocket)
