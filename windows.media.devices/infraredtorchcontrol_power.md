---
-api-id: P:Windows.Media.Devices.InfraredTorchControl.Power
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public int Power { get;  set; }
-->

# Windows.Media.Devices.InfraredTorchControl.Power

## -description
Gets or sets the current infrared LED power value.

## -property-value
The power value the infrared LED is set to.

## -remarks
The power value shall satisfy this condition: **[MinPower](infraredtorchcontrol_minpower.md) ≤ [Power Value ≤ [MaxPower](infraredtorchcontrol_maxpower.md)** where **([Power Value - [Min](infraredtorchcontrol_minpower.md)) mod [PowerStep](infraredtorchcontrol_powerstep.md) = 0**.

E.g., if [PowerStep](infraredtorchcontrol_powerstep.md) is 5 and current [Power Value is 50 accepted new values are in 5 increment or decrement as long they are in valid range determined by [MinPower](infraredtorchcontrol_minpower.md) and [MaxPower](infraredtorchcontrol_maxpower.md).

## -see-also

[InfraredTorchControl.MinPower](infraredtorchcontrol_minpower.md), [InfraredTorchControl.MaxPower](infraredtorchcontrol_maxpower.md), [InfraredTorchControl.PowerStep](infraredtorchcontrol_powerstep.md)

## -examples

