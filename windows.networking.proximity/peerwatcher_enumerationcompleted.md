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
EnumerationCompleted event is raised when an enumeration looking for peer apps within range is complete. 

> > [!IMPORTANT]
> For Windows Phone 8.x apps, calling [PeerFinder.ConnectAsync](peerfinder_connectasync_380619906.md) from within an EnumerationCompleted event handler will fail. Instead, call it outside of this event handler, for example, when the user has explicitly chosen to connect to a peer.

[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

[!code-csharp[_PeerWatcherEnumerationCompleted](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_PeerWatcherEnumerationCompleted)]

## -examples

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
