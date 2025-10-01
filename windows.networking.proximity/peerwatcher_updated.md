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
The Updated event is raised when the [DisplayName](peerinformation_displayname.md) or [DiscoveryData](peerinformation_discoverydata.md) for a peer app changes. You can use the [Id](peerinformation_id.md) property to uniquely identify the peer app and update your UI.

[!code-csharp[_StartPeerWatcher](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_StartPeerWatcher)]

[!code-csharp[_PeerWatcherUpdated](../windows.networking.proximity/code/Proximity_PeerWatcher/cs/MainPage.xaml.cs#Snippet_PeerWatcherUpdated)]

## -examples

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
