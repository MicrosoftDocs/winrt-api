---
-api-id: T:Windows.System.Power.BatteryStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.Power.BatteryStatus : int
-->

# BatteryStatus

## -description
Indicates the status of the battery.

## -enum-fields
### -field NotPresent:0
The battery or battery controller is not present.

### -field Discharging:1
The battery is discharging.

### -field Idle:2
The battery is idle.

### -field Charging:3
The battery is charging.


## -remarks
This enumeration is used as part of the [BatteryReport](../windows.devices.power/batteryreport.md) class to provide information about a [Battery](../windows.devices.power/battery.md) object.

If the battery controller is removed after you create a [Battery](../windows.devices.power/battery.md) object, the [Status](../windows.devices.power/batteryreport_status.md) will be **NotPresent**.

An **Idle** status occurs when the charge rate is zero. The battery isn’t charging, but it is maintaining its current level of charge.

## -examples

## -see-also