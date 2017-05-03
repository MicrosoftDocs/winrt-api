---
-api-id: E:Windows.Networking.Proximity.PeerWatcher.Updated
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Updated<Windows.Networking.Proximity.PeerWatcher,  Windows.Networking.Proximity.PeerInformation>
-->

# Windows.Networking.Proximity.PeerWatcher.Updated

## -description
Occurs when the [DisplayName](peerinformation_displayname.md) or [DiscoveryData](peerinformation_discoverydata.md) for a peer app within wireless range has changed.

## -remarks
The [Updated](peerwatcher_updated.md) event is raised when the [DisplayName](peerinformation_displayname.md) or [DiscoveryData](peerinformation_discoverydata.md) for a peer app changes. You can use the [Id](peerinformation_id.md) property to uniquely identify the peer app and update your UI.

> > [!IMPORTANT]
> For Windows Phone Store app, calling [PeerFinder.ConnectAsync](peerfinder_connectasync.md) from within an [Updated](peerwatcher_updated.md) event handler will fail. Instead, call it outside of this event handler, for example, when the user has explicitly chosen to connect to a peer.





[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

[!code-js[_StartPeerWatcher_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_StartPeerWatcher_JS)]

[!code-csharp[_PeerWatcherUpdated](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_PeerWatcherUpdated)]

[!code-js[_PeerWatcherUpdated_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_PeerWatcherUpdated_JS)]

## -examples

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)
