---
-api-id: E:Windows.Networking.Proximity.PeerWatcher.Added
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Added<Windows.Networking.Proximity.PeerWatcher,  Windows.Networking.Proximity.PeerInformation>
-->

# Windows.Networking.Proximity.PeerWatcher.Added

## -description
Occurs when a peer app is found within wireless range.

## -remarks
> > [!IMPORTANT]
> For Windows Phone 8.x apps, calling [PeerFinder.ConnectAsync](peerfinder_connectasync_380619906.md) from within an Added event handler will fail. Instead, call it outside of this event handler, for example, when the user has explicitly chosen to connect to a peer.

After you start the [PeerWatcher](peerwatcher.md)by calling the [Start](peerfinder_start_119778276.md)method, the Addedevent is raised for each peer app found within wireless range. The [PeerWatcher](peerwatcher.md)continues scanning for peer apps within range until you call the [Stop](peerwatcher_stop_1201535524.md)method. Using the Addedevent, you can display peer apps to the user as they are found.





[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

[!code-js[_StartPeerWatcher_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_StartPeerWatcher_JS)]

[!code-csharp[_PeerWatcherAdded](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_PeerWatcherAdded)]

[!code-js[_PeerWatcherAdded_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_PeerWatcherAdded_JS)]

## -examples

## -see-also
[Proximity and Tapping (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/hh465229(v=win.10)), [Proximity and Tapping (C#/VB/C++)](https://docs.microsoft.com/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
