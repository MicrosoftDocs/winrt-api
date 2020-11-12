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
> Always set the DisplayName property to a unique value for your app before you call the [Start](peerfinder_start_119778276.md) method.

The **DisplayName** property value is included in the [PeerInformation](peerinformation.md) instance that's created when a remote peer calls the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) method and finds your computer.

If you don't specify a value for the **DisplayName** property, the computer name is used.

The maximum length of **DisplayName** is 50 characters.

## -examples

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
