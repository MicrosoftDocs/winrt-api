---
-api-id: M:Windows.Gaming.Input.Custom.HidGameControllerProvider.SendFeatureReport(System.Byte,System.Byte[])
-api-type: winrt method
---

<!-- Method syntax.
public void HidGameControllerProvider.SendFeatureReport(Byte reportId, Byte[] reportBuffer)
-->

# Windows.Gaming.Input.Custom.HidGameControllerProvider.SendFeatureReport

## -description

Sends the specified HID (Human Interface Device) feature report from the host to the device. TODO: What's the host?

## -parameters

### -param reportId

The ID of the report to send.

### -param reportBuffer

The buffer in which to put the report. TODO: True?

## -remarks

The report that you send from this function is the raw, unmodified version in its original format; no parsing is done on it.

## -see-also

## -examples

