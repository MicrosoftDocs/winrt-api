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

[How to specify device capabilities for HID](https://docs.microsoft.com/uwp/schemas/appxpackage/how-to-specify-device-capabilities-for-hid), [Supporting human interface devices (HID)](https://docs.microsoft.com/previous-versions/windows/apps/dn263140(v=win.10)), [Sample Windows Runtime app for HID](https://go.microsoft.com/fwlink/p/?LinkID=391699), [Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess), [Apps for HID devices video]( http://go.microsoft.com/fwlink/p/?LinkID=317592)
