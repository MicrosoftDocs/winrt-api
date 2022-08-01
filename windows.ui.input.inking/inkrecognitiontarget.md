---
-api-id: T:Windows.UI.Input.Inking.InkRecognitionTarget
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Inking.InkRecognitionTarget : int
-->

# InkRecognitionTarget

## -description
Indicates which strokes you want to include in handwriting recognition.

## -enum-fields
### -field All:0
All strokes in the stroke collection are passed to the recognizer.

### -field Selected:1
Selected ([Selected](inkstroke_selected.md)) strokes are passed to the recognizer.

### -field Recent:2
All strokes added after the last recognition pass ([Recognized](inkstroke_recognized.md) is false) are passed to the recognizer.This is useful in incremental recognition scenarios, such as direct tracking of ink input (no indirect controls are used to start recognition).


## -remarks

## -examples

## -see-also
[RecognizeAsync(InkRecognitionTarget)](inkmanager_recognizeasync_1262794931.md), [RecognizeAsync(InkStrokeContainer, InkRecognitionTarget)](inkmanager_recognizeasync_1912520635.md), [InkRecognizerContainer.RecognizeAsync](inkrecognizercontainer_recognizeasync_1912520635.md), [IInkRecognizerContainer.RecognizeAsync](iinkrecognizercontainer_recognizeasync_1912520635.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

