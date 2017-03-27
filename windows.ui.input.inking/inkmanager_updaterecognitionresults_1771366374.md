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
> Each word is associated with a ranked list of text strings (retrieved through a call to [GetTextCandidates](inkrecognitionresult_gettextcandidates.md)) as potential matches for the word.

## -remarks

## -examples

## -see-also
[RecognizeAsync(InkRecognitionTarget)](inkmanager_recognizeasync_1262794931.md), [RecognizeAsync(InkStrokeContainer, InkRecognitionTarget)](inkmanager_recognizeasync_1912520635.md), [InkRecognizerContainer.RecognizeAsync](inkrecognizercontainer_recognizeasync.md), [IInkRecognizerContainer.RecognizeAsync](iinkrecognizercontainer_recognizeasync.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink stroke recognition](http://msdn.microsoft.com/library/c2f3f3ce-737f-4652-98b7-5278a462f9d3), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)