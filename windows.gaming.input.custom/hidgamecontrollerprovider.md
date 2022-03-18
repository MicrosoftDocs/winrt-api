---
-api-id: T:Windows.Gaming.Input.Custom.HidGameControllerProvider
-api-type: winrt class
---

<!-- Class syntax.
public class HidGameControllerProvider : IGameControllerProvider
-->

# Windows.Gaming.Input.Custom.HidGameControllerProvider

## -description

Represents the underlying device for a HID (Human Interface Device) game controller.

## -remarks

This class provides functions for sending raw HID output reports, as well as reading and writing raw HID feature reports. These reports are in their original format&mdash;no parsing is done on them.

This class also exposes the HID page and usage of the TLC (top-level collection), so that you can interface correctly with each supported TLC.

## -see-also

[IGameControllerProvider](igamecontrollerprovider.md)

## -examples

