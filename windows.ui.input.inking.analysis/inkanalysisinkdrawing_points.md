---
-api-id: P:Windows.UI.Input.Inking.Analysis.InkAnalysisInkDrawing.Points
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<Point> Points { get; }
-->

# Windows.UI.Input.Inking.Analysis.InkAnalysisInkDrawing.Points

## -description

Gets the collection of X, Y coordinates for all [points](../windows.foundation/point.md) used to specify the [shape](InkAnalysisDrawingKind.md) of the InkAnalysisInkDrawing object.

## -property-value

## -remarks

The collection of [points](../windows.foundation/point.md) is dependent on the shape drawn.
- Ellipse: four points, one for each end point of the two axes defining the shape
- Polyline: one point for each vertex defining the shape

## -see-also

## -examples

