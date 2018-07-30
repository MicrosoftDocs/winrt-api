---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidFeatureReport.GetBooleanControl(System.UInt16,System.UInt16)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Devices.HumanInterfaceDevice.HidBooleanControl GetBooleanControl(System.UInt16 usagePage, System.UInt16 usageId)
-->

# Windows.Devices.HumanInterfaceDevice.HidFeatureReport.GetBooleanControl

## -description

Retrieves the Boolean control associated with the usagePage and *usageId* parameter and found in the given feature report.

## -parameters

### -param usagePage

The usage page of the top-level collection for the given HID device.

### -param usageId

The usage identifier of the top-level collection for the given HID device.

## -returns

A **HidBooleanControl** object.

## -remarks

## -examples

## -see-also

### Samples

[Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
