---
-api-id: P:Windows.UI.Input.Inking.InkDrawingAttributes.Color
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Color Color { get;  set; }
-->

# Windows.UI.Input.Inking.InkDrawingAttributes.Color

## -description
Gets or sets a value that indicates the color of an [InkStroke](inkstroke.md).

## -property-value
The ink color as an ARGB value. The default is black (0, 0, 0, 0).

## -remarks
The value of Color is an ARGB value. However, the value of the transparency component (A, or alpha channel) is ignored and the [InkStroke](inkstroke.md) is rendered at full opacity.

The value of the transparency component is not discarded. It is stored with all other stroke data in the Ink Serialized Format (ISF) file when the [InkStroke](inkstroke.md) is saved.

## -examples

The following example demonstrates how to set the Color property (`color`) of an [InkStroke](inkstroke.md) (`stroke`) using the [Windows.UI.ColorHelper.FromArgb](../windows.ui/colorhelper_fromargb_1449236110.md) method.

```csharp
var drawingAttributes = stroke.drawingAttributes;
drawingAttributes.color = 
     Windows.UI.ColorHelper.fromArgb(255, 255, 0, 0);
stroke.drawingAttributes = drawingAttributes;
```

The following alternative demonstrates how to set the Color property (`color`) of an [InkStroke](inkstroke.md) (`stroke`) without using the [Windows.UI.ColorHelper.FromArgb](../windows.ui/colorhelper_fromargb_1449236110.md) method.

```csharp
var drawingAttributes = stroke.drawingAttributes;
var color = drawingAttributes.color;
color.a = 255;
color.r = 255;
color.g = 0;
color.b = 0;
drawingAttributes.color = color;
stroke.drawingAttributes = drawingAttributes;
```

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

