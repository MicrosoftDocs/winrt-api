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
You must register an event handler for [Added](peerwatcher_added.md) event before calling the Start method.

You can call the [Stop](peerwatcher_stop_1201535524.md) method to stop dynamically searching for peer apps within wireless range.

You can use the [Status](peerwatcher_status.md) property to determine the status of the [PeerWatcher](peerwatcher.md) object. You cannot call the Start method if the [Status](peerwatcher_status.md) value is **Started**, **EnumerationCompleted**, or **Stopping.**

[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

## -examples

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
