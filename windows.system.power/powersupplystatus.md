---
-api-id: T:Windows.System.Power.PowerSupplyStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.Power.PowerSupplyStatus : int
-->

# PowerSupplyStatus

## -description
Represents the device's power supply status.

## -enum-fields
### -field NotPresent:0
The device has no power supply.

### -field Inadequate:1
The device has an inadequate power supply.

### -field Adequate:2
The device has an adequate power supply.


## -remarks
An **Inadequate** status occurs when the power supply is present, but the charge rate is negative. For example, the device is plugged in, but it’s losing charge.

## -examples

## -see-also