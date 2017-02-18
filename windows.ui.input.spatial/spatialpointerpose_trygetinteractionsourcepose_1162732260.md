---
-api-id: M:Windows.UI.Input.Spatial.SpatialPointerPose.TryGetInteractionSourcePose(Windows.UI.Input.Spatial.SpatialInteractionSource)
-api-type: winrt method
---

<!-- Method syntax.
public SpatialPointerInteractionSourcePose SpatialPointerPose.TryGetInteractionSourcePose(SpatialInteractionSource source)
-->

# Windows.UI.Input.Spatial.SpatialPointerPose.TryGetInteractionSourcePose

## -description
Gets the pointing pose for a particular spatial interaction source, such as a spatial controller, at a given timestamp.

## -parameters

### -param source
The spatial interaction source for which a pointing pose should be determined.

## -returns
The interaction source pointing pose.

## -remarks
This method will return null if the specified spatial interaction source does not support pointing ([IsPointingSupported](spatialinteractionsource_ispointingsupported.md) is false) or if the source did not have positional tracking at that moment.

## -see-also

## -examples

