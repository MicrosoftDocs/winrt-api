---
-api-id: M:Windows.UI.Input.Inking.InkRecognitionResult.GetTextCandidates
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<string> GetTextCandidates()
-->

# Windows.UI.Input.Inking.InkRecognitionResult.GetTextCandidates

## -description
Retrieves the collection of strings identified as potential matches for each word returned by handwriting recognition.

## -returns
The recognition matches as a collection of [String](https://msdn.microsoft.com/library/system.string.aspx) objects. The most likely candidate is topmost in the collection.

## -remarks

## -examples

## -see-also
[InkManager](inkmanager.md), [RecognizeAsync(InkRecognitionTarget)](inkmanager_recognizeasync_1262794931.md), [RecognizeAsync(InkStrokeContainer, InkRecognitionTarget)](inkmanager_recognizeasync_1912520635.md), [InkRecognizerContainer.RecognizeAsync](inkrecognizercontainer_recognizeasync.md), [IInkRecognizerContainer.RecognizeAsync](iinkrecognizercontainer_recognizeasync.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink stroke recognition](http://msdn.microsoft.com/library/c2f3f3ce-737f-4652-98b7-5278a462f9d3), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)