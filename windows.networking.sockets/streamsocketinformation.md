---
-api-id: T:Windows.Networking.Sockets.StreamSocketInformation
-api-type: winrt class
---

<!-- Class syntax.
public class StreamSocketInformation : Windows.Networking.Sockets.IStreamSocketInformation, Windows.Networking.Sockets.IStreamSocketInformation2
-->

# Windows.Networking.Sockets.StreamSocketInformation

## -description
Provides socket information on a [StreamSocket](streamsocket.md) object.

## -remarks
The [StreamSocketInformation](datagramsocketinformation.md) class provides information about a [StreamSocket](streamsocket.md). This class retrieves information on a [StreamSocket](streamsocket.md) and can be called any time after the [StreamSocket](streamsocket.md) has been created.

A [StreamSocketInformation](datagramsocketinformation.md) object is automatically created with the parent [StreamSocket](streamsocket.md) object. The [StreamSocket.Information](streamsocket_information.md) property provides access to the associated [StreamSocketInformation](datagramsocketinformation.md) object.

## -examples

## -see-also
[Connecting with sockets ](https://msdn.microsoft.com/library/67cfa78f-570f-4dd4-a0f2-cd6c891f5446), [Connecting with sockets ](https://msdn.microsoft.com/library/2a6448d0-e21f-4963-bca5-aae001ae4fc7), [How to use advanced socket controls ](https://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](https://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [StreamSocket](streamsocket.md), [StreamSocket.Information](streamsocket_information.md), [StreamSocket.Control](streamsocket_control.md), [ControlChannelTrigger StreamSocket sample](https://go.microsoft.com/fwlink/p/?linkid=243039), [StreamSocket sample](https://go.microsoft.com/fwlink/p/?linkid=243037)

## -capabilities
ID_CAP_NETWORKING [Windows Phone], bluetooth.rfcomm
