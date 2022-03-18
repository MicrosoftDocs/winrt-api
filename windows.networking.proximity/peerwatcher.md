---
-api-id: T:Windows.Networking.Proximity.PeerWatcher
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PeerWatcher : Windows.Networking.Proximity.IPeerWatcher
-->

# Windows.Networking.Proximity.PeerWatcher

## -description
Dynamically discovers peer apps within wireless range.

## -remarks
You can use the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) method to get a list of all peers within range. However, the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) method scans for peers once and then completes. Alternatively, you can use the PeerWatcher class to scan for peers and get updates as they are found and incrementally update your list of available peer apps. The PeerWatcher continuously scans for new peer apps within range and removes stale peer apps. You can update your list of peer apps by handling the [Added](peerwatcher_added.md) event, which occurs when a new peer app is found, and the [Removed](peerwatcher_removed.md) event which occurs when a stale peer app is removed. The PeerWatcher continues to scan until you call the Stop method, or the [PeerFinder.FindAllPeersAsync ](peerfinder_findallpeersasync_830195586.md) or [PeerFinder.ConnectAsync](peerfinder_connectasync_380619906.md) methods.

> > [!IMPORTANT]
> For Windows Phone 8.x apps, calling [PeerFinder.ConnectAsync](peerfinder_connectasync_380619906.md) from within an [EnumerationCompleted](peerwatcher_enumerationcompleted.md), [Added](peerwatcher_added.md) or [Updated](peerwatcher_updated.md) event handler will fail. Instead, call it outside of these event handlers, for example, when the user has explicitly chosen to connect to a peer.

To create an instance of the PeerWatcher class, call the [PeerFinder.Start](peerfinder_start_119778276.md) method, and then call the [CreateWatcher](peerfinder_createwatcher_1506431823.md) method.

[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

## -examples

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
