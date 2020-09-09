---
-api-id: M:Windows.UI.Notifications.BadgeUpdateManager.GetTemplateContent(Windows.UI.Notifications.BadgeTemplateType)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Data.Xml.Dom.XmlDocument GetTemplateContent(Windows.UI.Notifications.BadgeTemplateType type)
-->

# Windows.UI.Notifications.BadgeUpdateManager.GetTemplateContent

## -description
Gets the XML content of one of the predefined badge templates so that you can customize it for a badge update.

## -parameters
### -param type
The type of badge template, either a glyph or a number.

## -returns
The object that contains the template XML.

## -remarks
Instead of creating the full XML payload yourself, you can get the default template and then use Document Object Model (DOM) manipulation functions to customize the part of the content that you want to change. You package this XML in a [BadgeNotification](badgenotification.md) and send it to the tile through the [BadgeUpdater](badgeupdater.md) that you create through the other methods of this class.

See [badge schema](/uwp/schemas/tiles/badgeschema/schema-root)for an explanation of badge elements and attributes.

## -examples
The following example shows the use of GetTemplateContent to get the content for a numeric badge.

```javascript

var Notifications = Windows.UI.Notifications;

var badgeXml = Notifications.BadgeUpdateManager.getTemplateContent(Notifications.BadgeTemplateType.badgeNumber);
var badgeAttributes = badgeXml.getElementsByTagName("badge");
badgeAttributes[0].setAttribute("value", "7");
```



## -see-also
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Guidelines and checklist for tiles and badges](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to clear a badge](/previous-versions/windows/apps/hh700418(v=win.10)), [How to send a glyph or numeric badge in a local notification](/previous-versions/windows/apps/hh700418(v=win.10)), [How to set up periodic notifications for badges](/previous-versions/windows/apps/hh761476(v=win.10)), [How to update a badge through push notifications](/previous-versions/windows/apps/hh465450(v=win.10)), [Badge XML schema](/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](/previous-versions/windows/apps/hh779719(v=win.10))
