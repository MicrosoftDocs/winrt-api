---
-api-id: M:Windows.UI.Input.Inking.InkStrokeBuilder.CreateStrokeFromInkPoints(Windows.Foundation.Collections.IIterable{Windows.UI.Input.Inking.InkPoint},Windows.Foundation.Numerics.Matrix3x2)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Input.Inking.InkStroke CreateStrokeFromInkPoints(Windows.Foundation.Collections.IIterable<Windows.UI.Input.Inking.InkPoint> inkPoints, Windows.Foundation.Numerics.Matrix3x2 transform)
-->

# Windows.UI.Input.Inking.InkStrokeBuilder.CreateStrokeFromInkPoints

## -description
Creates a basic ink stroke from collection of [InkPoint](inkpoint.md) objects.

> [!NOTE]
> Use [CreateStrokeFromInkPoints](inkstrokebuilder_createstrokefrominkpoints_2009821049.md) and [SetDefaultDrawingAttributes](inkstrokebuilder_setdefaultdrawingattributes_1436218448.md) to programmatically build strokes for an [InkPresenter](inkpresenter.md).

## -parameters
### -param inkPoints
The collection of [InkPoint](inkpoint.md) objects.

### -param transform
A 2-D transformation matrix.

## -returns
The ink stroke, including the Bézier curve parameters used for final rendering of the stroke.

## -remarks

## -examples

## -see-also
[CreateStrokeFromInkPoints(CreateStrokeFromInkPoints(IIterable<InkPoint> inkPoints, Matrix3x2 transform, IReference<DateTime> strokeStartedTime, IReference<TimeSpan> strokeDuration)](inkstrokebuilder_createstrokefrominkpoints_2009821049.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

