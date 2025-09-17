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
After you start the [PeerWatcher](peerwatcher.md)by calling the [Start](peerfinder_start_119778276.md)method, the Addedevent is raised for each peer app found within wireless range. The [PeerWatcher](peerwatcher.md)continues scanning for peer apps within range until you call the [Stop](peerwatcher_stop_1201535524.md)method. Using the Addedevent, you can display peer apps to the user as they are found.

[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

[!code-csharp[_PeerWatcherAdded](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_PeerWatcherAdded)]

## -examples

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
