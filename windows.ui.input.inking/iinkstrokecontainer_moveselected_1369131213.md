---
-api-id: M:Windows.UI.Input.Inking.IInkStrokeContainer.MoveSelected(Windows.Foundation.Point)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Rect MoveSelected(Windows.Foundation.Point translation)
-->

# Windows.UI.Input.Inking.IInkStrokeContainer.MoveSelected

## -description
Moves the selected strokes. All affected strokes are re-rendered.

## -parameters
### -param translation
The destination screen coordinates for the upper-left corner of the bounding rectangle of the selected strokes.

## -returns
The bounding rectangle of the selected ink strokes.

## -remarks
The following can result from a call to [MoveSelected](inkstrokecontainer_moveselected_1369131213.md):
+ Moving one or more strokes that make up part of a word results in the reprocessing of existing ink recognition results.
+ Moving all strokes that make up a word results in the recalculation of the [BoundingRect](inkrecognitionresult_boundingrect.md) of the [InkRecognitionResult](inkrecognitionresult.md). Ink recognition is not reprocessed.
+ Moving one or more strokes results in the recalculation of the [BoundingRect](inkstroke_boundingrect.md) for each stroke.
+ Moving one or more strokes results in the recalculation of the [BoundingRect](inkstrokecontainer_boundingrect.md) of the [InkStrokeContainer](inkstrokecontainer.md).


## -examples

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

