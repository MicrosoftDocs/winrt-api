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

<table>
   <tr><th>Property that does not contain **PosPrinterCartridgeSensors.Removed**</th><th>Property that is not valid</th></tr>
   <tr><td>[JournalPrinterCapabilities.CartridgeSensors](journalprintercapabilities_cartridgesensors.md)</td><td>[ClaimedJournalPrinter.IsCartridgeRemoved](claimedjournalprinter_iscartridgeremoved.md)</td></tr>
   <tr><td>[ReceiptPrinterCapabilities.CartridgeSensors](receiptprintercapabilities_cartridgesensors.md)</td><td>[ClaimedReceiptPrinter.IsCartridgeRemoved](claimedreceiptprinter_iscartridgeremoved.md)</td></tr>
   <tr><td>[SlipPrinterCapabilities.CartridgeSensors](slipprintercapabilities_cartridgesensors.md)</td><td>[ClaimedSlipPrinter.IsCartridgeRemoved](claimedslipprinter_iscartridgeremoved.md)</td></tr>
   <tr><td>[ICommonPosPrintStationCapabilities.CartridgeSensors](icommonposprintstationcapabilities_cartridgesensors.md)</td><td>[ICommonClaimedPosPrinterStation.IsCartridgeRemoved](icommonclaimedposprinterstation_iscartridgeremoved.md)</td></tr>
</table>

### -field Empty:2
The printer station has a sensor that detects if the cartridge is empty.

If the **CatridgeSensors** property of the capabilities object for a printer station does not contain this value, the **IsCartridgeEmpty** property of corresponding object for the claimed printer station is not valid. The following table shows the properties that are not valid when the corresponding **CartridgeSensors** property does not contain **PosPrinterCartridgeSensors.Empty**.

<table>
   <tr><th>Property that does not contain **PosPrinterCartridgeSensors.Empty**</th><th>Property that is not valid</th></tr>
   <tr><td>[JournalPrinterCapabilities.CartridgeSensors](journalprintercapabilities_cartridgesensors.md)</td><td>[ClaimedJournalPrinter.IsCartridgeEmpty](claimedjournalprinter_iscartridgeempty.md)</td></tr>
   <tr><td>[ReceiptPrinterCapabilities.CartridgeSensors](receiptprintercapabilities_cartridgesensors.md)</td><td>[ClaimedReceiptPrinter.IsCartridgeEmpty](claimedreceiptprinter_iscartridgeempty.md)</td></tr>
   <tr><td>[SlipPrinterCapabilities.CartridgeSensors](slipprintercapabilities_cartridgesensors.md)</td><td>[ClaimedSlipPrinter.IsCartridgeEmpty](claimedslipprinter_iscartridgeempty.md)</td></tr>
   <tr><td>[ICommonPosPrintStationCapabilities.CartridgeSensors](icommonposprintstationcapabilities_cartridgesensors.md)</td><td>[ICommonClaimedPosPrinterStation.IsCartridgeEmpty](icommonclaimedposprinterstation_iscartridgeempty.md)</td></tr>
</table>

### -field HeadCleaning:4
The printer station has a sensor that detects if the head of the printer cartridge is being cleaned.

If the **CatridgeSensors** property of the capabilities object for a printer station does not contain this value, the **IsHeadCleaning** property of corresponding object for the claimed printer station is not valid. The following table shows the properties that are not valid when the corresponding **CartridgeSensors** property does not contain **PosPrinterCartridgeSensors.Head Cleaning**.

<table>
   <tr><th>Property that does not contain **PosPrinterCartridgeSensors.Head Cleaning**</th><th>Property that is not valid</th></tr>
   <tr><td>[JournalPrinterCapabilities.CartridgeSensors](journalprintercapabilities_cartridgesensors.md)</td><td>[ClaimedJournalPrinter.IsHeadCleaning](claimedjournalprinter_isheadcleaning.md)</td></tr>
   <tr><td>[ReceiptPrinterCapabilities.CartridgeSensors](receiptprintercapabilities_cartridgesensors.md)</td><td>[ClaimedReceiptPrinter.IsHeadCleaning](claimedreceiptprinter_isheadcleaning.md)</td></tr>
   <tr><td>[SlipPrinterCapabilities.CartridgeSensors](slipprintercapabilities_cartridgesensors.md)</td><td>[ClaimedSlipPrinter.IsHeadCleaning](claimedslipprinter_isheadcleaning.md)</td></tr>
   <tr><td>[ICommonPosPrintStationCapabilities.CartridgeSensors](icommonposprintstationcapabilities_cartridgesensors.md)</td><td>[ICommonClaimedPosPrinterStation.IsHeadCleaning](icommonclaimedposprinterstation_isheadcleaning.md)</td></tr>
</table>

### -field NearEnd:8
The printer station has a sensor that detects if the printer cartridge is almost out of ink or toner.


## -remarks

## -examples

## -see-also
[JournalPrinterCapabilities.CartridgeSensors](journalprintercapabilities_cartridgesensors.md), [ReceiptPrinterCapabilities.CartridgeSensors](receiptprintercapabilities_cartridgesensors.md), [SlipPrinterCapabilities.CartridgeSensors](slipprintercapabilities_cartridgesensors.md), [ICommonPosPrintStationCapabilities.CartridgeSensors](icommonposprintstationcapabilities_cartridgesensors.md), [ClaimedJournalPrinter.IsCartridgeRemoved](claimedjournalprinter_iscartridgeremoved.md), [ClaimedReceiptPrinter.IsCartridgeRemoved](claimedreceiptprinter_iscartridgeremoved.md), [ClaimedSlipPrinter.IsCartridgeRemoved](claimedslipprinter_iscartridgeremoved.md), [ICommonClaimedPosPrinterStation.IsCartridgeRemoved](icommonclaimedposprinterstation_iscartridgeremoved.md), [ClaimedJournalPrinter.IsHeadCleaning](claimedjournalprinter_isheadcleaning.md), [ClaimedReceiptPrinter.IsHeadCleaning](claimedreceiptprinter_isheadcleaning.md), [ClaimedSlipPrinter.IsHeadCleaning](claimedslipprinter_isheadcleaning.md), [ICommonClaimedPosPrinterStation.IsHeadCleaning](icommonclaimedposprinterstation_isheadcleaning.md)