---
-api-id: T:Windows.Devices.PointOfService.PosPrinterMarkFeedKind
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.PointOfService.PosPrinterMarkFeedKind : int
-->

# PosPrinterMarkFeedKind

## -description
Describes the ways the receipt printer station should feed the mark-sensed paper when you call the [ReceiptPrintJob.MarkFeed](receiptprintjob_markfeed.md) method.

## -enum-fields
### -field ToTakeUp:0
Feeds the mark-sensed paper to the paper take-up position.

### -field ToCutter:1
Feeds the mark-sensed paper to the cutting position for the automatic cutter.

### -field ToCurrentTopOfForm:2
Feeds the mark-sensed paper to the top of the form for the present paper, reverse feeding the paper if required.

### -field ToNextTopOfForm:3
Feeds the mark-sensed paper to the top of the form for the next paper.


## -remarks

## -examples

## -see-also
[ReceiptPrintJob.MarkFeed](receiptprintjob_markfeed.md), [PosPrinterMarkFeedCapabilities](posprintermarkfeedcapabilities.md), [ReceiptPrinterCapabilities.MarkFeedCapabilities](receiptprintercapabilities_markfeedcapabilities.md)