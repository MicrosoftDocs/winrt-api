---
-api-id: P:Windows.Media.Ocr.OcrResult.TextAngle
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<double> TextAngle { get; }
-->

# Windows.Media.Ocr.OcrResult.TextAngle

## -description
Gets the clockwise rotation of the recognized text, in degrees, around the center of the image.

## -property-value
The clockwise rotation of the recognized text, in degrees, around the center of the image. If the angle of the text can't be detected, the value of this property is **null**. If the image contains text at different angles, only part of the text will be recognized correctly.

## -remarks
Use the **TextAngle** property to overlay recognition results correctly on the original image. If the value of the **TextAngle** property is not null or 0 (zero), then to overlay the recognized text correctly on the original image, you either have to rotate the original image by the detected angle in a counter-clockwise direction, or rotate the recognized text by the detected angle in a clockwise direction.

<img src="images/OcrTextAngle.png" alt="Example of text angle in an image" />

## -examples

## -see-also
