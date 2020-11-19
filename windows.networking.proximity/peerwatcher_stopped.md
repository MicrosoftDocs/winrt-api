---
-api-id: E:Windows.Networking.Proximity.PeerWatcher.Stopped
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Stopped<Windows.Networking.Proximity.PeerWatcher,  object>
-->

# Windows.Networking.Proximity.PeerWatcher.Stopped

## -description
Occurs when the [PeerWatcher](peerwatcher.md) object has been stopped.

## -remarks
You can call the [Stop](peerwatcher_stop_1201535524.md) method to stop the [PeerWatcher](peerwatcher.md) object. You can register for the Stopped event to be informed when the [PeerWatcher](peerwatcher.md) has stopped. You must wait for the Stopped event before you can call the [Start](peerwatcher_start_1587696324.md) method to restart the [PeerWatcher](peerwatcher.md).

[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

[!code-csharp[_PeerWatcherStopped](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_PeerWatcherStopped)]

## -examples

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
