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
[Connecting with sockets](/previous-versions/windows/apps/hh452976(v=win.10)), [How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [StreamSocket](streamsocket.md), [StreamSocket.Information](streamsocket_information.md), [StreamSocket.Control](streamsocket_control.md), [ControlChannelTrigger StreamSocket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/ControlChannelTrigger%20StreamSocket%20sample/C%23), [StreamSocket sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/StreamSocket)

## -capabilities
ID_CAP_NETWORKING [Windows Phone], bluetooth.rfcomm