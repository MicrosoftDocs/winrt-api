---
-api-id: M:Windows.UI.Composition.DelegatedInkTrailVisual.RemoveTrailPoints(System.UInt32)
-api-type: winrt method
---

# Windows.UI.Composition.DelegatedInkTrailVisual.RemoveTrailPoints(System.UInt32)

<!--
public void RemoveTrailPoints (uint generationId);
-->

## -description

Removes the [InkTrailPoints](inktrailpoint.md) as the app sends its rendered ink to the system.

## -parameters

### -param generationId

The ID assigned by [AddTrailPoints(Windows.UI.Composition.InkTrailPoint[])](/uwp/api/windows.ui.composition.delegatedinktrailvisual.addtrailpoints) or [AddTrailPointsWithPrediction(Windows.UI.Composition.InkTrailPoint[],Windows.UI.Composition.InkTrailPoint[])](/uwp/api/windows.ui.composition.delegatedinktrailvisual.addtrailpointswithprediction).

## -remarks

The app can still receive new input points on its input thread while the "dry" ink is being rendered. These points are immediately sent to [AddTrailPoints(Windows.UI.Composition.InkTrailPoint[])](/uwp/api/windows.ui.composition.delegatedinktrailvisual.addtrailpoints) for rendering the "wet" ink stroke.

## -see-also

## -examples
