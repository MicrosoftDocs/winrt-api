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
The [MessageWebSocket](messagewebsocket.md) class provides a message-based abstraction of the [WebSocket protocol](http://go.microsoft.com/fwlink/p/?linkid=240293). When using [MessageWebSocket](messagewebsocket.md), the entire WebSocket message is read or written in a single operation. In contrast, the [StreamWebSocket](streamwebsocket.md) allows sections of a message to be read with each read operation, rather than requiring the entire message to be read in a single operation.

For UTF-8 messages, [MessageWebSocket](messagewebsocket.md) must be used. [StreamWebSocket](streamwebsocket.md) only supports binary messages.

### Handling exceptions

You must write code to handle exceptions when you call asynchronous methods on the [MessageWebSocket](messagewebsocket.md) class. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and HTTP server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime.

The [Windows.Networking.Sockets](windows_networking_sockets.md) namespace has a convenient helper method and enumeration for handling errors when using WebSockets. This can be useful for handling specific network exceptions differently in your app. An app can also use the **HRESULT** from the exception on parameter validation errors to learn more detailed information on the error that caused the exception.

For more information on possible exceptions and how to handle exceptions, see [Handling exceptions in network apps](http://msdn.microsoft.com/library/76fafcc9-c674-4cf8-baa0-2400638fae35).

### Using MessageWebSocket on Windows Server 2012

On Windows Server 2012 and Windows Server 2012 R2, the *Windows.Networking.dll* that implements most of the classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail to load unless the Media Foundation feature is enabled. As a result, apps that use [MessageWebSocket](messagewebsocket.md) and related WebSocket classes in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will fail if the Media Foundation feature is disabled. Windows Server 2012 or Windows Server 2012 R2 installs with the Media Foundation feature disabled.

The Media Foundation feature can be enabled on Windows Server 2012 or Windows Server 2012 R2 using Server Manager or by entering the following text in a command prompt or a script:

`dism /online /enable-feature /featurename:ServerMediaFoundation `After the Media Foundation feature is enabled, the user is prompted to restart. Once the computer is restarted, classes for sockets and WebSockets in the [Windows.Networking.Sockets](windows_networking_sockets.md) namespace will work as expected.

## -examples

## -see-also
[Connecting with WebSockets ](http://msdn.microsoft.com/library/a472f6c2-3d26-4bc8-8bc9-2e180afe61e5), [Connecting with WebSockets ](http://msdn.microsoft.com/library/af4905fe-5998-4d39-a81f-300a4a811824), [Handling exceptions in network apps](http://msdn.microsoft.com/library/76fafcc9-c674-4cf8-baa0-2400638fae35), [How to connect with a MessageWebSocket ](http://msdn.microsoft.com/library/dbc12fd9-3761-4872-9a97-2e2e6c1779d4), [How to connect with a MessageWebSocket ](http://msdn.microsoft.com/library/2ffbffd4-e260-4098-92f3-e8398bdf8f9b), [How to use advanced WebSocket controls ](http://msdn.microsoft.com/library/0a47f7c3-66f9-4315-886e-bd1afe77bf39), [How to use advanced WebSocket controls ](http://msdn.microsoft.com/library/4ab9621e-90e5-420e-88d0-09f1c7239d7a), [MessageWebSocketControl](messagewebsocketcontrol.md), [MessageWebSocketInformation](messagewebsocketinformation.md), [StreamWebSocket](streamwebsocket.md), [Connecting with WebSockets sample](http://go.microsoft.com/fwlink/p/?linkid=239964), [WebSocket sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620623)

## -capabilities
internetClient, privateNetworkClientServer