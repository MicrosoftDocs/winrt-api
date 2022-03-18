---
-api-id: T:Windows.UI.Input.Inking.InkStrokeRenderingSegment
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkStrokeRenderingSegment : Windows.UI.Input.Inking.IInkStrokeRenderingSegment
-->

# Windows.UI.Input.Inking.InkStrokeRenderingSegment

## -description
A single segment of a complete ink stroke.

A single segment consists of a starting point, an ending point, and two Bezier control points. However, for a series of segments that make up a stroke, the last point of the previous segment is the first point of the current segment. This means that only the ending point for each segment is required to represent a complete stroke.

Each stroke is a vector of InkStrokeRenderingSegment objects with the first segment identified by a single starting point and all remaining segments identified by an ending point and two Bezier control points.

## -remarks
Set the [FitToCurve](inkdrawingattributes_fittocurve.md) property of [DrawingAttributes](inkstroke_drawingattributes.md) to true if you want an ink stroke to be rendered with cubic Bezier curves. Otherwise, the stroke is rendered with straight line segments.

## -examples
The function in the following example demonstrates how a cubic Bezier curve can be derived for each segment of an ink stroke (`stroke`).

```csharp
        public static Windows.UI.Xaml.Shapes.Path CreateBezierPath(Windows.UI.Input.Inking.InkStroke stroke)
        {
            // Create Bezier geometries using information provided by the stroke's segments
            var figure = new Windows.UI.Xaml.Media.PathFigure();
            var segments = stroke.GetRenderingSegments().GetEnumerator();
            segments.MoveNext();
            // First segment is degenerate and corresponds to initial position
            figure.StartPoint = segments.Current.Position;
            // Now loop through all remaining segments
            while (segments.MoveNext())
            {
                var bs = new Windows.UI.Xaml.Media.BezierSegment();
                bs.Point1 = segments.Current.BezierControlPoint1;
                bs.Point2 = segments.Current.BezierControlPoint2;
                bs.Point3 = segments.Current.Position;
                figure.Segments.Add(bs);
            }

            // Create and initialize the data structures necessary to render the figure
            var geometry = new Windows.UI.Xaml.Media.PathGeometry();
            geometry.Figures.Add(figure);
            var path = new Windows.UI.Xaml.Shapes.Path();
            path.Data = geometry;

            // Set the stroke's graphical properties, which are controlled by the Path object
            path.Stroke = new Windows.UI.Xaml.Media.SolidColorBrush(stroke.DrawingAttributes.Color);
            path.StrokeThickness = stroke.DrawingAttributes.Size.Width;
            path.StrokeLineJoin = Windows.UI.Xaml.Media.PenLineJoin.Round;
            path.StrokeStartLineCap = Windows.UI.Xaml.Media.PenLineCap.Round;

            return path;
        }
```

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Input: Simplified ink sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Simplified%20ink%20sample), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

