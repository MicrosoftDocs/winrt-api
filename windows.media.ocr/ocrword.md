---
-api-id: T:Windows.Media.Ocr.OcrWord
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class OcrWord : Windows.Media.Ocr.IOcrWord
-->

# Windows.Media.Ocr.OcrWord

## -description
Represents a single word in a line of text recognized by the OCR engine and returned as part of the [OcrLine](ocrline.md).

## -remarks
When you call the [RecognizeAsync](ocrengine_recognizeasync_614325911.md) method of the [OcrEngine](ocrengine.md) class, the method returns an [OcrResult](ocrresult.md) object. The **OcrResult** contains a collection of [OcrLine](ocrline.md) objects, which you access through the [Lines](ocrresult_lines.md) property of the **OcrResult**. Each **OcrLine** object contains a collection of **OcrWord** objects, which you access through the [Words](ocrline_words.md) property of each **OcrLine**.

## -examples

## -see-also
