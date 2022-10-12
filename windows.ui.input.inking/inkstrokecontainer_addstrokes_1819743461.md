---
-api-id: M:Windows.UI.Input.Inking.InkStrokeContainer.AddStrokes(Windows.Foundation.Collections.IIterable{Windows.UI.Input.Inking.InkStroke})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void AddStrokes(Windows.Foundation.Collections.IIterable<Windows.UI.Input.Inking.InkStroke> strokes)
-->

# Windows.UI.Input.Inking.InkStrokeContainer.AddStrokes

## -description
Adds one or more ink strokes to the collection managed by the [InkStrokeContainer](inkstrokecontainer.md).

> An [InkStroke](inkstroke.md) cannot exist in more than one [InkStrokeContainer](inkstrokecontainer.md). Call the [Clone](inkstroke_clone_766852569.md) method to duplicate a stroke in another container.

## -parameters
### -param strokes
The ink strokes to be added as a collection of [InkStroke](inkstroke.md) objects.Each *stroke* must be created using the [Clone](inkstroke_clone_766852569.md) method, or through a call to [EndStroke](inkstrokebuilder_endstroke_245944492.md) or [ProcessPointerUp](inkmanager_processpointerup_1637073524.md). Empty or existing strokes are not valid.

## -remarks

## -examples

## -see-also
[InkStroke](inkstroke.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

