---
-api-id: P:Windows.Devices.PointOfService.ClaimedPosPrinter.Journal
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Devices.PointOfService.ClaimedJournalPrinter Journal { get; }
-->

# Windows.Devices.PointOfService.ClaimedPosPrinter.Journal

## -description
Gets an object that represents the journal station for a claimed point-of-service printer.

The journal station is used for simple text messages that log transaction and activity information kept by the store for audit and other purposes.

There is only one instance of this object per [ClaimedPosPrinter](claimedposprinter.md) instance. Additionally, this is only valid to access if [JournalPrinterCapabilities.IsPrinterPresent](journalprintercapabilities_isprinterpresent.md) indicates it is present.

## -property-value
An object that represents the journal station for a claimed point-of-service printer. Null if a journal station is not present.

## -remarks
You should check the value of the [JournalPrinterCapabilities.IsPrinterPresent](journalprintercapabilities_isprinterpresent.md) property before you try to use the [ClaimedPosPrinter.Journal](claimedposprinter_journal.md) property.

## -examples

## -see-also
[ClaimedJournalPrinter](claimedjournalprinter.md), [JournalPrinterCapabilities.IsPrinterPresent](journalprintercapabilities_isprinterpresent.md)