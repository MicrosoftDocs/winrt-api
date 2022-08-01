---
-api-id: P:Windows.UI.Input.Inking.InkDrawingAttributes.FitToCurve
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool FitToCurve { get;  set; }
-->

# Windows.UI.Input.Inking.InkDrawingAttributes.FitToCurve

## -description
Gets or sets a value that indicates whether a Bezier curve or a collection of straight line segments is used to draw an [InkStroke](inkstroke.md).

## -property-value
**true** if a Bezier curve is used; otherwise **false**. The default value is **true**.

## -remarks

## -examples
The following example demonstrates how to set the FitToCurve attribute for all strokes managed by this [InkManager](inkmanager.md) object (`inkManager`) that are created after the [SetDefaultDrawingAttributes](inkmanager_setdefaultdrawingattributes_1436218448.md) method call.

```csharp
var inkManager = new Windows.UI.Input.Inking.InkManager();
var drawingAttributes = 
     new Windows.UI.Input.Inking.InkDrawingAttributes();
// True is the Default value for fitToCurve.
drawingAttributes.fitToCurve = false;
inkManager.setDefaultDrawingAttributes(drawingAttributes);

```

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

