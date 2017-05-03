---
-api-id: T:Windows.Devices.PointOfService.BarcodeScannerStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.PointOfService.BarcodeScannerStatus : int
-->

# BarcodeScannerStatus

## -description
Defines the constants that indicate the barcode scanner status.

## -enum-fields
### -field Online:0
The device is online. This is valid if [UnifiedPosPowerReportingType](unifiedpospowerreportingtype.md) is Standard or Advanced.

### -field Off:1
The device power is off or detached from the terminal. This is valid if [UnifiedPosPowerReportingType](unifiedpospowerreportingtype.md) is Advanced.

### -field Offline:2
The device power is on, but it is not ready or unable to respond to requests. This is valid if [UnifiedPosPowerReportingType](unifiedpospowerreportingtype.md) is Advanced.

### -field OffOrOffline:3
The device power is off or the device is offline. This is valid if [UnifiedPosPowerReportingType](unifiedpospowerreportingtype.md) is Standard.

### -field Extended:4
Vendor specific status information.


## -remarks

## -examples

## -see-also
