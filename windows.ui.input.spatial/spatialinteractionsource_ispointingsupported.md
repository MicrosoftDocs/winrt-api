---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSource.IsPointingSupported
-api-type: winrt property
---

<!-- Property syntax.
public bool IsPointingSupported { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSource.IsPointingSupported

## -description
Gets whether the source can provide pointing poses.

## -property-value
Whether the source can provide pointing poses.

## -remarks
This will be true for spatial controllers that support positional tracking and false for other interaction sources.

To get this source's pointing pose, pass the source to [SpatialPointingPose.TryGetInteractionSourcePose](spatialpointerpose_trygetinteractionsourcepose_1162732260.md).  Note that a pointing-capable spatial controller can still return a null pointing pose if the controller has lost positional tracking.

## -see-also

## -examples

