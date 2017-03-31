---
-api-id: P:Windows.Devices.PointOfService.ClaimedJournalPrinter.LineHeight
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public uint LineHeight { get;  set; }
-->

# Windows.Devices.PointOfService.ClaimedJournalPrinter.LineHeight

## -description
Gets or sets the current height of the printed line for the journal printer station, in the units that the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property specifies.

It is worth noting that changing this property can potentially change the [CharactersPerLine](claimedjournalprinter_charactersperline.md), [LineSpacing](claimedjournalprinter_linespacing.md) and [LineWidth](claimedjournalprinter_linewidth.md) properties.

## -property-value
The current height of the printed line for the journal printer station, in the units that the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property specifies.

## -remarks

## -examples

## -see-also
[ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md), [ClaimedJournalPrinter.LineSpacing](claimedjournalprinter_linespacing.md), [ClaimedJournalPrinter.LineWidth](claimedjournalprinter_linewidth.md), [ICommonClaimedPosPrinterStation.LineHeight](icommonclaimedposprinterstation_lineheight.md)