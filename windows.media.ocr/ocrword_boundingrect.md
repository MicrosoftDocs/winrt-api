---
-api-id: P:Windows.Media.Ocr.OcrWord.BoundingRect
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Rect BoundingRect { get; }
-->

# Windows.Media.Ocr.OcrWord.BoundingRect

## -description
Gets the position and size in pixels of the recognized word from the top left corner of image when the value of [TextAngle](ocrresult_textangle.md) property is 0 (zero).

## -property-value
The position and size in pixels of the recognized word from the top left corner of image when the value of [TextAngle](ocrresult_textangle.md) property is 0 (zero).

## -remarks
When the value of the [TextAngle](ocrresult_textangle.md) property is not null, the values of the Left and Top properties of BoundingBox are calculated from the rotated image.

## -examples

## -see-also
