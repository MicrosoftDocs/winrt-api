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
You can use the [FindAllPeersAsync](peerfinder_findallpeersasync.md) method to get a list of all peers within range. However, the [FindAllPeersAsync](peerfinder_findallpeersasync.md) method scans for peers once and then completes. Alternatively, you can use the [PeerWatcher](peerwatcher.md) class to scan for peers and get updates as they are found and incrementally update your list of available peer apps. The [PeerWatcher](peerwatcher.md) continuously scans for new peer apps within range and removes stale peer apps. You can update your list of peer apps by handling the [Added](peerwatcher_added.md) event, which occurs when a new peer app is found, and the [Removed](peerwatcher_removed.md) event which occurs when a stale peer app is removed. The [PeerWatcher](peerwatcher.md) continues to scan until you call the Stop method, or the [PeerFinder.FindAllPeersAsync ](peerfinder_findallpeersasync.md) or [PeerFinder.ConnectAsync](peerfinder_connectasync.md) methods.

> > [!IMPORTANT]
> For Windows Phone Store app, calling [PeerFinder.ConnectAsync](peerfinder_connectasync.md) from within an [EnumerationCompleted](peerwatcher_enumerationcompleted.md), [Added](peerwatcher_added.md) or [Updated](peerwatcher_updated.md) event handler will fail. Instead, call it outside of these event handlers, for example, when the user has explicitly chosen to connect to a peer.

To create an instance of the [PeerWatcher](peerwatcher.md) class, call the [PeerFinder.Start](peerfinder_start.md) method, and then call the [CreateWatcher](peerfinder_createwatcher.md) method.





[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]


[!code-js[_StartPeerWatcher_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_StartPeerWatcher_JS)]

## -examples

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)
