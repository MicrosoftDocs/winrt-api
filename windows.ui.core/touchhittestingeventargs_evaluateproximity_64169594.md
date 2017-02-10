---
-api-id: M:Windows.UI.Core.TouchHitTestingEventArgs.EvaluateProximity(Windows.Foundation.Point[])
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Core.CoreProximityEvaluation EvaluateProximity(Windows.Foundation.Point[] controlVertices)
-->

# Windows.UI.Core.TouchHitTestingEventArgs.EvaluateProximity

## -description
Returns a ranking for the polygon as the probable touch target and an adjusted touch point within the polygon. The rank is determined through a comparison of targeting heuristics for all polygons that intersect the touch contact area.

## -parameters
### -param controlVertices
The array of x-y screen coordinates that define the shape of the UI element (the number of vertices in the polygon). This value must be greater than or equal to 3.

## -returns
The [CoreProximityEvaluation](coreproximityevaluation.md) structure that holds the rank and adjusted touch point data.

## -remarks

## -examples

## -see-also
[EvaluateProximity(Rect)](touchhittestingeventargs_evaluateproximity_1601670783.md)