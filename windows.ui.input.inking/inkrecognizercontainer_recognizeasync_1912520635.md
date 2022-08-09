---
-api-id: M:Windows.UI.Input.Inking.InkRecognizerContainer.RecognizeAsync(Windows.UI.Input.Inking.InkStrokeContainer,Windows.UI.Input.Inking.InkRecognitionTarget)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.UI.Input.Inking.InkRecognitionResult>> RecognizeAsync(Windows.UI.Input.Inking.InkStrokeContainer strokeCollection, Windows.UI.Input.Inking.InkRecognitionTarget recognitionTarget)
-->

# Windows.UI.Input.Inking.InkRecognizerContainer.RecognizeAsync

## -description
Performs handwriting recognition on one or more [InkStroke](inkstroke.md) objects.

## -parameters
### -param strokeCollection
The set of strokes on which recognition is performed.

### -param recognitionTarget
One of the values from the [InkRecognitionTarget](inkrecognitiontarget.md) enumeration.

## -returns
The results of the recognition as a collection of [InkRecognitionResult](inkrecognitionresult.md) objects.Each item in the collection represents a written word. For example, the string "this is a test" contains four words that are stored as a collection of four items.

## -remarks
Because [RecognizeAsync](inkmanager_recognizeasync_1262794931.md) does not automatically update the existing recognition results stored in the [InkManager](inkmanager.md), typically [UpdateRecognitionResults](inkmanager_updaterecognitionresults_1771366374.md) is called after [RecognizeAsync](inkmanager_recognizeasync_1262794931.md) has completed.

## -examples

## -see-also
[GetTextCandidates](inkrecognitionresult_gettextcandidates_1780889583.md), [Ink stroke recognition](/windows/uwp/input-and-devices/convert-ink-to-text), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

