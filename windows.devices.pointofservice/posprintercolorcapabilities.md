---
-api-id: T:Windows.Devices.PointOfService.PosPrinterColorCapabilities
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.PointOfService.PosPrinterColorCapabilities : uint
-->

# PosPrinterColorCapabilities

## -description
Describes the possible color cartridges that a point-of-service printer can support.

## -enum-fields
### -field None:0
Supports no color cartridges.

### -field Primary:1
Supports a primary color cartridge.

### -field Custom1:2
Supports a first custom color cartridge, which provides a secondary color, usually red.

### -field Custom2:4
Supports a second custom color cartridge.

### -field Custom3:8
Supports a third custom color cartridge.

### -field Custom4:16
Supports a fourth custom color cartridge.

### -field Custom5:32
Supports a fifth custom color cartridge.

### -field Custom6:64
Supports a sixth custom color cartridge.

### -field Cyan:128
Supports a cyan cartridge for full color printing.

### -field Magenta:256
Supports a magenta cartridge for full color printing.

### -field Yellow:512
Supports a yellow cartridge for full color printing.

### -field Full:1024
Supports full color printing.


## -remarks

## -examples

## -see-also
[JournalPrinterCapabilities.ColorCartridgeCapabilities](journalprintercapabilities_colorcartridgecapabilities.md), [ReceiptPrinterCapabilities.ColorCartridgeCapabilities](receiptprintercapabilities_colorcartridgecapabilities.md), [SlipPrinterCapabilities.ColorCartridgeCapabilities](slipprintercapabilities_colorcartridgecapabilities.md), [ICommonPosPrintStationCapabilities.ColorCartridgeCapabilities](icommonposprintstationcapabilities_colorcartridgecapabilities.md), [ReceiptPrintJob.DrawRuledLine](receiptprintjob_drawruledline_1309666666.md), [SlipPrintJob.DrawRuledLine](slipprintjob_drawruledline_1309666666.md), [IReceiptOrSlipJob.DrawRuledLine](ireceiptorslipjob_drawruledline_1309666666.md)