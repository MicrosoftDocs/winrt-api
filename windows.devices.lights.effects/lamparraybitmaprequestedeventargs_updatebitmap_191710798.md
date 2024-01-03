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
## -examples

:::row:::
    :::column:::

        [LampArray sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/LampArray)
        
        Demonstrates how to control RGB lighting of peripheral devices using the [**Windows.Devices.Lights**](/uwp/api/windows.devices.lights) and [**Windows.Devices.Lights.Effects**](/uwp/api/windows.devices.lights.effects) APIs.

    :::column-end:::
    :::column:::

        [AutoRGB Sample](https://github.com/microsoft/Dynamic-Lighting-AutoRGB)
        
        Demonstrates how to extract a single, representative color from a desktop screen and use it to illuminate LED lamps on a connected RGB device.
            
    :::column-end:::
:::row-end:::

## -see-also

[Lighting and Illumination (www.usb.org)](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf), [Dynamic lighting](/windows/uwp/devices-sensors/lighting-dynamic-lamparray)


