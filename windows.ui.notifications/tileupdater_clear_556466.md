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
[App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](https://docs.microsoft.com/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](https://docs.microsoft.com/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](https://docs.microsoft.com/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](https://docs.microsoft.com/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root)
