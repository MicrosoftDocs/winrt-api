---
-api-id: M:Windows.UI.Input.Spatial.SpatialInteractionSourceProperties.TryGetSourceLossMitigationDirection(Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IReference<Windows.Foundation.Numerics.Vector3> TryGetSourceLossMitigationDirection(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
-->

# Windows.UI.Input.Spatial.SpatialInteractionSourceProperties.TryGetSourceLossMitigationDirection

## -description
Gets the direction you should suggest that the user move their hand or spatial controller if it is nearing the edge of the detection area.

## -parameters
### -param coordinateSystem
The coordinate system in which to express the mitigation direction.

## -returns
The mitigation direction vector, or null if there is no mitigation direction.

## -remarks
This method will return null if the specified coordinate system cannot be located at the moment.

## -examples

## -see-also
