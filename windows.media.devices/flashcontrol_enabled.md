---
-api-id: P:Windows.Media.Devices.FlashControl.Enabled
-api-type: winrt property
---

<!-- Property syntax
public bool Enabled { get;  set; }
-->

# Windows.Media.Devices.FlashControl.Enabled

## -description
Gets a value that specifies if the flash on the capture device is enabled or disabled.

## -property-value
**true** if the flash is enabled; otherwise, **false**.

## -remarks
You should check the value of the [FlashControl](flashcontrol.md) object's [Supported](flashcontrol_supported.md) property before attempting to access this property. If [Supported](flashcontrol_supported.md) is false, attempting to access this property will throw an exception.

## -examples

## -see-also
