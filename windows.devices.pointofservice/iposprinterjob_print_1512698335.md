---
-api-id: M:Windows.Devices.PointOfService.IPosPrinterJob.Print(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Print(System.String data)
-->

# Windows.Devices.PointOfService.IPosPrinterJob.Print

## -description
Adds an instruction to the print job to print the specified text.

## -parameters
### -param data
The text to print on the point-of-service printer.

## -remarks
If [ClaimedPosPrinter.IsCharacterSetMappingEnabled](claimedposprinter_ischaractersetmappingenabled.md) is true, the text is mapped to the font on the printer that [ClaimedPosPrinter.CharacterSet](claimedposprinter_characterset.md) specifies. If [ClaimedPosPrinter.IsCharacterSetMappingEnabled](claimedposprinter_ischaractersetmappingenabled.md) is false, the driver or provider sends the low byte of each Unicode character to the printer verbatim.

## -examples

## -see-also
