---
-api-id: M:Windows.UI.Notifications.BadgeUpdateManager.CreateBadgeUpdaterForSecondaryTile(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Notifications.BadgeUpdater CreateBadgeUpdaterForSecondaryTile(System.String tileId)
-->

# Windows.UI.Notifications.BadgeUpdateManager.CreateBadgeUpdaterForSecondaryTile

## -description
Creates and initializes a new instance of the [BadgeUpdater](badgeupdater.md), which enables you to change the appearance or content of a badge on a [secondary tile](../windows.ui.startscreen/secondarytile.md). The tile can belong to the calling app or any other app in the same package.

## -parameters
### -param tileId
The unique ID of the tile.

## -returns
The object you will use to send badge updates to the tile identified by *tileID*.

## -remarks

## -examples
The following example demonstrates how to send a numeric badge notification to a secondary tile with an ID of "SecondaryTile.Dynamic".

```javascript

var Notifications = Windows.UI.Notifications;

// Define the badge content
var badgeNotification = Notifications.BadgeUpdateManager.getTemplateContent(Notifications.BadgeTemplateType.badgeNumber);
var badgeAttributes = badgeNotification.getElementsByTagName("badge");
badgeAttributes[0].setAttribute("value", "6");

// Create the notification based on the XML content.
var badge = new Notifications.BadgeNotification(badgeNotification);

// Create a secondary tile updater, passing it the ID of the tile.
Notifications.BadgeUpdateManager.createBadgeUpdaterForSecondaryTile("SecondaryTile.Dynamic");

// Send the notification to the secondary tile.
tileUpdater.update(tileNotification);
```



## -see-also
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Guidelines and checklist for tiles and badges](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to clear a badge](/previous-versions/windows/apps/hh700418(v=win.10)), [How to send a glyph or numeric badge in a local notification](/previous-versions/windows/apps/hh700418(v=win.10)), [How to set up periodic notifications for badges](/previous-versions/windows/apps/hh761476(v=win.10)), [How to update a badge through push notifications](/previous-versions/windows/apps/hh465450(v=win.10)), [Badge XML schema](/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](/previous-versions/windows/apps/hh779719(v=win.10))
