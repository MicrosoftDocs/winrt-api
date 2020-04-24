---
-api-id: M:Windows.UI.Notifications.BadgeUpdater.Update(Windows.UI.Notifications.BadgeNotification)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Update(Windows.UI.Notifications.BadgeNotification notification)
-->

# Windows.UI.Notifications.BadgeUpdater.Update

## -description
Applies a change to the badge's glyph or number.

## -parameters
### -param notification
The object that supplies the new XML definition for the badge.

## -remarks

## -examples
The following example shows the use of Update to send a numeric badge update to the calling app's tile.

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
[App tiles and badges sample](http://code.msdn.microsoft.com/windowsapps/app-tiles-and-badges-sample-5fc49148), [Guidelines and checklist for tiles and badges](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to clear a badge](https://docs.microsoft.com/previous-versions/windows/apps/hh700418(v=win.10)), [How to send a glyph or numeric badge in a local notification](https://docs.microsoft.com/previous-versions/windows/apps/hh700418(v=win.10)), [How to set up periodic notifications for badges](https://docs.microsoft.com/previous-versions/windows/apps/hh761476(v=win.10)), [How to update a badge through push notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Badge XML schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779719(v=win.10))
