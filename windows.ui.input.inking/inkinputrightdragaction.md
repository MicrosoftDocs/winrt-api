---
-api-id: T:Windows.UI.Input.Inking.InkInputRightDragAction
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Inking.InkInputRightDragAction : int
-->

# InkInputRightDragAction

## -description
Specifies how the [InkPresenter](inkpresenter.md) object handles secondary input from a pen barrel button, pen eraser tip, right mouse button, or similar.

By default, this secondary input is processed as primary input and rendered as an [InkStroke](inkstroke.md) (see remarks).

## -enum-fields
### -field LeaveUnprocessed:0
All input is [UnprocessedInput](inkpresenter_unprocessedinput.md). This passes all input through to the app for custom processing.

### -field AllowProcessing:1
All input is unmodified by a secondary affordance and is processed as standard ink input by the [InkPresenter](inkpresenter.md).


## -remarks
To manage how secondary input is processed by your app, see [InkInputProcessingConfiguration](inkinputprocessingconfiguration.md).

To pass input as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing, set [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) to **LeaveUnprocessed**.

If [InkInputProcessingConfiguration.Mode](inkinputprocessingconfiguration_mode.md) is set to [Inking](inkinputprocessingmode.md) or [Erasing](inkinputprocessingmode.md), the value of [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) must be set to **LeaveUnprocessed** to pass input as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

If [InkInputProcessingConfiguration.Mode](inkinputprocessingconfiguration_mode.md) is set to [None](inkinputprocessingmode.md), the value of [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) is ignored and input is always passed as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

## -examples

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

