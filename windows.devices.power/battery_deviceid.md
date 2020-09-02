---
-api-id: P:Windows.Devices.Power.Battery.DeviceId
-api-type: winrt property
---

<!-- Property syntax
public string DeviceId { get; }
-->

# Windows.Devices.Power.Battery.DeviceId

## -description
Gets the identifier (ID) for an individual battery controller.

## -property-value
The battery controller identifier (ID).

## -remarks
When the [Battery](battery.md) object represents an individual battery controller, this property value can be used with the [FromIdAsync](battery_fromidasync_1322863552.md) method to re-create an object that represents the same battery controller (if it's still connected to the device). When the Battery object is an aggregate of battery controllers, this property is equal to "`AggregateBattery` ".

## -examples

## -see-also
[Get battery information](/previous-versions/windows/apps/dn895210(v=win.10))
