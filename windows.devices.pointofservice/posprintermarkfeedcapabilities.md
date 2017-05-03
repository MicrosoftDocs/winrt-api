---
-api-id: T:Windows.Devices.PointOfService.PosPrinterMarkFeedCapabilities
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.PointOfService.PosPrinterMarkFeedCapabilities : uint
-->

# PosPrinterMarkFeedCapabilities

## -description
Describes the capabilities of a receipt printer station for handling mark-sensed paper.

## -enum-fields
### -field None:0
The receipt printer station cannot feed the mark-sensed paper.

### -field ToTakeUp:1
The receipt printer station can feed the mark-sensed paper to the paper take-up position.

### -field ToCutter:2
The receipt printer station can feed the mark-sensed paper to the cutting position for the automatic cutter.

### -field ToCurrentTopOfForm:4
The receipt printer station can feed the mark-sensed paper to the top of the form for the present paper, reverse feeding the paper if required.

### -field ToNextTopOfForm:8
The receipt printer station can feed the mark-sensed paper to the top of the form for the next paper.


## -remarks

## -examples

## -see-also
[ReceiptPrinterCapabilities.MarkFeedCapabilities](receiptprintercapabilities_markfeedcapabilities.md), [ReceiptPrintJob.MarkFeed](receiptprintjob_markfeed.md), [PosPrinterMarkFeedKind](posprintermarkfeedkind.md)