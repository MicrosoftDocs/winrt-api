---
-api-id: P:Windows.Gaming.Input.RawGameController.DisplayName
-api-type: winrt property
---

<!-- Property syntax.
public string DisplayName { get; }
-->

# Windows.Gaming.Input.RawGameController.DisplayName

## -description

The name of the controller, provided by the hardware.

## -property-value

The name of the controller, provided by the hardware.

## -remarks

This is meant to be a string that's suitable for display in an application's user interface&mdash;for example, showing the user a list of input devices from which to choose. However, this string isn't guaranteed to be localized. If you need to be sure that you get the correct name for each locale, you can keep your own string table for devices by [RawGameController.HardwareProductId](rawgamecontroller_hardwareproductid.md) and [RawGameController.HardwareVendorId](rawgamecontroller_hardwarevendorid.md).

## -see-also

## -examples
