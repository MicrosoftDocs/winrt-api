---
-api-id: T:Windows.Perception.Spatial.SpatialAnchorStore
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SpatialAnchorStore : Windows.Perception.Spatial.ISpatialAnchorStore
-->

# Windows.Perception.Spatial.SpatialAnchorStore

## -description
Represents a collection of [SpatialAnchor](spatialanchor.md) objects stored by Windows on behalf of an app.

## -remarks
This lets an app persist SpatialAnchors and then load them back again during a future app session. The app is responsible for keeping track of which identifiers represent which logical locations within the app, for example associating an anchor with a hologram that should be displayed there.

To request the app's SpatialAnchorStore, use the [SpatialAnchorManager](spatialanchormanager.md) class.

## -examples

## -see-also
