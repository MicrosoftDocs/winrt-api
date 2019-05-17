---
-api-id: P:Windows.Devices.PointOfService.ClaimedPosPrinter.Slip
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Devices.PointOfService.ClaimedSlipPrinter Slip { get; }
-->

# Windows.Devices.PointOfService.ClaimedPosPrinter.Slip

## -description
Gets an object that represents the slip station for a claimed point-of-service printer.

The slip station is used to print information on a form that is typically given to the customer, or to print validation information on a form. The form type is usually a check or credit card slip.

There is only one instance of this object per [ClaimedPosPrinter](claimedposprinter.md) instance. Additionally, this is only valid to access if [SlipPrinterCapabilities.IsPrinterPresent](slipprintercapabilities_isprinterpresent.md) indicates it is present.

## -property-value
An object that represents the slip station for a claimed point-of-service printer. Null if a slip station is not present.

## -remarks
You should check the value of the [SlipPrinterCapabilities.IsPrinterPresent](slipprintercapabilities_isprinterpresent.md) property before you try to use the ClaimedPosPrinter.Slip property.

## -examples

## -see-also
[ClaimedSlipPrinter](claimedslipprinter.md), [SlipPrinterCapabilities.IsPrinterPresent](slipprintercapabilities_isprinterpresent.md)
