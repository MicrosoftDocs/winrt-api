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

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
The function in the following example demonstrates how a cubic Bezier curve can be derived for each segment of an ink stroke (`stroke`) by using the [bezierCurveTo](https://docs.microsoft.com/previous-versions/windows/internet-explorer/ie-developer/platform-apis/ff976007(v=vs.85)) method. Each curve is then rendered through the 2-D context of the canvas (`ctx`).

```javascript

// Render all strokes using bezier curves instead of line segments.
function renderAllStrokes()
{
    statusMessage.innerText += "Render strokes as bezier curves."

    // Clear the drawing surface of existing strokes.
    inkContext.clearRect(0, 0, inkCanvas.width, inkCanvas.height);

    // Enumerate through each stroke.
    inkManager.getStrokes().forEach(
        function (stroke)
        {
            inkContext.beginPath();
            inkContext.lineWidth = strokeWidth; 
            inkContext.strokeStyle = strokeColor; 

            // Enumerate through each line segment of the stroke.
            var first = true;
            var x = stroke.getRenderingSegments().length;
            stroke.getRenderingSegments().forEach(
                function (segment)
                {
                    // Move to the starting location of the stroke.
                    if (first)
                    {
                        inkContext.moveTo(segment.position.x, segment.position.y);
                        first = false;
                    }
                    // Calculate the bezier curve for the segment.
                    else
                    {
                        inkContext.bezierCurveTo(segment.bezierControlPoint1.x, 
                                                 segment.bezierControlPoint1.y,
                                                 segment.bezierControlPoint2.x, 
                                                 segment.bezierControlPoint2.y,
                                                 segment.position.x, segment.position.y);
                    }
                }
            );
            
            // Draw the stroke.
            inkContext.stroke();
            inkContext.closePath();
        }
    );
}
```

For the complete example, see [Ink App sample](https://go.microsoft.com/fwlink/p/?linkid=231622).

## -see-also
[bezierCurveTo](https://docs.microsoft.com/previous-versions/windows/internet-explorer/ie-developer/platform-apis/ff976007(v=vs.85)), [Pen and stylus interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

