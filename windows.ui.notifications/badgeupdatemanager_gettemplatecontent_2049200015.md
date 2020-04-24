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

See [badge schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root)for an explanation of badge elements and attributes.

## -examples
The following example shows the use of GetTemplateContent to get the content for a numeric badge.

```javascript

var Notifications = Windows.UI.Notifications;

var badgeXml = Notifications.BadgeUpdateManager.getTemplateContent(Notifications.BadgeTemplateType.badgeNumber);
var badgeAttributes = badgeXml.getElementsByTagName("badge");
badgeAttributes[0].setAttribute("value", "7");
```



## -see-also
[App tiles and badges sample](http://code.msdn.microsoft.com/windowsapps/app-tiles-and-badges-sample-5fc49148), [Guidelines and checklist for tiles and badges](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to clear a badge](https://docs.microsoft.com/previous-versions/windows/apps/hh700418(v=win.10)), [How to send a glyph or numeric badge in a local notification](https://docs.microsoft.com/previous-versions/windows/apps/hh700418(v=win.10)), [How to set up periodic notifications for badges](https://docs.microsoft.com/previous-versions/windows/apps/hh761476(v=win.10)), [How to update a badge through push notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Badge XML schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779719(v=win.10))
