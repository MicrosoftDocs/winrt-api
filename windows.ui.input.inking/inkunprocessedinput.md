---
-api-id: T:Windows.UI.Input.Inking.InkUnprocessedInput
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkUnprocessedInput : Windows.UI.Input.Inking.IInkUnprocessedInput
-->

# Windows.UI.Input.Inking.InkUnprocessedInput

## -description
Provides properties and events for custom processing of ink data from an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control. The data is not processed by the [InkPresenter](inkpresenter.md).

Use [InkInputProcessingConfiguration](inkinputprocessingconfiguration.md) to identify the data to pass through as [UnprocessedInput](inkpresenter_unprocessedinput.md).

## -remarks
Input from various devices (including touch, pen, and mouse) is received, processed, and managed as pointer input. User interactions based on any of these devices can produce a [PointerEntered](inkunprocessedinput_pointerentered.md), [PointerExited](inkunprocessedinput_pointerexited.md), [PointerReleased](inkunprocessedinput_pointerreleased.md), [PointerPressed](inkunprocessedinput_pointerpressed.md), [PointerMoved](inkunprocessedinput_pointermoved.md), [PointerLost](inkunprocessedinput_pointerlost.md), or [PointerHovered](inkunprocessedinput_pointerhovered.md), event. For more info, see [Handle pointer input](/windows/uwp/input-and-devices/handle-pointer-input).

## -examples

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

