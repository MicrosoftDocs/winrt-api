---
-api-id: P:Windows.Media.Devices.FlashControl.PowerSupported
-api-type: winrt property
---

<!-- Property syntax
public bool PowerSupported { get; }
-->

# Windows.Media.Devices.FlashControl.PowerSupported

## -description
Gets a value that specifics if the device allows the torch LED power settings to be changed.

## -property-value
**true** if the device allows the torch LED power settings to be changed; otherwise, **false**.

## -remarks
You should check the value of the [FlashControl](flashcontrol.md) object's [Supported](flashcontrol_supported.md) property before attempting to access this property. If [Supported](flashcontrol_supported.md) is false, attempting to access this property will throw an exception.

## -examples

## -see-also
