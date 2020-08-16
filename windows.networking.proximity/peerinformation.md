---
-api-id: T:Windows.Networking.Proximity.PeerInformation
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PeerInformation : Windows.Networking.Proximity.IPeerInformation, Windows.Networking.Proximity.IPeerInformation3, Windows.Networking.Proximity.IPeerInformationWithHostAndService
-->

# Windows.Networking.Proximity.PeerInformation

## -description
Contains information that identifies a peer.

## -remarks
A PeerInformation instance is created when you call the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) method, and then passed to the [ConnectionRequested](peerfinder_connectionrequested.md) event. You can pass that instance to the [ConnectAsync](peerfinder_connectasync_380619906.md) method to accept a connection request from a peer.

## -examples


[!code-js[FindPeers](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/js/default.js#SnippetFindPeers)]

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[Proximity and Tapping (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/hh465229(v=win.10)), [Proximity and Tapping (C#/VB/C++)](https://docs.microsoft.com/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
