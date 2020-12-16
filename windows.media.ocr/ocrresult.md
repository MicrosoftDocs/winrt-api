---
-api-id: T:Windows.Media.Ocr.OcrResult
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class OcrResult : Windows.Media.Ocr.IOcrResult
-->

# Windows.Media.Ocr.OcrResult

## -description
Contains the results of Optical Character Recognition (OCR).

## -remarks
When you call the [RecognizeAsync](ocrengine_recognizeasync_614325911.md) method of the [OcrEngine](ocrengine.md) class, the method returns an **OcrResult** object. The **OcrResult** contains a collection of [OcrLine](ocrline.md) objects, which you access through the [Lines](ocrresult_lines.md) property of the **OcrResult**. Each **OcrLine** object contains a collection of [OcrWord](ocrword.md) objects, which you access through the [Words](ocrline_words.md) property of each **OcrLine.**

## -examples

## -see-also
[Object ](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true),