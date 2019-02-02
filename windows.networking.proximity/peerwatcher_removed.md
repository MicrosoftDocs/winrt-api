---
-api-id: E:Windows.Networking.Proximity.PeerWatcher.Removed
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Removed<Windows.Networking.Proximity.PeerWatcher,  Windows.Networking.Proximity.PeerInformation>
-->

# Windows.Networking.Proximity.PeerWatcher.Removed

## -description
Occurs when a peer app is no longer within wireless range.

## -remarks
The [Removed](peerwatcher_removed.md) event is raised when a peer app is removed from the collection of enumerated peer apps. This may happen if a user switches apps or if a device is no longer within range.





[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

[!code-js[_StartPeerWatcher_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_StartPeerWatcher_JS)]

[!code-csharp[_PeerWatcherRemoved](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_PeerWatcherRemoved)]

[!code-js[_PeerWatcherRemoved_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_PeerWatcherRemoved_JS)]

## -examples

## -see-also
[Proximity and Tapping (JavaScript)](https://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](https://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](https://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
