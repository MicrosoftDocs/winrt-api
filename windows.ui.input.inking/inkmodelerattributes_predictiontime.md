---
-api-id: P:Windows.UI.Input.Inking.InkModelerAttributes.PredictionTime
-api-type: winrt property
---

<!-- Property syntax.
public TimeSpan PredictionTime { get;  set; }
-->

# Windows.UI.Input.Inking.InkModelerAttributes.PredictionTime

## -description

Gets or sets the amount of time into the future used to predict the expected location of the input pointer.

## -property-value

The time in milliseconds. The default is 15 ms, with a valid range between 0 to 20 ms.

The InkPresenter attempts to use 15ms when conditions are most favorable. When conditions are less favorable, such as a period of high acceleration, some fraction of that time is used.

## -remarks

When using the [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md), [InkModelerAttributes](inkmodelerattributes.md) should be set in the [InkToolbar.ActiveToolChanged](../windows.ui.xaml.controls/inktoolbar_activetoolchanged.md) event as attributes are overwritten whenever the active tool is changed.

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

## -examples
