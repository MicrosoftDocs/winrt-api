---
-api-id: M:Windows.UI.Notifications.BadgeUpdateManager.CreateBadgeUpdaterForApplication(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Notifications.BadgeUpdater CreateBadgeUpdaterForApplication(System.String applicationId)
-->

# Windows.UI.Notifications.BadgeUpdateManager.CreateBadgeUpdaterForApplication

## -description
Creates and initializes a new instance of the [BadgeUpdater](badgeupdater.md) for a specified app tile's badge, usually the tile of another app in the package. The [BadgeUpdater](badgeupdater.md) lets you change the appearance or content of that badge.

## -parameters
### -param applicationId
The unique ID of the tile whose badge you want to update.

## -returns
The object you will use to send changes to the application tile's badge.

## -remarks
The app identified by *applicationId* must belong to the same package as the caller.

## -examples

## -see-also
[CreateBadgeUpdaterForApplication](badgeupdatemanager_createbadgeupdaterforapplication_1263267855.md), [App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Guidelines and checklist for tiles and badges](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to clear a badge](XREF:TODO:m_ui_tiles.howto_clear_a_badge), [How to send a glyph or numeric badge in a local notification](XREF:TODO:m_ui_tiles.howto_send_local_badge_notifications), [How to set up periodic notifications for badges](XREF:TODO:m_ui_tiles.howto_setup_badge_polling), [How to update a badge through push notifications](XREF:TODO:m_ui_tiles.howto_update_badges_push), [Badge XML schema](XREF:TODO:badge.Schema_Root), [Badge overview](http://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd)