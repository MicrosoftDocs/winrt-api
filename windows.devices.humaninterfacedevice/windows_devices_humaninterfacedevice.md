---
-api-id: N:Windows.Devices.HumanInterfaceDevice
-api-type: winrt namespace
---

# Windows.Devices.HumanInterfaceDevice

## -description
This namespace gives your Windows Store app access to devices that support the Human Interface Device (HID) protocol.

For an introduction to the HID API, see [Supporting human interface devices (HID)](http://msdn.microsoft.com/library/469bc2b7-ac21-40ed-a515-bace31e22634).

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
+ HID_USAGE_PAGE_BARCODE_SCANNER
+ HID_USAGE_PAGE_WEIGHING_DEVICE
+ HID_USAGE_PAGE_MAGNETIC_STRIPE_READER
+ HID_USAGE_PAGE_TELEPHONY


## -remarks

## -examples

## -see-also
[Apps for HID devices]( http://go.microsoft.com/fwlink/p/?LinkID=317592), [How to specify device capabilities for HID](http://msdn.microsoft.com/library/4c5c4ab6-e1d1-4631-ab8e-f0c33af8b464), [Sample Windows Runtime app for HID](http://go.microsoft.com/fwlink/p/?LinkID=391699), [Supporting human interface devices (HID)](http://msdn.microsoft.com/library/469bc2b7-ac21-40ed-a515-bace31e22634), [Custom HID device sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620527)