---
-api-id: T:Windows.Devices.Input.PointerDeviceUsage
-api-type: winrt struct
---

<!-- Structure syntax.
public struct PointerDeviceUsage 
-->

# PointerDeviceUsage

## -description
Identifies the Human Interface Device (HID) usage details for the input device.

A Human Interface Device (HID) usage describes what a Human Interface Device (HID)-compliant control is measuring or reporting and can also indicate the control's intended use. A specific control usage is defined by its usage page, a usage ID, a name, and a description.

## -struct-fields

### -field UsagePage
The Human Interface Device (HID) usage page of the pointer device. Human Interface Device (HID) usages are organized into usage pages that specify classes of related devices. For example, touch digitizers (0x0D) and generic input (0x01).
    

### -field Usage
The Human Interface Device (HID) pointer device usage ID that specifies a device or property in the **UsagePage**. For example, 0x04 indicates a touch screen device and 0x47 indicates touch confidence.

> [!NOTE]
> A usage ID of zero is reserved.
    

### -field MinLogical
The minimum logical value for **Usage**.
    

### -field MaxLogical
The maximum logical value for **Usage**.
    

### -field MinPhysical
The minimum physical value for **Usage**.
    

### -field MaxPhysical
The maximum physical value for **Usage**.
    

### -field Unit
The Human Interface Device (HID) unit of measure.
    

### -field PhysicalMultiplier
The multiplier used to convert the usage value reported by the device to a physical value in units of **Unit**. (Valid only for usages that indicate a static or dynamic value associated with a control, such as pressure or width and height of the touch contact.)
    

## -remarks
A Human Interface Device (HID) usage describes what a Human Interface Device (HID)-compliant control is measuring or reporting and can also indicate the control's intended use. A specific control usage is defined by its usage page, a usage ID, a name, and a description. For more info, see [Device Class Definition for HID 1.11](https://www.usb.org/document-library/device-class-definition-hid-111).

> [!NOTE]
> The core of the Microsoft interactive input device architecture is based on the Universal Serial Bus (USB) standard Device Class Definition for Human Interface Device (HID), which is defined by the [ Implementers Forum, Inc.](https://www.usb.org/home)

The Universal Serial Bus (USB) Human Interface Device (HID) standard defines the configuration and communication protocols for Human Interface Device (HID), such as keyboards, mouse devices, joysticks, and virtual reality devices, that humans use to enter data directly into a computer. (For detailed information about the USB HID standard, see the [USB Implementers Forum](https://www.usb.org/home) website.)

Although the core of the Windows input architecture is based on the Universal Serial Bus (USB) Human Interface Device (HID) standard, the architecture is not limited to Universal Serial Bus (USB) devices. The input architecture also supports serial port devices, i8042 port devices, and proprietary input devices.

## -examples

## -see-also
