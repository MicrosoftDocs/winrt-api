---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidDevice.GetBooleanControlDescriptions(Windows.Devices.HumanInterfaceDevice.HidReportType,System.UInt16,System.UInt16)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Devices.HumanInterfaceDevice.HidBooleanControlDescription> GetBooleanControlDescriptions(Windows.Devices.HumanInterfaceDevice.HidReportType reportType, System.UInt16 usagePage, System.UInt16 usageId)
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.GetBooleanControlDescriptions

## -description
Retrieves the descriptions of the boolean controls for the given HID device.

## -parameters
### -param reportType
Specifies the type of report for which the control descriptions are requested.

### -param usagePage
Identifies the usage page associated with the controls.

### -param usageId
Identifies the usage associated with the controls.

## -returns
A vector of **HidBooleanControlDescription** objects.

## -remarks
Boolean controls are simple controls that return On/Off values. (They are sometimes referred to as button controls.)

## -examples

## -see-also
