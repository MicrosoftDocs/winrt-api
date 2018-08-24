---
-api-id: T:Windows.Devices.PointOfService.PosPrinterLineStyle
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.PointOfService.PosPrinterLineStyle : int
-->

# PosPrinterLineStyle

## -description
Describes the line styles that a receipt or slip printer station can use to print a ruled line.

## -enum-fields
### -field SingleSolid:0
Prints a continuous solid line.

### -field DoubleSolid:1
Prints a continuous solid line of double the normal thickness.

### -field Broken:2
Prints a sequence of short lines separated by spaces.

### -field Chain:3
Prints a sequence of short lines separated by a space, then followed by a very short line, followed by a space, then followed by a short line again.


## -remarks

## -examples

## -see-also
[ReceiptPrintJob.DrawRuledLine](receiptprintjob_drawruledline_1309666666.md), [SlipPrintJob.DrawRuledLine](slipprintjob_drawruledline_1309666666.md), [IReceiptOrSlipJob.DrawRuledLine](ireceiptorslipjob_drawruledline_1309666666.md)