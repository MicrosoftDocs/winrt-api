---
-api-id: P:Windows.Devices.PointOfService.ClaimedPosPrinter.IsCharacterSetMappingEnabled
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool IsCharacterSetMappingEnabled { get;  set; }
-->

# Windows.Devices.PointOfService.ClaimedPosPrinter.IsCharacterSetMappingEnabled

## -description
Gets or sets whether the driver or provider can map Unicode characters to characters that the point-of-service printer can print, or just sends the low byte of the Unicode character to the printer directly.

## -property-value
True if the driver or provider maps Unicode characters to character that the point-of-service printer can print. False if the driver or provider sends the low byte of each Unicode character to the point-of-service printer directly.

## -remarks

## -examples

## -see-also
[ClaimedPosPrinter.CharacterSet](claimedposprinter_characterset.md), [PosPrinter.SupportedCharacterSets](posprinter_supportedcharactersets.md)