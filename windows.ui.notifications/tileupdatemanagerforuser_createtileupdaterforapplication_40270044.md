---
-api-id: M:Windows.UI.Notifications.TileUpdateManagerForUser.CreateTileUpdaterForApplication(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Notifications.TileUpdater CreateTileUpdaterForApplication(System.String applicationId)
-->

# Windows.UI.Notifications.TileUpdateManagerForUser.CreateTileUpdaterForApplication

## -description
Creates a new [TileUpdater](tileupdater.md) for a tile for the bound [user](tileupdatemanagerforuser_user.md). The tile can belong to the calling app or any other app in the same package. The [TileUpdater](tileupdater.md) lets a developer change the appearance of that tile.

## -parameters
### -param applicationId
The package-relative application identifier (PRAID) of the tile. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the [Application](/uwp/schemas/appxpackage/appxmanifestschema/element-application#attributes-and-elements) element.

If you are hosting background task(s) in an out-of-process COM server, separate from your main application, then pass as the argument for `applicationId` the PRAID of the application that defines the `windows.backgroundTask` extension in its own package manifest.

## -returns
The object you will use to send changes to the tile identified by *applicationId*.

## -remarks

## -examples

## -see-also
