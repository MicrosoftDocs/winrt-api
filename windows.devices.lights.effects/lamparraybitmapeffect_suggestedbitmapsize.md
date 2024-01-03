---
-api-id: P:Windows.Devices.Lights.Effects.LampArrayBitmapEffect.SuggestedBitmapSize
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public Size SuggestedBitmapSize { get; }
-->

# Windows.Devices.Lights.Effects.LampArrayBitmapEffect.SuggestedBitmapSize

## -description
Gets the most suitable image size for the caller selected lamp indexes that results in minimal scaling/distortion.
## -property-value
The image size.
## -remarks
Images supplied to [UpdateBitmap](lamparraybitmaprequestedeventargs_updatebitmap_191710798.md) that are not of the suggested size will incur a small performance penalty when resizing internally.

It is possible for this size to change between releases, as the algorithm is refined; even for the same LampArray.

Callers must NOT take a dependency that a certain size is returned for a particular LampArray.
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


