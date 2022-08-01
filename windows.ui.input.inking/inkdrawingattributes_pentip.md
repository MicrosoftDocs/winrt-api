---
-api-id: P:Windows.UI.Input.Inking.InkDrawingAttributes.PenTip
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Input.Inking.PenTipShape PenTip { get;  set; }
-->

# Windows.UI.Input.Inking.InkDrawingAttributes.PenTip

## -description
Gets or sets a value that indicates the shape of the pen tip when you draw an [InkStroke](inkstroke.md).

## -property-value
The shape of the pen/stylus tip. The default is [Circle](pentipshape.md).


## -remarks
Support various calligraphic effects using the [PenTipShape](pentipshape.md) property with PenTip.

## -examples
The following example demonstrates how to set the PenTip attribute for all strokes managed by an [InkManager](inkmanager.md) object (`inkManager`).

```csharp
var inkManager = new Windows.UI.Input.Inking.InkManager();
var drawingAttributes = new Windows.UI.Input.Inking.InkDrawingAttributes();
drawingAttributes.penTip = Windows.UI.Input.Inking.PenTipShape.rectangle;
inkManager.setDefaultDrawingAttributes(drawingAttributes);
```

## -see-also
[PenTipTransform](inkdrawingattributes_pentiptransform.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)
