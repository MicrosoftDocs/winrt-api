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

The buffer in which the report data is returned.

## -remarks

When using this method for your own custom classes, make sure to pass in a valid report ID that is supported by your device; otherwise, the report buffer will be unchanged. Also make sure that your report buffer is the correct size for the type of report that you're requesting.

The report that you get from this method is the raw, unmodified version in its original format; no parsing is done on it.

## -see-also

## -examples

