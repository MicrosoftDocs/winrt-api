---
-api-id: T:Windows.UI.Input.Inking.InkManipulationMode
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Inking.InkManipulationMode : int
-->

# InkManipulationMode

## -description
Specifies the modes of ink input.

## -enum-fields
### -field Inking:0
All points are passed to the [InkStrokeBuilder](inkstrokebuilder.md) and an [InkStroke](inkstroke.md) is created. The stroke is appended to the stroke collection of the [InkManager](inkmanager.md) or [InkStrokeContainer](inkstrokecontainer.md).

### -field Erasing:1
All strokes are hit tested against all strokes in the stroke collection. If there is an intersection, [InkManager](inkmanager.md) deletes the stroke automatically and returns an invalidated rectangle for [processPointerUpdate](inkmanager_processpointerupdate_416065930.md) calls.

### -field Selecting:2
All points are used to create a polyline. When you call [processPointerUp](inkmanager_processpointerup_1637073524.md), the polyline is hit tested against entire stroke collection and all strokes within the polyline are marked as selected.


## -remarks

## -examples

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

