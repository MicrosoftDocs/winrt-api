---
-api-id: M:Windows.Media.Ocr.OcrEngine.TryCreateFromLanguage(Windows.Globalization.Language)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Media.Ocr.OcrEngine TryCreateFromLanguage(Windows.Globalization.Language language)
-->

# Windows.Media.Ocr.OcrEngine.TryCreateFromLanguage

## -description
Creates a new instance of the [OcrEngine](ocrengine.md) class.

## -parameters
### -param language
The language being used for text recognition.

## -returns
If the specified language can be resolved to any of the OCR languages available on the device, returns new instance of **OcrEngine** class, otherwise returns **null**. See [language matching](/previous-versions/windows/apps/jj673578(v=win.10)) for a further explanation of language resolving.

## -remarks

## -examples

## -see-also