---
-api-id: T:Windows.Devices.Power.Battery
-api-type: winrt class
---

<!-- Class syntax.
public class Battery : Windows.Devices.Power.IBattery
-->

# Windows.Devices.Power.Battery

## -description
Provides information about a battery controller that is currently connected to the device. For more info, see [Get battery information](https://msdn.microsoft.com/library/a9fb0f39-8827-420a-922d-dcee6fb9c9d2).

## -remarks
In this context, *device* refers to the hardware that your app is running on. *Battery controller* refers to the electronics that interface between the physical battery and the operating system. A battery controller appears in Device Manager as a "Battery" under the **Batteries** node.

Depending on the device, it may be possible to remove the physical battery while the device remains running. For example, a laptop that's plugged into A/C power. In that case, if the battery controller were part of the laptop enclosure, you could potentially create a [Battery](battery.md) object when no battery is connected to the device. However, if the battery controller resided on the physical battery, it would no longer be visible to the operating system and therefore you could not create a corresponding [Battery](battery.md) object for an individual battery.

## -examples

## -see-also
[Get battery information](https://msdn.microsoft.com/library/a9fb0f39-8827-420a-922d-dcee6fb9c9d2)
