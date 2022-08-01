---
-api-id: T:Windows.UI.Input.Inking.InkInputProcessingConfiguration
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkInputProcessingConfiguration : Windows.UI.Input.Inking.IInkInputProcessingConfiguration
-->

# Windows.UI.Input.Inking.InkInputProcessingConfiguration

## -description
Manages how input is processed by the [InkPresenter](inkpresenter.md) object.

## -remarks
Primary input is not from (or modified by) a secondary affordance, such as a pen barrel button, pen eraser tip, right mouse button, or similar.

Secondary input, by default, is processed as primary input and rendered as an [InkStroke](inkstroke.md) by the [InkPresenter](inkpresenter.md). For custom handling of secondary input by your application, set [InkInputProcessingConfiguration.RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) to [LeaveUnprocessed](inkinputrightdragaction.md). This indicates that input should be passed through the [InkPresenter](inkpresenter.md) as [UnprocessedInput](inkpresenter_unprocessedinput.md) for custom processing.

If [InkInputProcessingConfiguration.Mode](inkinputprocessingconfiguration_mode.md) is set to [None](inkinputprocessingmode.md), the value of [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) is ignored and input is always passed as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

If [InkInputProcessingConfiguration.Mode](inkinputprocessingconfiguration_mode.md) is set to [Inking](inkinputprocessingmode.md) or [Erasing](inkinputprocessingmode.md), the value of [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) must be set to [LeaveUnprocessed](inkinputrightdragaction.md) to pass input as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

To manage what secondary input is processed by your app, see [InkInputConfiguration](inkinputconfiguration.md).

## -examples

## -see-also
[InkPresenter.InputProcessingConfiguration](inkpresenter_inputprocessingconfiguration.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

