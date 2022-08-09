---
-api-id: M:Windows.UI.Input.Inking.IInkStrokeContainer.AddStroke(Windows.UI.Input.Inking.InkStroke)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void AddStroke(Windows.UI.Input.Inking.InkStroke stroke)
-->

# Windows.UI.Input.Inking.IInkStrokeContainer.AddStroke

## -description
Adds an [InkStroke](inkstroke.md) object to the collection managed by the [InkStrokeContainer](inkstrokecontainer.md).

## -parameters
### -param stroke
The ink stroke to be added.

*stroke* must be created by using the [Clone](inkstroke_clone_766852569.md) method, or through a call to [EndStroke](inkstrokebuilder_endstroke_245944492.md) or [ProcessPointerUp](inkmanager_processpointerup_1637073524.md). Empty or existing strokes are not valid.

## -remarks
The [StrokesCollected](inkpresenter_strokescollected.md) event is fired when ink strokes are processed ("wet" to "dry") on the UI thread.

## -examples

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

