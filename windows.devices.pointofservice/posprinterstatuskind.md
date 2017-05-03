---
-api-id: T:Windows.Devices.PointOfService.PosPrinterStatusKind
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.PointOfService.PosPrinterStatusKind : int
-->

# PosPrinterStatusKind

## -description
Describes the power state for a point-of-service printer.

## -enum-fields
### -field Online:0
The printer is online.

This value is valid if the value of the [PosPrinterCapabilities.PowerReportingType](posprintercapabilities_powerreportingtype.md) property is **UnifiedPosPowerReportingType.Standard** or **UnifiedPosPowerReportingType.Advanced**.

### -field Off:1
The printer is turned off or disconnected from the terminal.

This value is valid if the value of the [PosPrinterCapabilities.PowerReportingType](posprintercapabilities_powerreportingtype.md) property is **UnifiedPosPowerReportingType.Advanced**.

### -field Offline:2
The printer is turned on, but it is not ready or not able to respond to requests.

This value is valid if the value of the [PosPrinterCapabilities.PowerReportingType](posprintercapabilities_powerreportingtype.md) property is **UnifiedPosPowerReportingType.Advanced**.

### -field OffOrOffline:3
The printer is either turned off, or turned on but not ready or not able to respond to requests.

This value is valid if the value of the [PosPrinterCapabilities.PowerReportingType](posprintercapabilities_powerreportingtype.md) property is **UnifiedPosPowerReportingType.Standard**.

### -field Extended:4
The original equipment manufacturer (OEM) reports extended information about the power state of the printer in the [PosPrinterStatus.ExtendedStatus](posprinterstatus_extendedstatus.md) property.


## -remarks

## -examples

## -see-also
[PosPrinterStatus.StatusKind](posprinterstatus_statuskind.md), [PosPrinterCapabilities.PowerReportingType](posprintercapabilities_powerreportingtype.md), [UnifiedPosPowerReportingType](unifiedpospowerreportingtype.md), [PosPrinterStatus.ExtendedStatus](posprinterstatus_extendedstatus.md)