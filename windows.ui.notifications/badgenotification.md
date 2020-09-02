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
Defines the content, associated metadata, and expiration time of an update to a tile's badge overlay. A badge can display a number from 1 to 99 or a [status glyph](/previous-versions/windows/apps/hh779719(v=win.10)).

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
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Badge overview](/previous-versions/windows/apps/hh779719(v=win.10)), [Guidelines and checklist for tiles and badges](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to clear a badge](/previous-versions/windows/apps/hh700418(v=win.10)), [How to send a glyph or numeric badge in a local notification](/previous-versions/windows/apps/hh700418(v=win.10)), [How to set up periodic notifications for badges](/previous-versions/windows/apps/hh761476(v=win.10)), [How to update a badge through push notifications](/previous-versions/windows/apps/hh465450(v=win.10)), [Badge XML schema](/uwp/schemas/tiles/badgeschema/schema-root)
