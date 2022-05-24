---
-api-id: T:Windows.Devices.PointOfService.PosPrinterCartridgeSensors
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.PointOfService.PosPrinterCartridgeSensors : uint
-->

# PosPrinterCartridgeSensors

## -description
Describes the possible sensors available for a printer station of a point-of-service printer to use to report the status of the printer.

## -enum-fields
### -field None:0
The printer station does not have any sensors available to report the status of the station.

### -field Removed:1
The printer station has a sensor that detects if the cartridge is removed.

If the **CatridgeSensors** property of the capabilities object for a printer station does not contain this value, the **IsCartridgeRemoved** property of corresponding object for the claimed printer station is not valid. The following table shows the properties that are not valid when the corresponding **CartridgeSensors** property does not contain **PosPrinterCartridgeSensors.Removed**.

| Property that does not contain PosPrinterCartridgeSensors.Removed | Property that is not valid |
|---|---|
| [JournalPrinterCapabilities.CartridgeSensors](journalprintercapabilities_cartridgesensors.md) | [ClaimedJournalPrinter.IsCartridgeRemoved](claimedjournalprinter_iscartridgeremoved.md) |
| [ReceiptPrinterCapabilities.CartridgeSensors](receiptprintercapabilities_cartridgesensors.md) | [ClaimedReceiptPrinter.IsCartridgeRemoved](claimedreceiptprinter_iscartridgeremoved.md) |
| [SlipPrinterCapabilities.CartridgeSensors](slipprintercapabilities_cartridgesensors.md) | [ClaimedSlipPrinter.IsCartridgeRemoved](claimedslipprinter_iscartridgeremoved.md) |
| [ICommonPosPrintStationCapabilities.CartridgeSensors](icommonposprintstationcapabilities_cartridgesensors.md) | [ICommonClaimedPosPrinterStation.IsCartridgeRemoved](icommonclaimedposprinterstation_iscartridgeremoved.md) |

### -field Empty:2
The printer station has a sensor that detects if the cartridge is empty.

If the **CatridgeSensors** property of the capabilities object for a printer station does not contain this value, the **IsCartridgeEmpty** property of corresponding object for the claimed printer station is not valid. The following table shows the properties that are not valid when the corresponding **CartridgeSensors** property does not contain **PosPrinterCartridgeSensors.Empty**.

| Property that does not contain PosPrinterCartridgeSensors.Empty | Property that is not valid |
|---|---|
| [JournalPrinterCapabilities.CartridgeSensors](journalprintercapabilities_cartridgesensors.md) | [ClaimedJournalPrinter.IsCartridgeEmpty](claimedjournalprinter_iscartridgeempty.md) |
| [ReceiptPrinterCapabilities.CartridgeSensors](receiptprintercapabilities_cartridgesensors.md) | [ClaimedReceiptPrinter.IsCartridgeEmpty](claimedreceiptprinter_iscartridgeempty.md) |
| [SlipPrinterCapabilities.CartridgeSensors](slipprintercapabilities_cartridgesensors.md) | [ClaimedSlipPrinter.IsCartridgeEmpty](claimedslipprinter_iscartridgeempty.md) |
| [ICommonPosPrintStationCapabilities.CartridgeSensors](icommonposprintstationcapabilities_cartridgesensors.md) | [ICommonClaimedPosPrinterStation.IsCartridgeEmpty](icommonclaimedposprinterstation_iscartridgeempty.md) |

### -field HeadCleaning:4
The printer station has a sensor that detects if the head of the printer cartridge is being cleaned.

If the **CatridgeSensors** property of the capabilities object for a printer station does not contain this value, the **IsHeadCleaning** property of corresponding object for the claimed printer station is not valid. The following table shows the properties that are not valid when the corresponding **CartridgeSensors** property does not contain **PosPrinterCartridgeSensors.Head Cleaning**.

| Property that does not contain PosPrinterCartridgeSensors.Head Cleaning | Property that is not valid |
|---|---|
| [JournalPrinterCapabilities.CartridgeSensors](journalprintercapabilities_cartridgesensors.md) | [ClaimedJournalPrinter.IsHeadCleaning](claimedjournalprinter_isheadcleaning.md) |
| [ReceiptPrinterCapabilities.CartridgeSensors](receiptprintercapabilities_cartridgesensors.md) | [ClaimedReceiptPrinter.IsHeadCleaning](claimedreceiptprinter_isheadcleaning.md) |
| [SlipPrinterCapabilities.CartridgeSensors](slipprintercapabilities_cartridgesensors.md) | [ClaimedSlipPrinter.IsHeadCleaning](claimedslipprinter_isheadcleaning.md) |
| [ICommonPosPrintStationCapabilities.CartridgeSensors](icommonposprintstationcapabilities_cartridgesensors.md) | [ICommonClaimedPosPrinterStation.IsHeadCleaning](icommonclaimedposprinterstation_isheadcleaning.md) |

### -field NearEnd:8
The printer station has a sensor that detects if the printer cartridge is almost out of ink or toner.


## -remarks

## -examples

## -see-also
[JournalPrinterCapabilities.CartridgeSensors](journalprintercapabilities_cartridgesensors.md), [ReceiptPrinterCapabilities.CartridgeSensors](receiptprintercapabilities_cartridgesensors.md), [SlipPrinterCapabilities.CartridgeSensors](slipprintercapabilities_cartridgesensors.md), [ICommonPosPrintStationCapabilities.CartridgeSensors](icommonposprintstationcapabilities_cartridgesensors.md), [ClaimedJournalPrinter.IsCartridgeRemoved](claimedjournalprinter_iscartridgeremoved.md), [ClaimedReceiptPrinter.IsCartridgeRemoved](claimedreceiptprinter_iscartridgeremoved.md), [ClaimedSlipPrinter.IsCartridgeRemoved](claimedslipprinter_iscartridgeremoved.md), [ICommonClaimedPosPrinterStation.IsCartridgeRemoved](icommonclaimedposprinterstation_iscartridgeremoved.md), [ClaimedJournalPrinter.IsHeadCleaning](claimedjournalprinter_isheadcleaning.md), [ClaimedReceiptPrinter.IsHeadCleaning](claimedreceiptprinter_isheadcleaning.md), [ClaimedSlipPrinter.IsHeadCleaning](claimedslipprinter_isheadcleaning.md), [ICommonClaimedPosPrinterStation.IsHeadCleaning](icommonclaimedposprinterstation_isheadcleaning.md)