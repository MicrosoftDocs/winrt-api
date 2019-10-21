---
-api-id: P:Windows.Devices.PointOfService.ClaimedPosPrinter.Receipt
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Devices.PointOfService.ClaimedReceiptPrinter Receipt { get; }
-->

# Windows.Devices.PointOfService.ClaimedPosPrinter.Receipt

## -description
Gets an object that represents the receipt station for a claimed point-of-service printer.

The receipt station is used to print transaction information that is typically given to the customer, or for store reports. The receipt station contains either a knife to automatically cut the paper between transactions, or a tear bar to manually cut the paper.

There is only one instance of this object per [ClaimedPosPrinter](claimedposprinter.md) instance. Additionally, this is only valid to access if [ReceiptPrinterCapabilities.IsPrinterPresent](receiptprintercapabilities_isprinterpresent.md) indicates it is present.

## -property-value
An object that represents the receipt station for a claimed point-of-service printer. Null if a receipt station is not present.

## -remarks
You should check the value of the [ReceiptPrinterCapabilities.IsPrinterPresent](receiptprintercapabilities_isprinterpresent.md) property before you try to use the ClaimedPosPrinter.Receipt property.

## -examples

## -see-also
[ClaimedReceiptPrinter](claimedreceiptprinter.md), [ReceiptPrinterCapabilities.IsPrinterPresent](receiptprintercapabilities_isprinterpresent.md)
