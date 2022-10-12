---
-api-id: P:Windows.UI.Input.Inking.InkStroke.DrawingAttributes
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Input.Inking.InkDrawingAttributes DrawingAttributes { get;  set; }
-->

# Windows.UI.Input.Inking.InkStroke.DrawingAttributes

## -description
Gets or sets the properties associated with an [InkStroke](inkstroke.md).

## -property-value
The drawing attributes.

## -remarks

## -examples
The following example demonstrates how to set a drawing attribute for a specific stroke.

> [!NOTE]
> You cannot set the DrawingAttributes property of the stroke directly. You must create a copy of the [InkDrawingAttributes](inkdrawingattributes.md) of the stroke, set the desired values for that [InkDrawingAttributes](inkdrawingattributes.md) object, and then assign the new [InkDrawingAttributes](inkdrawingattributes.md) to the DrawingAttributes of the stroke, as shown here.

```csharp
// Get the InkStroke objects.
IReadOnlyList<InkStroke> inkStrokes = inkManager.GetStrokes();
Windows.UI.Input.Inking.InkStroke cloneStroke = 
  inkStrokes.GetAt(index).Clone();
Windows.UI.Input.Inking.InkDrawingAttributes drawingAttributes = 
  cloneStroke.DrawingAttributes;
drawingAttributes.PenTip = Windows.UI.Input.Inking.PenTipShape.Rectangle;
cloneStroke.DrawingAttributes = drawingAttributes;
```

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

