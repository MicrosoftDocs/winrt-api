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
You can use Wifi-Direct to find peers by using the [FindAllPeersAsync](peerfinder_findallpeersasync.md) and [ConnectAsync](peerfinder_connectasync.md) methods of the [PeerFinder](peerfinder.md) class.

### -field Triggered:2
You can tap to connect to peers by using the [PeerFinder](peerfinder.md) class.


## -remarks

## -examples


[!code-js[FindPeers](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/js/default.js#SnippetFindPeers)]

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
