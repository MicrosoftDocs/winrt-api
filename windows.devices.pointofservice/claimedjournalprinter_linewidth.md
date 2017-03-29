---
-api-id: P:Windows.Devices.PointOfService.ClaimedJournalPrinter.LineWidth
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public uint LineWidth { get; }
-->

# Windows.Devices.PointOfService.ClaimedJournalPrinter.LineWidth

## -description
Gets the current width of the printed line for the journal printer station, in the units that the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property specifies.

It is worth noting that changing this property can potentially change the [CharactersPerLine](claimedjournalprinter_charactersperline.md), [LineHeight](claimedjournalprinter_lineheight.md) and [LineSpacing](claimedjournalprinter_linespacing.md) properties.

## -property-value
The current width of the printed line for the journal printer station, in the units that the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property specifies.

## -remarks

## -examples

## -see-also
[ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md), [ClaimedJournalPrinter.LineHeight](claimedjournalprinter_lineheight.md), [ClaimedJournalPrinter.LineSpacing](claimedjournalprinter_linespacing.md), [ICommonClaimedPosPrinterStation.LineWidth](icommonclaimedposprinterstation_linewidth.md)