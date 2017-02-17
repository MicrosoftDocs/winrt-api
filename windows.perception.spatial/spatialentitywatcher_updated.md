---
-api-id: E:Windows.Perception.Spatial.SpatialEntityWatcher.Updated
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler Updated<SpatialEntityWatcher, SpatialEntityUpdatedEventArgs>
-->

# Windows.Perception.Spatial.SpatialEntityWatcher.Updated

## -description
The event that is raised when an existing spatial entity has its metadata updated by a participant.

## -remarks
Note that adjustments to the position of a spatial anchor that occur as the device learns more about its environment are not represented by this Updated event.  Apps should react to changes to the anchor's coordinate system each frame, just as is necessary for local anchors.

## -see-also

## -examples

