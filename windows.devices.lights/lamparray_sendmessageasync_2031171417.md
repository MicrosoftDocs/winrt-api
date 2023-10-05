---
-api-id: M:Windows.Devices.Lights.LampArray.SendMessageAsync(System.Int32,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncAction LampArray.SendMessageAsync(Int32 messageId, IBuffer message)
-->

# Windows.Devices.Lights.LampArray.SendMessageAsync

## -description

Asynchronously sends a message identified by the message identifer argument.

## -parameters

### -param messageId

The identifer of a message.

### -param message

An [IBuffer](/uwp/api/windows.storage.streams.ibuffer) representing the message.

## -returns

An asynchronous object, which can be awaited.

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

[Lighting and Illumination (www.usb.org)](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf), [Dynamic lighting](/windows/uwp/devices-sensors/lighting-dynamic-lamparray)
