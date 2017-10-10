---
-api-id: M:Windows.Networking.Proximity.PeerWatcher.Start
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Start()
-->

# Windows.Networking.Proximity.PeerWatcher.Start

## -description
Begin dynamically searching for peer apps within wireless range.

## -remarks
You must register an event handler for [Added](peerwatcher_added.md) event before calling the [Start](peerwatcher_start.md) method.

You can call the [Stop](peerwatcher_stop.md) method to stop dynamically searching for peer apps within wireless range.

You can use the [Status](peerwatcher_status.md) property to determine the status of the [PeerWatcher](peerwatcher.md) object. You cannot call the [Start](peerwatcher_start.md) method if the [Status](peerwatcher_status.md) value is **Started**, **EnumerationCompleted**, or **Stopping.**





[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

[!code-js[_StartPeerWatcher_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_StartPeerWatcher_JS)]

## -examples

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
