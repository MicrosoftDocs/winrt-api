---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayBitmapRequestedEventArgs.UpdateBitmap(Windows.Graphics.Imaging.SoftwareBitmap)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArrayBitmapRequestedEventArgs.UpdateBitmap(SoftwareBitmap bitmap)
-->

# Windows.Devices.Lights.Effects.LampArrayBitmapRequestedEventArgs.UpdateBitmap

## -description
Sets previously specified lamp/s indexes according to the caller defined image.

## -parameters
### -param bitmap
The image form which to update the lamp/s.  If `null`, all lamps are to set off/[Black](../windows.ui/colors_black.md)

## -remarks
Images supplied that are not of the [SuggestedBitmapSize](lamparraybitmapeffect_suggestedbitmapsize.md) will incur a small performance penalty when resizing internally.
## -see-also

## -examples

