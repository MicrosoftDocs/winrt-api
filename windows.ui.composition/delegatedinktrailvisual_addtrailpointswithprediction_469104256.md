---
-api-id: M:Windows.UI.Composition.DelegatedInkTrailVisual.AddTrailPointsWithPrediction(Windows.UI.Composition.InkTrailPoint[],Windows.UI.Composition.InkTrailPoint[])
-api-type: winrt method
---

# Windows.UI.Composition.DelegatedInkTrailVisual.AddTrailPointsWithPrediction(Windows.UI.Composition.InkTrailPoint[],Windows.UI.Composition.InkTrailPoint[])

<!--
public uint AddTrailPointsWithPrediction (Windows.UI.Composition.InkTrailPoint[] inkPoints, Windows.UI.Composition.InkTrailPoint[] predictedInkPoints);
-->

## -description

Adds both actual and predicted "wet" ink points to the [DelegatedInkTrailVisual](delegatedinktrailvisual.md).

## -parameters

### -param inkPoints

The actual "wet" ink points.

### -param predictedInkPoints

The predicted "wet" ink points.

## -returns

The generation ID for the "wet" ink points.

## -remarks

Predicted points act like actual points and are appended to the end of the ink trail after any actual points.

Subsequent calls to AddTrailPoints (or AddTrailPointsWithPrediction) will remove all predicted points before adding new points.

The predicted points are provided by the app to reduce ink latency. They are overwritten by the actual positions when received by the app and added to the [DelegatedInkTrailVisual](delegatedinktrailvisual.md).

## -see-also

[StartNewTrail(Windows.UI.Color)](delegatedinktrailvisual_startnewtrail_529274255.md), [RemoveTrailPoints(System.UInt32)](delegatedinktrailvisual_removetrailpoints_175287411.md)

## -examples
