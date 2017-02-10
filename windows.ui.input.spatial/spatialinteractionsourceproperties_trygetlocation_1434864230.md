---
-api-id: M:Windows.UI.Input.Spatial.SpatialInteractionSourceProperties.TryGetLocation(Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Input.Spatial.SpatialInteractionSourceLocation TryGetLocation(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
-->

# Windows.UI.Input.Spatial.SpatialInteractionSourceProperties.TryGetLocation

## -description
Get the position and velocity of the hand, expressed in the specified coordinate system.

## -parameters
### -param coordinateSystem
The coordinate system in which to express the hand's location.

## -returns
The location.

## -remarks
This method will return null if the specified coordinate system cannot be located at the moment.

## -examples

## -see-also
