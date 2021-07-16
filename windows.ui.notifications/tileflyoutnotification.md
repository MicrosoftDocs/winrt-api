---
-api-id: T:Windows.UI.Notifications.TileFlyoutNotification
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class TileFlyoutNotification : Windows.UI.Notifications.ITileFlyoutNotification
-->

# Windows.UI.Notifications.TileFlyoutNotification

## -description
Provides the details of a tile flyout (mix view) notification. This includes the notification's XML content and, optionally, its expiration time. This class also provides a method by which you can retrieve the current flyout notification's XML content.

This class is part of the following general API usage pattern: 
+ Call [TileFlyoutUpdateManager.GetTemplateContent](tileflyoutupdatemanager_gettemplatecontent_739748376.md) to retrieve and fill in a blank tile flyout notification XML template
+ Call the [TileFlyoutNotification](tileflyoutnotification_tileflyoutnotification_93177318.md) constructor to encapsulate the template content as a flyout notification
+ Call one of the [TileFlyoutUpdateManager](tileflyoutupdatemanager.md) methods to create a [TileFlyoutUpdater](tileflyoutupdater.md)
+ Call [TileFlyoutUpdater.Update](tileflyoutupdater_update_298111616.md) to send the TileFlyoutNotification to the tile


## -remarks

## -examples

## -see-also
[TileFlyoutUpdateManager](tileflyoutupdatemanager.md), [TileFlyoutUpdater](tileflyoutupdater.md)
