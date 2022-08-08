---
-api-id: M:Windows.UI.Composition.DelegatedInkTrailVisual.StartNewTrail(Windows.UI.Color)
-api-type: winrt method
---

# Windows.UI.Composition.DelegatedInkTrailVisual.StartNewTrail(Windows.UI.Color)

<!--
public void StartNewTrail (Windows.UI.Color color);
-->

## -description

Specifies that a new "wet" ink stroke should be started and [AddTrailPoints(Windows.UI.Composition.InkTrailPoint[])](/uwp/api/windows.ui.composition.delegatedinktrailvisual.addtrailpointswithprediction) should be called.

## -parameters

### -param color

The color of the ink stroke.

## -remarks

After a trail has been started and trail points added, calling StartNewTrail again will reset the state of the ink trail. All existing points are removed, and any subsequent points will be rendered using the new color.

## -see-also

## -examples
