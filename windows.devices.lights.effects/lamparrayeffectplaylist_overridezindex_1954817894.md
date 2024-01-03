---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.OverrideZIndex(System.Int32)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArrayEffectPlaylist.OverrideZIndex(Int32 zIndex)
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.OverrideZIndex

## -description
Overrides the zIndex for all contained effects.

## -parameters
### -param zIndex
The overriding zIndex.

## -remarks
Effects added after OverrideZIndex is called will still be overridden.

After the playlist has started, all zIndexes are locked and it's not possible to override further.

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


