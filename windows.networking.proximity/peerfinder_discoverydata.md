---
-api-id: P:Windows.Networking.Proximity.PeerFinder.DiscoveryData
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer DiscoveryData { get;  set; }
-->

# Windows.Networking.Proximity.PeerFinder.DiscoveryData

## -description
Gets or sets user or device data to include during device discovery.

## -property-value
User or device data to include during device discovery. Must be less than 32 bytes.

## -remarks
> Windows Phone 8.x app: This property is not supported. Setting it has no effect and no data is returned from this property on a phone.

## -examples


[!code-csharp[PeerRole_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/PeerRole.xaml.cs#SnippetPeerRole_CS)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
