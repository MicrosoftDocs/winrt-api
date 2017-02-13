---
-api-id: T:Windows.Networking.Proximity.PeerDiscoveryTypes
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Proximity.PeerDiscoveryTypes : uint
-->

# PeerDiscoveryTypes

## -description
Indicates which discovery options are available to use with the [PeerFinder](peerfinder.md) class.

## -enum-fields
### -field None:0
<?xm-deletion_mark author="v-shawja" time="20120125T145217-0800" data="There are n"?><?xm-insertion_mark_start author="v-shawja" time="20120125T145219-0800"?> N<?xm-insertion_mark_end?> o supported discovery types <?xm-insertion_mark_start author="v-shawja" time="20120125T145222-0800"?> are <?xm-insertion_mark_end?> available. You can<?xm-insertion_mark_start author="v-shawja" time="20120125T144913-0800"?> '<?xm-insertion_mark_end?><?xm-deletion_mark author="v-shawja" time="20120125T144914-0800" data="no"?> t use the [PeerFinder](peerfinder.md) class.

### -field Browse:1
You can use Wifi-Direct to find peers <?xm-insertion_mark_start author="v-shawja" time="20120125T145231-0800"?> by <?xm-insertion_mark_end?> using the [FindAllPeersAsync](peerfinder_findallpeersasync.md) and [ConnectAsync](peerfinder_connectasync.md) methods of the [PeerFinder](peerfinder.md) class.

### -field Triggered:2
You can tap to connect to peers <?xm-insertion_mark_start author="v-shawja" time="20120125T145238-0800"?> by <?xm-insertion_mark_end?> using the [PeerFinder](peerfinder.md) class.


## -remarks

## -examples


[!code-js[FindPeers](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/js/default.js#SnippetFindPeers)]

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)][!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity, ID_CAP_PROXIMITY [Windows Phone]
 ID_CAP_PROXIMITY [Windows Phone]
