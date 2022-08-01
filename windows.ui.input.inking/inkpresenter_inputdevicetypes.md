---
-api-id: P:Windows.UI.Input.Inking.InkPresenter.InputDeviceTypes
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Core.CoreInputDeviceTypes InputDeviceTypes { get;  set; }
-->

# Windows.UI.Input.Inking.InkPresenter.InputDeviceTypes

## -description

Gets or sets the input device type from which input data is collected by the [InkPresenter](inkpresenter.md) to construct and render an [InkStroke](inkstroke.md). The default is [Pen](../windows.ui.core/coreinputdevicetypes.md).

## -property-value

The input device types.

## -remarks

If you set this property to [None](../windows.ui.core/coreinputdevicetypes.md), you should remove listeners for all pointer events, including [PointerEntered](inkunprocessedinput_pointerentered.md), [PointerHovered](inkunprocessedinput_pointerhovered.md), and [PointerExited](inkunprocessedinput_pointerexited.md). In this case, pointer events are passed to the InkCanvas object and not to the InkPresenter object through [InkPresenter.UnprocessedInput](inkpresenter_unprocessedinput.md).

## -examples

Here we specify that data from all supported input devices ([CoreInputDeviceTypes](../windows.ui.core/coreinputdevicetypes.md)) be collected by the [InkPresenter](inkpresenter.md) and processed as ink input.

```csharp
inkCanvas.InkPresenter.InputDeviceTypes =
  Windows.UI.Core.CoreInputDeviceTypes.Mouse |
  Windows.UI.Core.CoreInputDeviceTypes.Pen |
  Windows.UI.Core.CoreInputDeviceTypes.Touch;

```

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)
