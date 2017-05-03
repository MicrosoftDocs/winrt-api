---
-api-id: M:Windows.Perception.Spatial.SpatialAnchorStore.TrySave(System.String,Windows.Perception.Spatial.SpatialAnchor)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public bool TrySave(System.String id, Windows.Perception.Spatial.SpatialAnchor anchor)
-->

# Windows.Perception.Spatial.SpatialAnchorStore.TrySave

## -description
Persists an anchor to the store.

## -parameters
### -param id
An identifier for the anchor. The identifier must be unique within your app.

### -param anchor
The anchor to save.

## -returns
True, if the save succeeded; otherwise, false.

## -remarks
This method may return false in future versions of Windows if a device has a per-app anchor persistence limit.

## -examples

## -see-also
