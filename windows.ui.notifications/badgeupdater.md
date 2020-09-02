---
-api-id: T:Windows.UI.Notifications.BadgeUpdater
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class BadgeUpdater : Windows.UI.Notifications.IBadgeUpdater
-->

# Windows.UI.Notifications.BadgeUpdater

## -description
Updates a badge overlay on the specific tile that the updater is bound to.

## -remarks
To get an instance of this object, call the [BadgeUpdateManager.CreateBadgeUpdaterForApplication](badgeupdatemanager_createbadgeupdaterforapplication_1263267855.md) or [BadgeUpdateManager.CreateBadgeUpdaterForSecondaryTile](badgeupdatemanager_createbadgeupdaterforsecondarytile_131286133.md) method.

When it is created, BadgeUpdater is bound to a specific app or secondary tile, so the methods of this class affect only the single tile that the object instance is bound to.

## -examples
The following example shows the use of [Update](badgeupdater_update_1826834066.md) to send a numeric badge update to the calling app's tile.

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
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Guidelines and checklist for tiles and badges](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to clear a badge](/previous-versions/windows/apps/hh700418(v=win.10)), [How to send a glyph or numeric badge in a local notification](/previous-versions/windows/apps/hh700418(v=win.10)), [How to set up periodic notifications for badges](/previous-versions/windows/apps/hh761476(v=win.10)), [How to update a badge through push notifications](/previous-versions/windows/apps/hh465450(v=win.10)), [Badge XML schema](/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](/previous-versions/windows/apps/hh779719(v=win.10))
