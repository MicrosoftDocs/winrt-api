---
-api-id: M:Windows.UI.Input.Inking.InkStroke.GetRenderingSegments
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.UI.Input.Inking.InkStrokeRenderingSegment> GetRenderingSegments()
-->

# Windows.UI.Input.Inking.InkStroke.GetRenderingSegments

## -description
Gets the rendering segments of the stroke.

> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), use [GetInkPoints](inkstroke_getinkpoints_1369941995.md) (see remarks).

## -returns
The collection of [InkStrokeRenderingSegment](inkstrokerenderingsegment.md) objects.

## -remarks
If [FitToCurve](inkdrawingattributes_fittocurve.md) is set to true, this method returns an [InkStrokeRenderingSegment](inkstrokerenderingsegment.md) that approximates the Bezier curve of the stroke.

If [FitToCurve](inkdrawingattributes_fittocurve.md) is set to false, this method returns a collection of [InkStrokeRenderingSegment](inkstrokerenderingsegment.md) objects that represent the original raw pointer data as line segments.

For Universal Windows app using Extensible Application Markup Language (XAML), avoid changing the state of an ink stroke to retrieve the raw pointer data by using [GetInkPoints](inkstroke_getinkpoints_1369941995.md) instead.

## -examples

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

