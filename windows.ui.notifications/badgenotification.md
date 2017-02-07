---
-api-id: T:Windows.UI.Notifications.BadgeNotification
-api-type: winrt class
---

<!-- Class syntax.
public class BadgeNotification : Windows.UI.Notifications.IBadgeNotification
-->

# Windows.UI.Notifications.BadgeNotification

## -description
Defines the content, associated metadata, and expiration time of an update to a tile's badge overlay. A badge can display a number from 1 to 99 or a [status glyph](http://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd).

## -remarks

## -examples
The following example code uses the [BadgeNotification](badgenotification_badgenotification.md) method to create a numeric badge notification. If you used this method to set the value to "0", it would clear the badge.

```javascript

var Notifications = Windows.UI.Notifications;

var badgeXml = Notifications.BadgeUpdateManager.getTemplateContent(Notifications.BadgeTemplateType.badgeNumber);
var badgeAttributes = badgeXml.getElementsByTagName("badge");
badgeAttributes[0].setAttribute("value", "26");

// Create a badge notification from XML
var badgeNotification = new Notifications.badgeNotification(badgeXml);
```

The following example code uses the [BadgeNotification](badgenotification_badgenotification.md) method to create a glyph badge notification. If you used this method to set the value to "none", it would clear the badge.

```javascript

var Notifications = Windows.UI.Notifications;

var badgeXml = Notifications.BadgeUpdateManager.getTemplateContent(Notifications.BadgeTemplateType.badgeNumber);
var badgeAttributes = badgeXml.getElementsByTagName("badge");
badgeAttributes[0].setAttribute("value", "alert");

// Create a badge notification from XML
var badgeNotification = new Notifications.badgeNotification(badgeXml);
```



## -see-also
[App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Badge overview](http://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd), [Guidelines and checklist for tiles and badges](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to clear a badge](XREF:TODO:m_ui_tiles.howto_clear_a_badge), [How to send a glyph or numeric badge in a local notification](XREF:TODO:m_ui_tiles.howto_send_local_badge_notifications), [How to set up periodic notifications for badges](XREF:TODO:m_ui_tiles.howto_setup_badge_polling), [How to update a badge through push notifications](XREF:TODO:m_ui_tiles.howto_update_badges_push), [Badge XML schema](XREF:TODO:badge.Schema_Root)