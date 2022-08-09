---
-api-id: T:Windows.UI.Input.Inking.InkInputProcessingMode
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Inking.InkInputProcessingMode : int
-->

# InkInputProcessingMode

## -description
Specifies how the [InkPresenter](inkpresenter.md) object interprets input from its associated [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

By default, input is handled as standard ink or erase strokes, or it can be passed as [UnprocessedInput](inkpresenter_unprocessedinput.md) to your app for custom processing.

## -enum-fields
### -field None:0
All input events are passed to the app and are not processed by the [InkPresenter](inkpresenter.md).

### -field Inking:1
Input is treated as ink.

### -field Erasing:2
Input is treated as erase.


## -remarks
If [Mode](inkinputprocessingconfiguration_mode.md) is set to **None**, the value of [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) is ignored and input is always passed as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

If [Mode](inkinputprocessingconfiguration_mode.md) is set to **Inking** or **Erasing**, the value of [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) must be set to [LeaveUnprocessed](inkinputrightdragaction.md) to pass input as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

To manage how secondary input is processed by your app, see [InkInputProcessingConfiguration](inkinputprocessingconfiguration.md).

## -examples

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

