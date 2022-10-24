---
-api-id: T:Windows.Networking.Sockets.MessageWebSocket
-api-type: winrt class
---

<!-- Class syntax.
public class MessageWebSocket : Windows.Foundation.IClosable, Windows.Networking.Sockets.IMessageWebSocket, Windows.Networking.Sockets.IMessageWebSocket2, Windows.Networking.Sockets.IWebSocket
-->

# Windows.Networking.Sockets.MessageWebSocket

## -description

Supports network communication that allows reading and writing whole messages using a WebSocket.

## -remarks

The MessageWebSocket class provides a message-based abstraction of the [WebSocket protocol](https://tools.ietf.org/html/rfc6455). When using MessageWebSocket, the entire WebSocket message is read or written in a single operation. In contrast, the [StreamWebSocket](streamwebsocket.md) allows sections of a message to be read with each read operation, rather than requiring the entire message to be read in a single operation.

For UTF-8 messages, MessageWebSocket must be used. [StreamWebSocket](streamwebsocket.md) only supports binary messages.

### Handling exceptions

You must write code to handle exceptions when you call asynchronous methods on the MessageWebSocket class. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and HTTP server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime.

The [Windows.Networking.Sockets](windows_networking_sockets.md) namespace has a convenient helper method and enumeration for handling errors when using WebSockets. This can be useful for handling specific network exceptions differently in your app. An app can also use the **HRESULT** from the exception on parameter validation errors to learn more detailed information on the error that caused the exception.

For more information on possible exceptions and how to handle exceptions, see [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)).

### Using MessageWebSocket on Windows Server 2012

On Windows Server 2012 and Windows Server 2012 R2, the *Windows.Networking.dll* that implements most of the classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail to load unless the Media Foundation feature is enabled. As a result, apps that use MessageWebSocket and related WebSocket classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail if the Media Foundation feature is disabled. Windows Server 2012 or Windows Server 2012 R2 installs with the Media Foundation feature disabled.

The Media Foundation feature can be enabled on Windows Server 2012 or Windows Server 2012 R2 using Server Manager or by entering the following text in a command prompt or a script:

`dism /online /enable-feature /featurename:ServerMediaFoundation `After the Media Foundation feature is enabled, the user is prompted to restart. Once the computer is restarted, classes for sockets and WebSockets in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will work as expected.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ServerCustomValidationRequested |
| 1803 | 17134 | SendFinalFrameAsync |
| 1803 | 17134 | SendNonfinalFrameAsync |

## -examples

## -see-also

[WebSockets](/windows/uwp/networking/websockets), [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)), [MessageWebSocketControl](messagewebsocketcontrol.md), [MessageWebSocketInformation](messagewebsocketinformation.md), [StreamWebSocket](streamwebsocket.md), [WebSocket sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebSocket)

## -capabilities

internetClient, privateNetworkClientServer
