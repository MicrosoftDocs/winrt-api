---
-api-id: N:Windows.Devices.Lights
-api-type: winrt namespace
---

# Windows.Devices.Lights

## -description
Provides APIs for accessing and controlling [LampArrays](lamparray.md) and legacy [Lamp](lamp.md) devices.

## -remarks
[LampArray](lamparray.md) APIs can be used in a game or notification application to control the lights on your keyboard or mouse.

A common scenario for using the [Lamp](lamp.md) APIs in this namespace is adding a flashlight feature to your app that allows the user to manually turn on and off a device's camera torch light, if one is available.

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
