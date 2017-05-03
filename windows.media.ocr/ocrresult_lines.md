---
-api-id: P:Windows.Media.Ocr.OcrResult.Lines
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.Ocr.OcrLine> Lines { get; }
-->

# Windows.Media.Ocr.OcrResult.Lines

## -description
Gets the collection of [OcrLine](ocrline.md) objects that represents the lines of text detected in the image by the [RecognizeAsync](ocrengine_recognizeasync.md) method.

## -property-value
The collection of [OcrLine](ocrline.md) objects that represents the lines of text detected in the image by the [RecognizeAsync](ocrengine_recognizeasync.md) method.

## -remarks
When you call the [RecognizeAsync](ocrengine_recognizeasync.md) method of the [OcrEngine](ocrengine.md) class, the method returns an [OcrResult](ocrresult.md) object. The **OcrResult** contains a collection of [OcrLine](ocrline.md) objects, which you access through the **Lines** property of the **OcrResult**. Each **OcrLine** object contains a collection of [OcrWord](ocrword.md) objects, which you access through the [Words](ocrline_words.md) property of each **OcrLine**.

## -examples

## -see-also
