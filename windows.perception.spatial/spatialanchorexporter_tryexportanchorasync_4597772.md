---
-api-id: M:Windows.Perception.Spatial.SpatialAnchorExporter.TryExportAnchorAsync(Windows.Perception.Spatial.SpatialAnchor,Windows.Perception.Spatial.SpatialAnchorExportPurpose,Windows.Storage.Streams.IOutputStream)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<bool> SpatialAnchorExporter.TryExportAnchorAsync(SpatialAnchor anchor, SpatialAnchorExportPurpose purpose, IOutputStream stream)
-->

# Windows.Perception.Spatial.SpatialAnchorExporter.TryExportAnchorAsync

## -description
Exports a spatial anchor to a stream for sharing or relocalization. This allows multiple devices to reason about the same locations in their users' surroundings.

## -parameters
### -param anchor
The spatial anchor to export.

### -param purpose
The purpose of the export, sharing or relocalization.

### -param stream
The stream to export the anchor to.

## -returns
Operation that triggers once the export has been attempted, providing true if the export succeeded; otherwise, false.

## -remarks

## -see-also

## -examples

## -capabilities
spatialPerception
