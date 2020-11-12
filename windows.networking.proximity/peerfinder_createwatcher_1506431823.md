---
-api-id: M:Windows.Networking.Proximity.PeerFinder.CreateWatcher
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Networking.Proximity.PeerWatcher CreateWatcher()
-->

# Windows.Networking.Proximity.PeerFinder.CreateWatcher

## -description
Creates a new instance of a [PeerWatcher](peerwatcher.md) object for dynamic discovery of peer apps.

## -returns
An instance of a [PeerWatcher](peerwatcher.md) object for dynamic discovery of peer apps.

## -remarks
You must first call the [Start](peerfinder_start_119778276.md) method before calling the CreateWatcher method.

If you call the CreateWatcher method multiple times, you will receive a reference to the same [PeerWatcher](peerwatcher.md) instance. 



[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

## -examples

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
