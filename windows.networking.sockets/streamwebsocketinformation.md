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
StreamWebSocketInformation can be called any time after the [StreamWebSocket](streamwebsocket.md) has been created.

A StreamWebSocketInformation object is automatically created with the parent [StreamWebSocket](streamwebsocket.md) object. The [StreamWebSocket.Information](streamwebsocket_information.md) property provides access to the associated StreamWebSocketInformation object.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ServerCertificate |
| 1607 | 14393 | ServerCertificateErrors |
| 1607 | 14393 | ServerCertificateErrorSeverity |
| 1607 | 14393 | ServerIntermediateCertificates |

## -examples

## -see-also
[How to use advanced WebSocket controls](https://docs.microsoft.com/previous-versions/windows/apps/hh761447(v=win.10)),
[How to use advanced WebSocket controls](https://docs.microsoft.com/previous-versions/windows/apps/hh994400(v=win.10)),
[StreamWebSocket](streamwebsocket.md),
[StreamWebSocket.Information](streamwebsocket_information.md),
[StreamWebSocketControl](streamwebsocketcontrol.md),
[ControlChannelTrigger StreamWebSocket sample](https://go.microsoft.com/fwlink/p/?linkid=251232),
[WebSockets](/windows/uwp/networking/websockets?branch=live)

## -capabilities
internetClient, privateNetworkClientServer
