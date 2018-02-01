---
-api-id: P:Windows.Media.Capture.CapturedFrame.ControlValues
-api-type: winrt property
---

<!-- Property syntax.
public CapturedFrameControlValues ControlValues { get; }
-->

# Windows.Media.Capture.CapturedFrame.ControlValues

## -description
Gets an object containing capture control metadata for the [CapturedFrame](capturedframe.md). Capture controls adjust capture settings such as ISO and exposure.

## -property-value
An object containing capture control metadata for the [CapturedFrame](capturedframe.md).

## -remarks
This property is useful for apps that want to capture frames in an uncompressed format and then base further processing on the control values with which the frame was captured. When capturing to a compressed format, the control values automatically encoded into the image file.

## -see-also

## -examples

