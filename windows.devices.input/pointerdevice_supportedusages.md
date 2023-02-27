---
-api-id: P:Windows.Devices.Input.PointerDevice.SupportedUsages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Devices.Input.PointerDeviceUsage> SupportedUsages { get; }
-->

# Windows.Devices.Input.PointerDevice.SupportedUsages

## -description
Gets a collection containing the supported [pointer device usages](pointerdeviceusage.md).

## -property-value
A collection containing the supported pointer device usages.

## -remarks
A Human Interface Device (HID) usage describes what a Human Interface Device (HID)-compliant control is measuring or reporting and can also indicate the control's intended use. A specific control usage is defined by its usage page, a usage ID, a name, and a description. For more info, see [Device Class Definition for HID 1.11](https://www.usb.org/document-library/device-class-definition-hid-111).

> [!NOTE]
> The core of the Microsoft interactive input device architecture is based on the Universal Serial Bus (USB) standard Device Class Definition for Human Interface Device (HID), which is defined by the [ Implementers Forum, Inc.](https://www.usb.org/home)

The Universal Serial Bus (USB) Human Interface Device (HID) standard defines the configuration and communication protocols for Human Interface Device (HID), such as keyboards, mouse devices, joysticks, and virtual reality devices, that humans use to enter data directly into a computer. (For detailed information about the USB HID standard, see the [USB Implementers Forum](https://www.usb.org/home) website.)

Although the core of the Windows input architecture is based on the Universal Serial Bus (USB) Human Interface Device (HID) standard, the architecture is not limited to Universal Serial Bus (USB) devices. The input architecture also supports serial port devices, i8042 port devices, and proprietary input devices.

## -examples

## -see-also
[PointerDeviceUsage](pointerdeviceusage.md), [Quickstart: Identifying input devices](/windows/uwp/design/input/identify-input-devices)
