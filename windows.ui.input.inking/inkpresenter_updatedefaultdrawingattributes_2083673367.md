---
-api-id: M:Windows.UI.Input.Inking.InkPresenter.UpdateDefaultDrawingAttributes(Windows.UI.Input.Inking.InkDrawingAttributes)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void UpdateDefaultDrawingAttributes(Windows.UI.Input.Inking.InkDrawingAttributes value)
-->

# Windows.UI.Input.Inking.InkPresenter.UpdateDefaultDrawingAttributes

## -description
Sets the [InkDrawingAttributes](inkdrawingattributes.md) used by the [InkPresenter](inkpresenter.md) when rendering a new [InkStroke](inkstroke.md) on an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

This method is used in conjunction with [CopyDefaultDrawingAttributes](inkpresenter_copydefaultdrawingattributes_553706939.md) to set drawing attributes at run time.

## -parameters
### -param value
The drawing attributes for new ink strokes.

## -remarks
This method does not return the attributes of existing, or currently drawing, ink strokes.

## -examples

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

