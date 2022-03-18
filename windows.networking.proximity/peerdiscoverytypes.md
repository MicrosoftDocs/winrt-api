---
-api-id: T:Windows.Networking.Proximity.PeerDiscoveryTypes
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.Proximity.PeerDiscoveryTypes : uint
-->

# PeerDiscoveryTypes

## -description
Indicates which discovery options are available to use with the [PeerFinder](peerfinder.md) class.

## -enum-fields
### -field None:0
 No supported discovery types are available. You can't use the [PeerFinder](peerfinder.md) class.

### -field Browse:1
You can use Wifi-Direct to find peers by using the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) and [ConnectAsync](peerfinder_connectasync_380619906.md) methods of the [PeerFinder](peerfinder.md) class.

### -field Triggered:2
You can tap to connect to peers by using the [PeerFinder](peerfinder.md) class.


## -remarks

## -examples

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
