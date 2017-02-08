---
-api-id: M:Windows.UI.Core.TouchHitTestingEventArgs.EvaluateProximity(Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Core.CoreProximityEvaluation EvaluateProximity(Windows.Foundation.Rect controlBoundingBox)
-->

# Windows.UI.Core.TouchHitTestingEventArgs.EvaluateProximity

## -description
Returns a ranking for the rectangle as the probable touch target and an adjusted touch point within the rectangle. The rank is determined through a comparison of targeting heuristics for all rectangles that intersect the touch contact area.

## -parameters
### -param controlBoundingBox
The [Rect](../windows.foundation/rect.md) that defines the bounding box of the UI element.

## -returns
The [CoreProximityEvaluation](coreproximityevaluation.md) structure that holds the rank and adjusted touch point data.

## -remarks

## -examples

## -see-also
[EvaluateProximity(Point)](touchhittestingeventargs_evaluateproximity_64169594.md)