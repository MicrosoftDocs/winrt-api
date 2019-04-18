---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSource.IsPointingSupported
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool IsPointingSupported { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSource.IsPointingSupported

## -description

Gets whether the source can provide pointer poses.

## -property-value

Returns true for motion controllers that support positional tracking and false for other interaction sources.

## -remarks

To get the source pointer pose, pass the source to [SpatialPointingPose.TryGetInteractionSourcePose](spatialpointerpose_trygetinteractionsourcepose_1162732260.md).  Note that a pointing-capable motion controller can still return a null pointer pose if the controller has lost positional tracking.

## -see-also

## -examples
