---
-api-id: P:Windows.Devices.PointOfService.PosPrinterCapabilities.CanMapCharacterSet
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool CanMapCharacterSet { get; }
-->

# Windows.Devices.PointOfService.PosPrinterCapabilities.CanMapCharacterSet

## -description
Gets whether the point-of-service printer can map the characters that the application sends (in the character set that the [ClaimedPosPrinter.CharacterSet](claimedposprinter_characterset.md) property defines) to the character sets that the [PosPrinter.SupportedCharacterSets](posprinter_supportedcharactersets.md) property defines.

## -property-value
True if the point-of-service printer can map the characters that the application sends to the code page used by the printer. If false, the user must make sure that the Unicode characters have the low byte as the value that will be used to send to the printer.

## -remarks

## -examples

## -see-also
[ClaimedPosPrinter.CharacterSet](claimedposprinter_characterset.md), [PosPrinter.SupportedCharacterSets](posprinter_supportedcharactersets.md)