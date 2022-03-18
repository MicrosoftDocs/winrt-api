---
-api-id: P:Windows.Networking.Proximity.PeerFinder.AllowWiFiDirect
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool AllowWiFiDirect { get;  set; }
-->

# Windows.Networking.Proximity.PeerFinder.AllowWiFiDirect

## -description
Specifies whether the [PeerFinder](peerfinder.md) class may connect a [StreamSocket](../windows.networking.sockets/streamsocket_streamsocket_1221375020.md) object by using Wi-Fi Direct.

## -property-value
True if the [PeerFinder](peerfinder.md) class may connect a [StreamSocket](../windows.networking.sockets/streamsocket_streamsocket_1221375020.md) object by using Wi-Fi Direct; otherwise false. The default is true.

## -remarks
Setting the AllowWiFiDirect property to false disables the ability to browse for peer apps using Wi-Fi Direct. You will not be able to use the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) method to browse for remote peers.

### Windows Phone 8

Wi-Fi Direct is not supported on Windows Phone 8. 

## -examples

## -see-also
[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
