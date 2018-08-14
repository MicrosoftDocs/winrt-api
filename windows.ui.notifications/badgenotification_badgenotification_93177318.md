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
The value attribute can be a number from 1-99 or a status glyph. See the [Badge overview](http://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd) for a complete list of available images.

## -examples
The following example code uses the [BadgeNotification](badgenotification_badgenotification_93177318.md) method to create a numeric badge notification.

```javascript

var Notifications = Windows.UI.Notifications;

var badgeXml = Notifications.BadgeUpdateManager.getTemplateContent(Notifications.BadgeTemplateType.badgeNumber);
var badgeAttributes = badgeXml.getElementsByTagName("badge");
badgeAttributes[0].setAttribute("value", "26");

// Create a badge notification from XML
var badgeNotification = new Notifications.badgeNotification(badgeXml);
```



## -see-also
[App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Badge overview](http://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd), [Guidelines and checklist for tiles and badges](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to clear a badge](http://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to send a glyph or numeric badge in a local notification](http://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to set up periodic notifications for badges](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [How to update a badge through push notifications](http://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Badge XML schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root)