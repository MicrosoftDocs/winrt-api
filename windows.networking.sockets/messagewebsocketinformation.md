---
-api-id: T:Windows.Networking.Sockets.MessageWebSocketInformation
-api-type: winrt class
---

<!-- Class syntax.
public class MessageWebSocketInformation : Windows.Networking.Sockets.IWebSocketInformation, Windows.Networking.Sockets.IWebSocketInformation2
-->

# Windows.Networking.Sockets.MessageWebSocketInformation

## -description
Provides socket information on a [MessageWebSocket](messagewebsocket.md).

## -remarks
[MessageWebSocketInformation](messagewebsocket_information.md) can be called any time after the [MessageWebSocket](messagewebsocket.md) has been created.

A MessageWebSocketInformation object is automatically created with the parent [MessageWebSocket](messagewebsocket.md) object. The [MessageWebSocket.Information](messagewebsocket_information.md) property provides access to the associated MessageWebSocketInformation object.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ServerCertificate |
| 1607 | 14393 | ServerCertificateErrors |
| 1607 | 14393 | ServerCertificateErrorSeverity |
| 1607 | 14393 | ServerIntermediateCertificates |

## -examples

## -see-also

[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)),
[MessageWebSocket](messagewebsocket.md),
[MessageWebSocket.Information](messagewebsocket_information.md),
[MessageWebSocketControl](messagewebsocketcontrol.md),
[WebSockets](/windows/uwp/networking/websockets),
[WebSocket sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebSocket),
