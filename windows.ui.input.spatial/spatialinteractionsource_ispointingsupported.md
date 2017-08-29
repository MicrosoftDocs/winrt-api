---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSource.IsPointingSupported
-api-type: winrt property
---

<!-- Property syntax.
public bool IsPointingSupported { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSource.IsPointingSupported

## -description
Gets whether the source can provide pointer poses.

## -property-value
Whether the source can provide pointer poses.

## -remarks
This will be true for motion controllers that support positional tracking and false for other interaction sources.

To get this source's pointer pose, pass the source to [SpatialPointingPose.TryGetInteractionSourcePose](spatialpointerpose_trygetinteractionsourcepose_1162732260.md).  Note that a pointing-capable motion controller can still return a null pointer pose if the controller has lost positional tracking.

## -see-also

## -examples

