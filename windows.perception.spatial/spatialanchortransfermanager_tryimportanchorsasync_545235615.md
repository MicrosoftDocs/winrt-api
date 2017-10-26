---
-api-id: M:Windows.Perception.Spatial.SpatialAnchorTransferManager.TryImportAnchorsAsync(Windows.Storage.Streams.IInputStream)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IMapView<string, Windows.Perception.Spatial.SpatialAnchor>> TryImportAnchorsAsync(Windows.Storage.Streams.IInputStream stream)
-->

# Windows.Perception.Spatial.SpatialAnchorTransferManager.TryImportAnchorsAsync

## -description
Imports a stream of spatial anchors that was previously exported from another device. This allows both devices to reason about the same locations in their users' surroundings.

## -parameters
### -param stream
The stream to import anchors from.

## -returns
The operation that triggers once the import is complete, providing the imported anchors.

## -remarks
You must first export the anchors on the source device using the TryExportAnchorsAsync method. It is then the app's responsibility to get the data in the stream to the other device through its own network channel.

This imports the anchors and their supporting data into the device's spatial understanding. An app should then use [SpatialAnchorStore.TrySave](spatialanchorstore_trysave_1258774399.md) if it needs to retain access to this anchor.

This method can yield null if the device has reached its limit of spatial anchors, or if the spatial understanding system times out during the import.

## -examples

## -see-also

## -capabilities
spatialPerception
