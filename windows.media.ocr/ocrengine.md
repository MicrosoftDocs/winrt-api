---
-api-id: T:Windows.Media.Ocr.OcrEngine
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class OcrEngine : Windows.Media.Ocr.IOcrEngine
-->

# Windows.Media.Ocr.OcrEngine

## -description
Provides optical character recognition (OCR) functionality.

## -remarks
To use the OCR capabilities of the **OcrEngine** class in your app, call the [RecognizeAsync](ocrengine_recognizeasync_614325911.md) method. When you call the **RecognizeAsync** method of the **OcrEngine** class, the method returns an [OcrResult](ocrresult.md) object, which contains the recognized text and its size and position. The result is split into lines, and the lines are split into words.


+ The [OcrResult](ocrresult.md) contains a collection of [OcrLine](ocrline.md) objects, which you access through the [Lines](ocrresult_lines.md) property of the **OcrResult**.
+ Each [OcrLine](ocrline.md) object contains a collection of [OcrWord](ocrword.md) objects, which you access through the [Words](ocrline_words.md) property of each **OcrLine**.
+ Each [OcrWord](ocrword.md) object specifies the text, size, and position information of the word in the image.


## -examples

## -see-also
