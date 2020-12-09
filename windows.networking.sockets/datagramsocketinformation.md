---
-api-id: T:Windows.Networking.Sockets.DatagramSocketInformation
-api-type: winrt class
---

<!-- Class syntax.
public class DatagramSocketInformation : Windows.Networking.Sockets.IDatagramSocketInformation
-->

# Windows.Networking.Sockets.DatagramSocketInformation

## -description
Provides socket information on a [DatagramSocket](datagramsocket.md) object.

## -remarks
The DatagramSocketInformation class provides information about a [DatagramSocket](datagramsocket.md). This class retrieves information on a [DatagramSocket](datagramsocket.md) and can be called any time after the [DatagramSocket](datagramsocket.md) has been created.

A DatagramSocketInformation object is automatically created with the parent [DatagramSocket](datagramsocket.md) object . The [DatagramSocket.Information](datagramsocket_information.md) property provides access to the associated DatagramSocketInformation object.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [DatagramSocket](datagramsocket.md), [DatagramSocket.Information](datagramsocket_information.md), [DatagramSocketControl](datagramsocketcontrol.md), [DatagramSocket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/DatagramSocket%20sample)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
