---
-api-id: T:Windows.Media.Ocr.OcrLine
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class OcrLine : Windows.Media.Ocr.IOcrLine
-->

# Windows.Media.Ocr.OcrLine

## -description
Represents a single line of text recognized by the OCR engine and returned as part of the [OcrResult](ocrresult.md).

## -remarks
When you call the [RecognizeAsync](ocrengine_recognizeasync.md) method of the [OcrEngine](ocrengine.md) class, the method returns an [OcrResult](ocrresult.md) object. The **OcrResult** contains a collection of **OcrLine** objects, which you access through the [Lines](ocrresult_lines.md) property of the **OcrResult**. Each **OcrLine** object contains a collection of [OcrWord](ocrword.md) objects, which you access through the [Words](ocrline_words.md) property of each **OcrLine**.

## -examples

## -see-also
