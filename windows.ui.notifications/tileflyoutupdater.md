---
-api-id: T:Windows.UI.Notifications.TileFlyoutUpdater
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class TileFlyoutUpdater : Windows.UI.Notifications.ITileFlyoutUpdater
-->

# Windows.UI.Notifications.TileFlyoutUpdater

## -description
Used to send or clear a tile flyout (mix view) notification. This class also provides methods to start and stop [periodic](/previous-versions/windows/apps/jj150587(v=win.10)) tile flyout notifications.

This class is part of the following general API usage pattern: 
+ Call [TileFlyoutUpdateManager.GetTemplateContent](tileflyoutupdatemanager_gettemplatecontent_739748376.md) to retrieve and fill in a blank tile flyout notification XML template
+ Call the [TileFlyoutNotification](tileflyoutnotification_tileflyoutnotification_93177318.md) constructor to encapsulate the template content as a flyout notification
+ Call one of the [TileFlyoutUpdateManager](tileflyoutupdatemanager.md) methods to create a TileFlyoutUpdater
+ Call [TileFlyoutUpdater.Update](tileflyoutupdater_update_298111616.md) to send the [TileFlyoutNotification](tileflyoutnotification.md) to the tile


## -remarks

## -examples

## -see-also
[TileFlyoutUpdateManager](tileflyoutupdatemanager.md), [TileFlyoutNotification](tileflyoutnotification.md)
