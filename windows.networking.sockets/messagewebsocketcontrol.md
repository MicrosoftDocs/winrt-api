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
The [MessageWebSocketControl](messagewebsocketcontrol.md) class provides access to advanced socket control data on a [MessageWebSocket](messagewebsocket.md) object.

A [MessageWebSocketControl](messagewebsocketcontrol.md) object is automatically created with the parent [MessageWebSocket](messagewebsocket.md) object. The [MessageWebSocket.Control](messagewebsocket_control.md) property provides access to the associated [MessageWebSocket](messagewebsocket.md) object.

The [SupportedProtocols](messagewebsocketcontrol_supportedprotocols.md) property gets the value of this property and can be called at any time.

The [MessageType](messagewebsocketcontrol_messagetype.md) property can be changed at any time before or after the [MessageWebSocket](messagewebsocket.md) is connected. This allows an app to switch between binary and UTF-8 messages when needed.

The [OutboundBufferSizeInBytes](messagewebsocketcontrol_outboundbuffersizeinbytes.md) property must be set before the [MessageWebSocket](messagewebsocket.md) is connected. Setting this property after the [MessageWebSocket](messagewebsocket.md) is connected has no effect.

Any changes to the other property values on the [MessageWebSocketControl](messagewebsocketcontrol.md) must be set before the [DatagramSocket](datagramsocket.md) is bound or connected. As a result if you need to make changes to the [MaxMessageSize](messagewebsocketcontrol_maxmessagesize.md), [ProxyCredential](messagewebsocketcontrol_proxycredential.md), [OutboundBufferSizeInBytes](messagewebsocketcontrol_outboundbuffersizeinbytes.md), or [ServerCredential](messagewebsocketcontrol_servercredential.md) properties, then these changes must occur before a successful call to the [ConnectAsync](messagewebsocket_connectasync.md) method on the [MessageWebSocket](messagewebsocket.md).

The following example creates a [MessageWebSocket](messagewebsocket.md), and then demonstrates how to set the [MessageWebSocketControl.MessageType](messagewebsocketcontrol_messagetype.md) property to **binary**. (Other properties may be set in a similar manner.) After this is done, the app can connect the [MessageWebSocket](messagewebsocket.md).





```javascript
var clientWebSocket = new Windows.Networking.Sockets.MessageWebSocket();

// Get the current setting for this option
// This isn't required, but it shows how to get the current setting
var currentSetting = clientWebSocket.control.messageType;

// Set messageType to binary 
clientWebSocket.control.messageType = Windows.Networking.Sockets.SocketMessageType.binary;
   
// Now you can call the ConnectAsync method to connect the MessageWebSocket.

```

```cpp

using namespace Windows::Networking::Sockets;

MessageWebSocket^ clientWebSocket = ref new MessageWebSocket();

// Get the current setting for this option
// This isn't required, but it shows how to get the current setting
SocketMessageType currentSetting = clientWebSocket->Control->MessageType;

// Set messageType to binary 
clientWebSocket->Control->MessageType = SocketMessageType::Binary;

// Now you can call the ConnectAsync method to connect the MessageWebSocket.
```

```csharp
using Windows.Networking.Sockets;

MessageWebSocket clientWebSocket = new MessageWebSocket();

// Get the current setting for this option
// This isn't required, but it shows how to get the current setting
SocketMessageType currentSetting = clientWebSocket.Control.MessageType;

// Set messageType to binary 
clientWebSocket.Control.MessageType = SocketMessageType.Binary;

// Now you can call the ConnectAsync method to connect the MessageWebSocket.

```



For more information on using [MessageWebSocketControl](messagewebsocketcontrol.md), see [How to use advanced WebSocket controls ](http://msdn.microsoft.com/library/0a47f7c3-66f9-4315-886e-bd1afe77bf39) and [How to use advanced WebSocket controls ](http://msdn.microsoft.com/library/4ab9621e-90e5-420e-88d0-09f1c7239d7a).

## -examples

## -see-also
[How to use advanced WebSocket controls ](http://msdn.microsoft.com/library/0a47f7c3-66f9-4315-886e-bd1afe77bf39), [How to use advanced WebSocket controls ](http://msdn.microsoft.com/library/4ab9621e-90e5-420e-88d0-09f1c7239d7a), [MessageWebSocket](messagewebsocket.md), [MessageWebSocket.Control](messagewebsocket_control.md), [MessageWebSocketInformation](messagewebsocketinformation.md), [Connecting with WebSockets sample](http://go.microsoft.com/fwlink/p/?linkid=239964)