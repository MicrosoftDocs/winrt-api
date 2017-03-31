---
-api-id: M:Windows.UI.Notifications.TileUpdater.StartPeriodicUpdate(Windows.Foundation.Uri,Windows.UI.Notifications.PeriodicUpdateRecurrence)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void StartPeriodicUpdate(Windows.Foundation.Uri tileContent, Windows.UI.Notifications.PeriodicUpdateRecurrence requestedInterval)
-->

# Windows.UI.Notifications.TileUpdater.StartPeriodicUpdate

## -description
Begins a series of timed content changes for the tile that the updater is bound to, beginning immediately.

## -parameters
### -param tileContent
The Uniform Resource Identifier (URI) from which the XML content of the tile update will be retrieved.

### -param requestedInterval
The frequency with which the Uniform Resource Identifier (URI) is polled for new tile content, following the initial update at *startTime*.

## -remarks

## -examples

## -see-also
[StartPeriodicUpdate(Uri, DateTime, PeriodicUpdateRecurrence)](tileupdater_startperiodicupdate_1369986471.md), [How to set up periodic notifications for tiles](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Guidelines and checklist for periodic notifications](http://msdn.microsoft.com/library/4be95d67-2adf-4d0e-83e1-4ad25e0f4c0b), [App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](http://msdn.microsoft.com/library/d4b2cebf-9dec-4c8f-bc6d-23edca7aaf83), [Tile and tile notification overview](http://msdn.microsoft.com/library/10a05b52-42c4-4f85-9310-57663e378b9e), [The tile template catalog](http://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f), [Guidelines and checklist for tiles](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to schedule a tile notification](http://msdn.microsoft.com/library/56b0c3e3-be90-4461-a8b1-79e88072b37c), [How to set up periodic notifications for tiles](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Tiles XML schema](XREF:TODO:tile.Schema_Root)