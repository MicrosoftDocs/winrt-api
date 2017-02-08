---
-api-id: M:Windows.UI.Notifications.BadgeUpdateManager.CreateBadgeUpdaterForApplication
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Notifications.BadgeUpdater CreateBadgeUpdaterForApplication()
-->

# Windows.UI.Notifications.BadgeUpdateManager.CreateBadgeUpdaterForApplication

## -description
Creates and initializes a new instance of the [BadgeUpdater](badgeupdater.md), which lets you change the appearance or content of the badge on the calling app's tile.

## -returns
The object you will use to send changes to the app tile's badge.

## -remarks

## -examples
The following example shows [CreateBadgeUpdaterForApplication](badgeupdatemanager_createbadgeupdaterforapplication_1263267855.md) used to send a numeric badge update to the calling app's tile.

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
[CreateBadgeUpdaterForApplication(String)](badgeupdatemanager_createbadgeupdaterforapplication_315230511.md), [App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Guidelines and checklist for tiles and badges](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to clear a badge](XREF:TODO:m_ui_tiles.howto_clear_a_badge), [How to send a glyph or numeric badge in a local notification](XREF:TODO:m_ui_tiles.howto_send_local_badge_notifications), [How to set up periodic notifications for badges](XREF:TODO:m_ui_tiles.howto_setup_badge_polling), [How to update a badge through push notifications](XREF:TODO:m_ui_tiles.howto_update_badges_push), [Badge XML schema](XREF:TODO:badge.Schema_Root), [Badge overview](http://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd)