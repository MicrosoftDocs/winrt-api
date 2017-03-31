---
-api-id: P:Windows.Devices.PointOfService.ClaimedJournalPrinter.LineSpacing
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public uint LineSpacing { get;  set; }
-->

# Windows.Devices.PointOfService.ClaimedJournalPrinter.LineSpacing

## -description
Gets or sets the spacing of each single-high print line for the journal printer station, in the units that the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property specifies. This spacing includes both the height of printed line and of the white space between each pair of lines.

It is worth noting that changing this property can potentially change the [CharactersPerLine](claimedjournalprinter_charactersperline.md), [LineHeight](claimedjournalprinter_lineheight.md) and [LineWidth](claimedjournalprinter_linewidth.md) properties.

## -property-value
The spacing of each single-high print line for the journal printer station, in the units that the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property specifies.

## -remarks

## -examples

## -see-also
