---
-api-id: T:Windows.Networking.Sockets.StreamWebSocketInformation
-api-type: winrt class
---

<!-- Class syntax.
public class StreamWebSocketInformation : Windows.Networking.Sockets.IWebSocketInformation, Windows.Networking.Sockets.IWebSocketInformation2
-->

# Windows.Networking.Sockets.StreamWebSocketInformation

## -description
Provides socket information on a [StreamWebSocket](streamwebsocket.md) object.

## -remarks
[StreamWebSocketInformation](streamwebsocketinformation.md) can be called any time after the [StreamWebSocket](streamwebsocket.md) has been created.

A [StreamWebSocketInformation](streamwebsocketinformation.md) object is automatically created with the parent [StreamWebSocket](streamwebsocket.md) object. The [StreamWebSocket.Information](streamwebsocket_information.md) property provides access to the associated [StreamWebSocketInformation](streamwebsocketinformation.md) object.



## -examples

## -see-also
[How to use advanced WebSocket controls](http://msdn.microsoft.com/library/0a47f7c3-66f9-4315-886e-bd1afe77bf39),
[How to use advanced WebSocket controls](http://msdn.microsoft.com/library/4ab9621e-90e5-420e-88d0-09f1c7239d7a),
[StreamWebSocket](streamwebsocket.md),
[StreamWebSocket.Information](streamwebsocket_information.md),
[StreamWebSocketControl](streamwebsocketcontrol.md),
[ControlChannelTrigger StreamWebSocket sample](http://go.microsoft.com/fwlink/p/?linkid=251232),
[WebSockets](/windows/uwp/networking/websockets?branch=live)

## -capabilities
internetClient, privateNetworkClientServer
