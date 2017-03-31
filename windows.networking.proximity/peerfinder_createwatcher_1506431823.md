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
You must first call the [Start](peerfinder_start.md) method before calling the [CreateWatcher](peerfinder_createwatcher.md) method.

If you call the [CreateWatcher](peerfinder_createwatcher.md) method multiple times, you will receive a reference to the same [PeerWatcher](peerwatcher.md) instance. 



[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

[!code-js[_StartPeerWatcher_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_StartPeerWatcher_JS)]

[!code-js[_StartPeerWatcher_JS](../windows.networking.proximity/code/Proximity_PeerWatcher/js/default.js#Snippet_StartPeerWatcher_JS)]

## -examples

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)
