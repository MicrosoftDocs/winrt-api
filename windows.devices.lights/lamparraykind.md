---
-api-id: T:Windows.Devices.Lights.LampArrayKind
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum LampArrayKind : int 
-->

# Windows.Devices.Lights.LampArrayKind

## -description

The type of physical device the LampArray is part of.

## -enum-fields

### -field Undefined:0

No Kind specified for this device.

### -field Keyboard:1

Is part of a keyboard or keypad.

### -field Mouse:2

Is part of a mouse.

### -field GameController:3

Is part of a game controller (for example, gamepad, flightstick, sailing simulation device).

### -field Peripheral:4

Is part of a more general peripheral/accessory (for example, speakers, mousepad, microphone, webcam).

### -field Scene:5

Illuminates a room/performance-stage/area (for example, room light-bulbs, spotlights, washlights, strobelights, booth-strips, billboard/sign, camera-flash).

### -field Notification:6

Is part of a notification device.

### -field Chassis:7

Is part of an internal PC case component (for example, RAM-stick, motherboard, fan).

### -field Wearable:8

Is embedded in a wearable accessory (for example, audio-headset, wristband, watch, shoes).

### -field Furniture:9

Is embedded in a piece of furniture (for example, chair, desk, bookcase).

### -field Art:10

Is embedded in an artwork (for example, painting or sculpture).

### -field Headset: 11

Is embedded in a wearable accessory designed specifically for the head (for example, headphones or microphones). This is a specialization of *Wearable*.

## -remarks

Avoid placing error checks that validate **LampArrayKind** within the current bounds, because this list might expand over time. Rather, compare against the subset of **LampArrayKind** that your application supports.

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

[LampArray.LampArrayKind](lamparray_lamparraykind.md), [Lighting and Illumination (www.usb.org)](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf), [Dynamic lighting](/windows/uwp/devices-sensors/lighting-dynamic-lamparray)
