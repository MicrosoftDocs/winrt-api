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
The following example shows the use of [GetTemplateContent](badgeupdatemanager_gettemplatecontent_2049200015.md) to get the content for a numeric badge.

```javascript

var Notifications = Windows.UI.Notifications;

var badgeXml = Notifications.BadgeUpdateManager.getTemplateContent(Notifications.BadgeTemplateType.badgeNumber);
var badgeAttributes = badgeXml.getElementsByTagName("badge");
badgeAttributes[0].setAttribute("value", "7");
```



## -see-also
[App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Guidelines and checklist for tiles and badges](https://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to clear a badge](https://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to send a glyph or numeric badge in a local notification](https://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to set up periodic notifications for badges](https://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [How to update a badge through push notifications](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Badge XML schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](https://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd)
