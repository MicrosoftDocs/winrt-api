---
-api-id: E:Windows.Networking.Proximity.PeerWatcher.EnumerationCompleted
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler EnumerationCompleted<Windows.Networking.Proximity.PeerWatcher,  object>
-->

# Windows.Networking.Proximity.PeerWatcher.EnumerationCompleted

## -description
Occurs after a scan operation is complete and all peer apps within wireless range have been found.

## -remarks
[EnumerationCompleted](peerwatcher_enumerationcompleted.md) event is raised when an enumeration looking for peer apps within range is complete. 

> > [!IMPORTANT]
> For Windows Phone 8.x apps, calling [PeerFinder.ConnectAsync](peerfinder_connectasync.md) from within an [EnumerationCompleted](peerwatcher_enumerationcompleted.md) event handler will fail. Instead, call it outside of this event handler, for example, when the user has explicitly chosen to connect to a peer.





[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

[!code-js[_StartPeerWatcher_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_StartPeerWatcher_JS)]

[!code-csharp[_PeerWatcherEnumerationCompleted](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_PeerWatcherEnumerationCompleted)]

[!code-js[_PeerWatcherEnumerationCompleted_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_PeerWatcherEnumerationCompleted_JS)]

## -examples

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
