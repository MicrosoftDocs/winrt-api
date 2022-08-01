---
-api-id: M:Windows.UI.Input.Inking.InkManager.UpdateRecognitionResults(Windows.Foundation.Collections.IVectorView{Windows.UI.Input.Inking.InkRecognitionResult})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void UpdateRecognitionResults(Windows.Foundation.Collections.IVectorView<Windows.UI.Input.Inking.InkRecognitionResult> recognitionResults)
-->

# Windows.UI.Input.Inking.InkManager.UpdateRecognitionResults

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Updates the collection of potential text matches from handwriting recognition.

## -parameters
### -param recognitionResults
The results returned by recognition, where each [InkRecognitionResult](inkrecognitionresult.md) object represents one written word. 

> [!NOTE]
> Each word is associated with a ranked list of text strings (retrieved through a call to [GetTextCandidates](inkrecognitionresult_gettextcandidates_1780889583.md)) as potential matches for the word.

## -remarks

## -examples

## -see-also
[RecognizeAsync(InkRecognitionTarget)](inkmanager_recognizeasync_1262794931.md), [RecognizeAsync(InkStrokeContainer, InkRecognitionTarget)](inkmanager_recognizeasync_1912520635.md), [InkRecognizerContainer.RecognizeAsync](inkrecognizercontainer_recognizeasync_1912520635.md), [IInkRecognizerContainer.RecognizeAsync](iinkrecognizercontainer_recognizeasync_1912520635.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

