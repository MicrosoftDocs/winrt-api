---
-api-id: N:Windows.Devices.HumanInterfaceDevice
-api-type: winrt namespace
---

# Windows.Devices.HumanInterfaceDevice

## -description

This namespace gives your UWP app access to devices that support the Human Interface Device (HID) protocol.

For an introduction to the HID API, see [Supporting human interface devices (HID)](https://docs.microsoft.com/previous-versions/windows/apps/dn263140(v=win.10)).

This namespace supports most HID devices. However, it blocks the top-level application collection represented by the following usage pages:


+ HID_USAGE_PAGE_UNDEFINED
+ HID_USAGE_PAGE_GENERIC
+ HID_USAGE_GENERIC_KEYBOARD
+ HID_USAGE_GENERIC_KEYPAD
+ HID_USAGE_GENERIC_SYSTEM_CTL
+ HID_USAGE_PAGE_KEYBOARD
+ HID_USAGE_PAGE_CONSUMER
+ HID_USAGE_PAGE_DIGITIZER
+ HID_USAGE_PAGE_SENSOR
+ HID_USAGE_PAGE_TELEPHONY

## -remarks

## -examples

## -see-also

[How to specify device capabilities for HID](https://docs.microsoft.com/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-hid), [Supporting human interface devices (HID)](https://docs.microsoft.com/previous-versions/windows/apps/dn263140(v=win.10)), [Custom HID device sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/CustomHidDeviceAccess)
