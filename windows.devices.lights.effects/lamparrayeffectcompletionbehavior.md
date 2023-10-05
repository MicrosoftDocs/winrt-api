---
-api-id: T:Windows.Devices.Lights.Effects.LampArrayEffectCompletionBehavior
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum LampArrayEffectCompletionBehavior : int 
-->

# Windows.Devices.Lights.Effects.LampArrayEffectCompletionBehavior

## -description

Behavior when an effect completes.

## -enum-fields

### -field ClearState:0

Clears the state of all lamps when effect completes for the start of the next effect in the playlist. This is the typical case for most effects.

### -field KeepState:1

Maintains the state of all lamps when effect completes, so state is preserved for start of the next effect in the playlist. Use to seamlessly connect effects when the end state is known.

## -remarks

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

[LampArrayColorRampEffect.CompletionBehavior](lamparraycolorrampeffect_completionbehavior.md), [LampArraySolidEffect.CompletionBehavior](lamparraysolideffect_completionbehavior.md), [Lighting and Illumination (www.usb.org)](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf), [Dynamic lighting](/windows/uwp/devices-sensors/lighting-dynamic-lamparray)

