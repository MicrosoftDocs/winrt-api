---
-api-id: M:Windows.Devices.PointOfService.ReceiptPrintJob.CutPaper(System.Double)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void CutPaper(System.Double percentage)
-->

# Windows.Devices.PointOfService.ReceiptPrintJob.CutPaper

## -description
Adds an instruction to the printer job to cut the specified percentage of the receipt paper.

## -parameters
### -param percentage
Decimal representation of the percentage of the receipt that the receipt printer should cut.

Many printers with paper cutting capability can perform both full and partial cuts. Some offer gradations of partial cuts, such as a perforated cut and an almost-full cut. Use the following general guidelines:

<table>
   <tr><th>Value</th><th>Meaning</th></tr>
   <tr><td>1.0</td><td>Fully cuts the paper.</td></tr>
   <tr><td>0.9</td><td>Leaves only a small part of paper for very easy final separation.</td></tr>
   <tr><td>0.7</td><td>Perforates the paper for final separation that is somewhat more difficult and unlikely to occur by accidental handling.</td></tr>
   <tr><td>0.5</td><td>Partial perforation of the paper.</td></tr>
</table>

Printer capabilities vary, so the actual result can be device-dependent.

## -remarks

## -examples

## -see-also
[CutPaper()](receiptprintjob_cutpaper_1725234121.md)