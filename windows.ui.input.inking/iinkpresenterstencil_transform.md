---
-api-id: P:Windows.UI.Input.Inking.IInkPresenterStencil.Transform
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Matrix3x2 Transform { get;  set; }
-->

# Windows.UI.Input.Inking.IInkPresenterStencil.Transform

## -description
Gets or sets the position and rotation angle of the [IInkPresenterStencil](iinkpresenterstencil.md) object within the 2-D coordinate space of the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

Both position and rotation are based on the top left corner of the stencil relative to the origin of the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

## -property-value
The position and angle of the stencil as a 3*2 floating point matrix.The default position is the origin of the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md). The default rotation angle is 45 degrees.

## -remarks

## -examples

## -see-also

[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Get started: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

