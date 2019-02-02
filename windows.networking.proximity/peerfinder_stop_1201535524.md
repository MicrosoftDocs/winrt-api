---
-api-id: M:Windows.Networking.Proximity.PeerFinder.Stop
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Stop()
-->

# Windows.Networking.Proximity.PeerFinder.Stop

## -description
Stops advertising for a peer connection.

## -remarks
You can call the [Stop](peerfinder_stop_1201535524.md) method to stop the [PeerFinder](peerfinder.md) when you no longer want to advertise for or accept new triggered (tapped) or browsed connections. [Stop](peerfinder_stop_1201535524.md) does not close an existing connection. However, the [Stop](peerfinder_stop_1201535524.md) method will cancel outstanding calls to the [ConnectAsync](peerfinder_connectasync_380619906.md) method and triggered connection requests. The [Stop](peerfinder_stop_1201535524.md) method does not wait for the cancellation to complete.

## -examples


[!code-js[FindPeers](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/js/default.js#SnippetFindPeers)]

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[Start](peerfinder_start_119778276.md), [Proximity and Tapping (JavaScript)](https://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](https://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](https://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
