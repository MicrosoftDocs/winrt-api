---
-api-id: T:Windows.UI.Notifications.TileFlyoutUpdateManager
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class TileFlyoutUpdateManager 
-->

# Windows.UI.Notifications.TileFlyoutUpdateManager

## -description
Creates [TileFlyoutUpdater](tileflyoutupdater.md) objects specific to an app's primary or secondary tile, for use with a tile flyout (mix view) notification. This class also enables you to retrieve a blank tile flyout XML template to which you can add your content to define the tile flyout notification.

This class is part of the following general API usage pattern: 
+ Call [TileFlyoutUpdateManager.GetTemplateContent](tileflyoutupdatemanager_gettemplatecontent_739748376.md) to retrieve and fill in a blank tile flyout notification XML template
+ Call the [TileFlyoutNotification](tileflyoutnotification_tileflyoutnotification_93177318.md) constructor to encapsulate the template content as a flyout notification
+ Call one of the **TileFlyoutUpdateManager** methods to create a [TileFlyoutUpdater](tileflyoutupdater.md)
+ Call [TileFlyoutUpdater.Update](tileflyoutupdater_update_298111616.md) to send the [TileFlyoutNotification](tileflyoutnotification.md) to the tile


## -remarks

## -examples

## -see-also
[TileFlyoutNotification](tileflyoutnotification.md), [TileFlyoutUpdater](tileflyoutupdater.md)