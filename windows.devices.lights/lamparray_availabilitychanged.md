---
-api-id: E:Windows.Devices.Lights.LampArray.AvailabilityChanged
-api-type: winrt event
---

# Windows.Devices.Lights.LampArray.AvailabilityChanged

<!--
public event Windows.Foundation.TypedEventHandler<Windows.Devices.Lights.LampArray,object> AvailabilityChanged;
-->

## -description

Is raised when the value of [IsAvailable](lamparray_isavailable.md) changes; which can happen when the user changes system access to the device through the device settings.

The event handler's parameters are the sender [LampArray](./lamparray.md) whose property has changed, and an **Object** (which is always null).

## -remarks

Both foreground and background ("ambient") apps can receive and handle this event.

To use this event, you must declare the "com.microsoft.windows.lighting" AppExtension in the app manifest. For details about how to do that, see [Create and host an app extension](/windows/uwp/launch-resume/how-to-create-an-extension).

```xml
<Extensions>
    <uap3:Extension Category="windows.appExtension">
        <uap3:AppExtension Name="com.microsoft.windows.lighting" Id="Id" DisplayName="Id">
        </uap3:AppExtension> 
    </uap3:Extension>
</Extensions>
```

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

[IsAvailable](lamparray_isavailable.md), [Lighting and Illumination (www.usb.org)](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf), [Dynamic lighting](/windows/uwp/devices-sensors/lighting-dynamic-lamparray)
