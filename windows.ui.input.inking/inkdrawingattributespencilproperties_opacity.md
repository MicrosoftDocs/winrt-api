---
-api-id: P:Windows.UI.Input.Inking.InkDrawingAttributesPencilProperties.Opacity
-api-type: winrt property
---

<!-- Property syntax
public double Opacity { get;  set; }
-->

# Windows.UI.Input.Inking.InkDrawingAttributesPencilProperties.Opacity

## -description

Gets or sets the level of transparency used for rendering a pencil stroke on an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

Opacity is a static property of [InkDrawingAttributes](inkdrawingattributes.md).

Get an instance of this class by calling [InkDrawingAttributes.CreateForPencil](inkdrawingattributes_createforpencil_181700669.md) and accessing [InkDrawingAttributes.PencilProperties](inkdrawingattributes_pencilproperties.md).

## -property-value

A value between 0.01 and 5.0 that specifies the opacity factor, with 5.0 indicating full opacity. The default value is 1.0.

## -remarks

## -examples

## -see-also

[InkToolbar](../windows.ui.xaml.controls/inktoolbar.md), [InkToolbarPencilButton](../windows.ui.xaml.controls/inktoolbarpencilbutton.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

