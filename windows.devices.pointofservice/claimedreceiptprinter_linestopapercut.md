---
-api-id: P:Windows.Devices.PointOfService.ClaimedReceiptPrinter.LinesToPaperCut
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public uint LinesToPaperCut { get; }
-->

# Windows.Devices.PointOfService.ClaimedReceiptPrinter.LinesToPaperCut

## -description
Gets the number of lines that must be advanced before cutting the receipt paper.

## -property-value
The number of lines that must be advanced before cutting the receipt paper.

## -remarks
Some printers position the cutting blade above the print head.
This value specifies the number of blank lines required
after the last line of a receipt
in order to advance the last printed line past the cutting blade.

## -examples

## -see-also
