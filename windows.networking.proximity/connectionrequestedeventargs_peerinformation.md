---
-api-id: P:Windows.Networking.Proximity.ConnectionRequestedEventArgs.PeerInformation
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Networking.Proximity.PeerInformation PeerInformation { get; }
-->

# Windows.Networking.Proximity.ConnectionRequestedEventArgs.PeerInformation

## -description
Gets the information for a peer that's requesting a connection.

## -property-value
The information for a peer that's requesting a connection.

## -remarks
Pass this reference to the [ConnectAsync](peerfinder_connectasync_380619906.md) method to accept the request.

## -examples

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
