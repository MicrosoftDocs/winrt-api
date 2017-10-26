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


[!code-js[PeerRole](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/js/peerrole.js#SnippetPeerRole)]

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
