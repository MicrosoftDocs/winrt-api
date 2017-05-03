---
-api-id: M:Windows.UI.Input.Inking.InkManager.RecognizeAsync(Windows.UI.Input.Inking.InkStrokeContainer,Windows.UI.Input.Inking.InkRecognitionTarget)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.UI.Input.Inking.InkRecognitionResult>> RecognizeAsync(Windows.UI.Input.Inking.InkStrokeContainer strokeCollection, Windows.UI.Input.Inking.InkRecognitionTarget recognitionTarget)
-->

# Windows.UI.Input.Inking.InkManager.RecognizeAsync

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Performs handwriting recognition on one or more [InkStroke](inkstroke.md) objects.

## -parameters
### -param strokeCollection
The set of strokes on which recognition is performed.

### -param recognitionTarget
One of the values from the [InkRecognitionTarget](inkrecognitiontarget.md) enumeration.

## -returns
The results of the recognition as a collection of [InkRecognitionResult](inkrecognitionresult.md) objects.Each item in the results returned by recognition represents one written word. Each word is associated with a ranked list of text strings (retrieved through a call to [GetTextCandidates](inkrecognitionresult_gettextcandidates.md)) as potential matches for the word.

## -remarks
Because [RecognizeAsync](inkmanager_recognizeasync_1262794931.md) does not automatically update the existing recognition results stored in the [InkManager](inkmanager.md), [UpdateRecognitionResults](inkmanager_updaterecognitionresults.md) is typically called after [RecognizeAsync](inkmanager_recognizeasync_1262794931.md) has completed.

## -examples

## -see-also
[RecognizeAsync(InkRecognitionTarget)](inkmanager_recognizeasync_1262794931.md), [GetTextCandidates](inkrecognitionresult_gettextcandidates.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink stroke recognition](http://msdn.microsoft.com/library/c2f3f3ce-737f-4652-98b7-5278a462f9d3), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)