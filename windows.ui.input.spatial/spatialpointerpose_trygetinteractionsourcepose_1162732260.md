---
-api-id: M:Windows.UI.Input.Spatial.SpatialPointerPose.TryGetInteractionSourcePose(Windows.UI.Input.Spatial.SpatialInteractionSource)
-api-type: winrt method
---

<!-- Method syntax.
public SpatialPointerInteractionSourcePose SpatialPointerPose.TryGetInteractionSourcePose(SpatialInteractionSource source)
-->

# Windows.UI.Input.Spatial.SpatialPointerPose.TryGetInteractionSourcePose

## -description
Gets the pointer pose for a particular spatial interaction source, such as a motion controller, at a given timestamp.

## -parameters

### -param source
The spatial interaction source for which a pointer pose should be determined.

## -returns
The interaction source pointer pose.

## -remarks
The pointer pose represents the tip of a motion controller pointing forward.  This pose is best used to raycast when pointing at UI when you are rendering the controller model itself.

To examine the grip pose of a motion controller, examine the Position and Orientation properties directly on a [SpatialInteractionSourceLocation](spatialinteractionsourcelocation.md) instance, available from [SpatialInteractionSourceState.Properties](spatialinteractionsourcestate_properties.md).[TryGetLocation](spatialinteractionsourceproperties_trygetlocation_1434864230.md).

This method will return null if the specified spatial interaction source does not support pointing ([IsPointingSupported](spatialinteractionsource_ispointingsupported.md) is false) or if the source did not have positional tracking at that moment.

## -see-also
[SpatialInteractionSourceLocation.SourcePointerPose](spatialinteractionsourcelocation_sourcepointerpose.md)

## -examples

