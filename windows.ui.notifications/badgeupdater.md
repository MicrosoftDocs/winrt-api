---
-api-id: T:Windows.UI.Notifications.BadgeUpdater
-api-type: winrt class
---

<!-- Class syntax.
public class BadgeUpdater : Windows.UI.Notifications.IBadgeUpdater
-->

# Windows.UI.Notifications.BadgeUpdater

## -description
Updates a badge overlay on the specific tile that the updater is bound to.

## -remarks
To get an instance of this object, call the [BadgeUpdateManager.CreateBadgeUpdaterForApplication](badgeupdatemanager_createbadgeupdaterforapplication.md) or [BadgeUpdateManager.CreateBadgeUpdaterForSecondaryTile](badgeupdatemanager_createbadgeupdaterforsecondarytile.md) method.

When it is created, [BadgeUpdater](badgeupdater.md) is bound to a specific app or secondary tile, so the methods of this class affect only the single tile that the object instance is bound to.

## -examples
The following example shows the use of [Update](badgeupdater_update.md) to send a numeric badge update to the calling app's tile.

```javascript

function sendBadgeNotification() {
    var Notifications = Windows.UI.Notifications;
    var badgeXml;
    var badgeAttributes;

    // Get an XML DOM version of a specific template by using getTemplateContent.
    badgeXml = Notifications.BadgeUpdateManager.getTemplateContent(Notifications.BadgeTemplateType.badgeNumber);
    badgeAttributes = badgeXml.getElementsByTagName("badge");
    badgeAttributes[0].setAttribute("value", "7");

    // Create a badge notification from the XML content.
    var badgeNotification = new Notifications.BadgeNotification(badgeXml);

    // Send the badge notification to the app's tile.
    Notifications.BadgeUpdateManager.createBadgeUpdaterForApplication().update(badgeNotification);
}
```



## -see-also
[App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Guidelines and checklist for tiles and badges](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to clear a badge](XREF:TODO:m_ui_tiles.howto_clear_a_badge), [How to send a glyph or numeric badge in a local notification](XREF:TODO:m_ui_tiles.howto_send_local_badge_notifications), [How to set up periodic notifications for badges](XREF:TODO:m_ui_tiles.howto_setup_badge_polling), [How to update a badge through push notifications](XREF:TODO:m_ui_tiles.howto_update_badges_push), [Badge XML schema](XREF:TODO:badge.Schema_Root), [Badge overview](http://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd)