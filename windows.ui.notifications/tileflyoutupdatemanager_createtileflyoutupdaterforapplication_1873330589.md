---
-api-id: M:Windows.UI.Notifications.TileFlyoutUpdateManager.CreateTileFlyoutUpdaterForApplication(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Notifications.TileFlyoutUpdater CreateTileFlyoutUpdaterForApplication(System.String applicationId)
-->

# Windows.UI.Notifications.TileFlyoutUpdateManager.CreateTileFlyoutUpdaterForApplication

## -description
Creates a new [TileFlyoutUpdater](tileflyoutupdater.md) object for a specified tile, for use with a tile flyout (mix view) notification. Because this method overload uses a tile ID, this tile can belong to another app in the same package as the calling app.

## -parameters
### -param applicationId
The ID of the app.

## -returns
An object that you can use to send notification updates to the tile flyout for the specified app, clear the flyout notification, and start and stop [periodic](/previous-versions/windows/apps/jj150587(v=win.10)) flyout notifications.

## -remarks

## -examples

## -see-also
[CreateTileFlyoutUpdaterForApplication](tileflyoutupdatemanager_createtileflyoutupdaterforapplication_908671165.md)