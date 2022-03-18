---
-api-id: M:Windows.UI.Notifications.BadgeNotification.#ctor(Windows.Data.Xml.Dom.XmlDocument)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public BadgeNotification(Windows.Data.Xml.Dom.XmlDocument content)
-->

# Windows.UI.Notifications.BadgeNotification.BadgeNotification

## -description
Creates and initializes a new instance of the [BadgeNotification](badgenotification.md).

## -parameters
### -param content
The XML content that defines the badge update.

## -remarks
The value attribute can be a number from 1-99 or a status glyph. See the [Badge overview](/previous-versions/windows/apps/hh779719(v=win.10)) for a complete list of available images.

## -examples
The following example code uses the BadgeNotification method to create a numeric badge notification.

```javascript

var Notifications = Windows.UI.Notifications;

var badgeXml = Notifications.BadgeUpdateManager.getTemplateContent(Notifications.BadgeTemplateType.badgeNumber);
var badgeAttributes = badgeXml.getElementsByTagName("badge");
badgeAttributes[0].setAttribute("value", "26");

// Create a badge notification from XML
var badgeNotification = new Notifications.badgeNotification(badgeXml);
```



## -see-also
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Badge overview](/previous-versions/windows/apps/hh779719(v=win.10)), [Guidelines and checklist for tiles and badges](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to clear a badge](/previous-versions/windows/apps/hh700418(v=win.10)), [How to send a glyph or numeric badge in a local notification](/previous-versions/windows/apps/hh700418(v=win.10)), [How to set up periodic notifications for badges](/previous-versions/windows/apps/hh761476(v=win.10)), [How to update a badge through push notifications](/previous-versions/windows/apps/hh465450(v=win.10)), [Badge XML schema](/uwp/schemas/tiles/badgeschema/schema-root)
