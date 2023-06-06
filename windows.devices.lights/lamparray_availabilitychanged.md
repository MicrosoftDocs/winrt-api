---
-api-id: E:Windows.Devices.Lights.LampArray.AvailabilityChanged
-api-type: winrt event
---

# Windows.Devices.Lights.LampArray.AvailabilityChanged

<!--
public event Windows.Foundation.TypedEventHandler<Windows.Devices.Lights.LampArray,object> AvailabilityChanged;
-->

## -description

Occurs when user changes system access to the device lights through the device settings.

## -remarks

Both foreground and background ("ambient") apps can receive and handle this event.

To use this event, you must declare the "com.microsoft.windows.lighting" AppExtension in the app manifest. For more detail on how to do this, see [Create and host an app extension](/windows/uwp/launch-resume/how-to-create-an-extension).

```xml
<Extensions>
    <uap3:Extension Category="windows.appExtension">
        <uap3:AppExtension Name="com.microsoft.windows.lighting" Id="Id" DisplayName="Id">
        </uap3:AppExtension> 
    </uap3:Extension>
</Extensions>
```

## -see-also

[IsAvailable](lamparray_isavailable.md), [Dynamic lighting](/windows/uwp/devices-sensors/lighting-dynamic-lamparray)

## -examples
