---
-api-id: M:Windows.UI.Notifications.TileUpdateManager.CreateTileUpdaterForApplication(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Notifications.TileUpdater CreateTileUpdaterForApplication(System.String applicationId)
-->

# Windows.UI.Notifications.TileUpdateManager.CreateTileUpdaterForApplication

## -description
Creates and initializes a new instance of the [TileUpdater](tileupdater.md) for a tile that belongs to another app in the same package as the calling app. The [TileUpdater](tileupdater.md) lets a developer change the appearance of that tile.

## -parameters
### -param applicationId
The package-relative application identifier (PRAID) of the tile. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the [Application](/uwp/schemas/appxpackage/appxmanifestschema/element-application#attributes-and-elements) element.

If you are hosting background task(s) in an out-of-process COM server, separate from your main application, then pass as the argument for `applicationId` the PRAID of the application that defines the `windows.backgroundTask` extension in its own package manifest.

## -returns
The object you will use to send changes to the tile identified by *applicationId*.

## -remarks
This method is used only in conjunction with multi-app packages. The app identified by *applicationId* must belong to the same package as the caller.

Although you can specify the calling application's tile in this method, [createTileUpdaterForApplication](tileupdatemanager_createtileupdaterforapplication_1541898748.md) is the preferred method to use with single-app packages.

## -examples

## -see-also
[CreateTileUpdaterForApplication](tileupdatemanager_createtileupdaterforapplication_1541898748.md), [App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)
