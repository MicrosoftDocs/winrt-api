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
You can call the [Stop](peerwatcher_stop.md) method to stop the [PeerWatcher](peerwatcher.md) object. You can register for the [Stopped](peerwatcher_stopped.md) event to be informed when the [PeerWatcher](peerwatcher.md) has stopped. You must wait for the [Stopped](peerwatcher_stopped.md) event before you can call the [Start](peerwatcher_start.md) method to restart the [PeerWatcher](peerwatcher.md).





[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

[!code-js[_StartPeerWatcher_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_StartPeerWatcher_JS)]

[!code-csharp[_PeerWatcherStopped](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_PeerWatcherStopped)]

[!code-js[_PeerWatcherStopped_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_PeerWatcherStopped_JS)]

## -examples

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)
 [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
