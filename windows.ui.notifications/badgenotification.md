---
-api-id: T:Windows.UI.Notifications.BadgeNotification
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class BadgeNotification : Windows.UI.Notifications.IBadgeNotification
-->

# Windows.UI.Notifications.BadgeNotification

## -description
Defines the content, associated metadata, and expiration time of an update to a tile's badge overlay. A badge can display a number from 1 to 99 or a [status glyph](https://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd).

## -remarks

## -examples
The following example code uses the [BadgeNotification](badgenotification_badgenotification_93177318.md) method to create a numeric badge notification. If you used this method to set the value to "0", it would clear the badge.

```javascript

var Notifications = Windows.UI.Notifications;

var badgeXml = Notifications.BadgeUpdateManager.getTemplateContent(Notifications.BadgeTemplateType.badgeNumber);
var badgeAttributes = badgeXml.getElementsByTagName("badge");
badgeAttributes[0].setAttribute("value", "26");

// Create a badge notification from XML
var badgeNotification = new Notifications.badgeNotification(badgeXml);
```

The following example code uses the [BadgeNotification](badgenotification_badgenotification_93177318.md) method to create a glyph badge notification. If you used this method to set the value to "none", it would clear the badge.

```javascript

var Notifications = Windows.UI.Notifications;

var badgeXml = Notifications.BadgeUpdateManager.getTemplateContent(Notifications.BadgeTemplateType.badgeNumber);
var badgeAttributes = badgeXml.getElementsByTagName("badge");
badgeAttributes[0].setAttribute("value", "alert");

// Create a badge notification from XML
var badgeNotification = new Notifications.badgeNotification(badgeXml);
```



## -see-also
[App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Badge overview](https://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd), [Guidelines and checklist for tiles and badges](https://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to clear a badge](https://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to send a glyph or numeric badge in a local notification](https://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to set up periodic notifications for badges](https://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [How to update a badge through push notifications](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Badge XML schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root)
