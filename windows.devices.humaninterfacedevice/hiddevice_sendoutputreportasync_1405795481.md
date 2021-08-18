---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidDevice.SendOutputReportAsync(Windows.Devices.HumanInterfaceDevice.HidOutputReport)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<uint> SendOutputReportAsync(Windows.Devices.HumanInterfaceDevice.HidOutputReport outputReport)
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.SendOutputReportAsync

## -description

Sends an output report asynchronously from the host to the device.

## -parameters

### -param outputReport

The output report which the host sends to the device.

## -returns

Specifies the count of bytes written to the device.

## -exceptions
### T:System.UnauthorizedAccessException

This device does not have permission to send an output report. To send this report, the device must be opened with [FileAccessMode.ReadWrite](../windows.storage/fileaccessmode.md).

## -remarks
The device must be opened with [FileAccessMode.ReadWrite](../windows.storage/fileaccessmode.md).

## -examples

## -see-also

[Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
