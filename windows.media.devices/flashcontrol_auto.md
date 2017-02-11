---
-api-id: P:Windows.Media.Devices.FlashControl.Auto
-api-type: winrt property
---

<!-- Property syntax
public bool Auto { get;  set; }
-->

# Windows.Media.Devices.FlashControl.Auto

## -description
Gets or sets a value that specifies if flash is automatically set.

## -property-value
**true** if auto flash is set; otherwise, **false**.

## -remarks
You should check the value of the [FlashControl](flashcontrol.md) object's [Supported](flashcontrol_supported.md) property before attempting to access this property. If [Supported](flashcontrol_supported.md) is false, attempting to access this property will throw an exception.

## -examples

## -see-also
