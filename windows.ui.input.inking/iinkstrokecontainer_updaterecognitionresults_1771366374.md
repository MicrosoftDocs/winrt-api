---
-api-id: M:Windows.UI.Input.Inking.IInkStrokeContainer.UpdateRecognitionResults(Windows.Foundation.Collections.IVectorView{Windows.UI.Input.Inking.InkRecognitionResult})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void UpdateRecognitionResults(Windows.Foundation.Collections.IVectorView<Windows.UI.Input.Inking.InkRecognitionResult> recognitionResults)
-->

# Windows.UI.Input.Inking.IInkStrokeContainer.UpdateRecognitionResults

## -description
Updates the collection of recognition matches previously processed by an [InkRecognizer](inkrecognizer.md) and stored in an [InkRecognizerContainer](inkrecognizercontainer.md).

Recognition is not supported by [InkStrokeContainer](inkstrokecontainer.md), you must use an [InkRecognizerContainer](inkrecognizercontainer.md) object.

## -parameters
### -param recognitionResults
The updated collection of [InkRecognitionResult](inkrecognitionresult.md) objects.

## -remarks

## -examples

## -see-also

[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Get started: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

