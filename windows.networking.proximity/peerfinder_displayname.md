---
-api-id: P:Windows.Networking.Proximity.PeerFinder.DisplayName
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string DisplayName { get;  set; }
-->

# Windows.Networking.Proximity.PeerFinder.DisplayName

## -description
Gets or sets the name that identifies your computer to remote peers.

## -property-value
The name that identifies your computer to remote peers.

## -remarks
> [!IMPORTANT]
> Always set the [DisplayName](peerfinder_displayname.md) property to a unique value for your app before you call the [Start](peerfinder_start.md) method.

The **DisplayName** property value is included in the [PeerInformation](peerinformation.md) instance that's created when a remote peer calls the [FindAllPeersAsync](peerfinder_findallpeersasync.md) method and finds your computer.

If you don't specify a value for the **DisplayName** property, the computer name is used.

The maximum length of **DisplayName** is 50 characters.

## -examples


[!code-js[FindPeers](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/js/default.js#SnippetFindPeers)]

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
