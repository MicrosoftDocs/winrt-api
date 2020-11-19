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
You can call the Stop method to stop the [PeerFinder](peerfinder.md) when you no longer want to advertise for or accept new triggered (tapped) or browsed connections. Stop does not close an existing connection. However, the Stop method will cancel outstanding calls to the [ConnectAsync](peerfinder_connectasync_380619906.md) method and triggered connection requests. The Stop method does not wait for the cancellation to complete.

## -examples

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[Start](peerfinder_start_119778276.md), [Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
