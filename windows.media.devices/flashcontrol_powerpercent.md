---
-api-id: P:Windows.Media.Devices.FlashControl.PowerPercent
-api-type: winrt property
---

<!-- Property syntax
public float PowerPercent { get;  set; }
-->

# Windows.Media.Devices.FlashControl.PowerPercent

## -description
Gets or sets the intensity of the flash.

## -property-value
The power percent the torch LED is set to.

## -remarks
You should check the value of the [FlashControl](flashcontrol.md) object's [PowerSupported](flashcontrol_powersupported.md) property before attempting to access this property. If [PowerSupported](flashcontrol_powersupported.md) is false, attempting to access this property will throw an exception.

## -examples

## -see-also
