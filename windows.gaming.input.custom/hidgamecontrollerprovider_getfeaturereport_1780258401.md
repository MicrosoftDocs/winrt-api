---
-api-id: M:Windows.Gaming.Input.Custom.HidGameControllerProvider.GetFeatureReport(System.Byte,System.Byte[])
-api-type: winrt method
---

<!-- Method syntax.
public void HidGameControllerProvider.GetFeatureReport(Byte reportId, Byte[] reportBuffer)
-->

# Windows.Gaming.Input.Custom.HidGameControllerProvider.GetFeatureReport

## -description

Gets the specified HID (Human Interface Device) feature report from the controller.

## -parameters

### -param reportId

The ID of the report to get.

### -param reportBuffer

The buffer in which to put the report. TODO: True?

## -remarks

The report that you get from this function is the raw, unmodified version in its original format; no parsing is done on it.

## -see-also

## -examples

