---
-api-id: M:Windows.UI.Notifications.TileUpdater.Clear
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Clear()
-->

# Windows.UI.Notifications.TileUpdater.Clear

## -description
Removes all updates and causes the tile to display its default content as declared in the app's manifest.

## -remarks
> [!NOTE]
> This method does not stop periodic updates. If your tile is using periodic updates, you must also call [StopPeriodicUpdate](tileupdater_stopperiodicupdate_376301793.md) to prevent further updates.

## -examples

## -see-also
[App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](http://msdn.microsoft.com/library/d4b2cebf-9dec-4c8f-bc6d-23edca7aaf83), [Tile and tile notification overview](http://msdn.microsoft.com/library/10a05b52-42c4-4f85-9310-57663e378b9e), [The tile template catalog](http://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f), [Guidelines and checklist for tiles](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to schedule a tile notification](http://msdn.microsoft.com/library/56b0c3e3-be90-4461-a8b1-79e88072b37c), [How to set up periodic notifications for tiles](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Tiles XML schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root)