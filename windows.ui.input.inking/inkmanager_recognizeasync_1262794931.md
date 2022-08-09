---
-api-id: M:Windows.UI.Input.Inking.InkManager.RecognizeAsync(Windows.UI.Input.Inking.InkRecognitionTarget)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.UI.Input.Inking.InkRecognitionResult>> RecognizeAsync(Windows.UI.Input.Inking.InkRecognitionTarget recognitionTarget)
-->

# Windows.UI.Input.Inking.InkManager.RecognizeAsync

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Performs handwriting recognition on one or more [InkStroke](inkstroke.md) objects.

## -parameters
### -param recognitionTarget
One of the values from the [InkRecognitionTarget](inkrecognitiontarget.md) enumeration.

## -returns
The results of the recognition as a collection of [InkRecognitionResult](inkrecognitionresult.md) objects. Each item in the results returned by recognition represents one written word. Each word is associated with a ranked list of text strings (retrieved through a call to [GetTextCandidates](inkrecognitionresult_gettextcandidates_1780889583.md)) as potential matches for the word.

## -remarks
Because RecognizeAsync does not automatically update the existing recognition results stored in the [InkManager](inkmanager.md), [UpdateRecognitionResults](inkmanager_updaterecognitionresults_1771366374.md) is typically called after RecognizeAsync has completed.

## -examples

## -see-also
[RecognizeAsync(InkStrokeContainer, InkRecognitionTarget)](inkmanager_recognizeasync_1912520635.md), [GetTextCandidates](inkrecognitionresult_gettextcandidates_1780889583.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

