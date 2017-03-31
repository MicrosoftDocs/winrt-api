---
-api-id: M:Windows.UI.Input.Inking.IInkStrokeContainer.GetRecognitionResults
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.UI.Input.Inking.InkRecognitionResult> GetRecognitionResults()
-->

# Windows.UI.Input.Inking.IInkStrokeContainer.GetRecognitionResults

## -description
Gets the collection of recognition matches previously processed by an [InkRecognizer](inkrecognizer.md) and stored in an [InkRecognizerContainer](inkrecognizercontainer.md).

Recognition is not supported by [InkStrokeContainer](inkstrokecontainer.md), you must use an [InkRecognizerContainer](inkrecognizercontainer.md) object.

## -returns
The results of the recognition as a collection of [InkRecognitionResult](inkrecognitionresult.md) objects.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink stroke recognition](http://msdn.microsoft.com/library/c2f3f3ce-737f-4652-98b7-5278a462f9d3), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)