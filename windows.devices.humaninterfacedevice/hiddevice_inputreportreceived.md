---
-api-id: E:Windows.Devices.HumanInterfaceDevice.HidDevice.InputReportReceived
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler InputReportReceived<Windows.Devices.HumanInterfaceDevice.HidDevice,  Windows.Devices.HumanInterfaceDevice.HidInputReportReceivedEventArgs>
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.InputReportReceived

## -description
Establishes an event listener which handles input reports issued by the device.

## -remarks
This method waits for the device to interrupt the host when it has data to send. Internally, the HID WinRT API sends a IOCTL read request to a lower driver in the stack.

The IOCTL is translated by the HID minidriver into a protocol-specific request. For a USB device, the minidriver translates this into an INTERRUPT IN request. And, for an I2C device that is running over the Microsoft HID-I2C miniport driver, the minidriver will wait for the device to assert an interrupt.

## -examples

## -see-also
