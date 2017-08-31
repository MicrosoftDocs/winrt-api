---
-api-id: M:Windows.UI.Notifications.BadgeUpdateManager.CreateBadgeUpdaterForApplication(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Notifications.BadgeUpdater CreateBadgeUpdaterForApplication(System.String applicationId)
-->

# Windows.UI.Notifications.BadgeUpdateManager.CreateBadgeUpdaterForApplication

## -description
Creates and initializes a new instance of the [BadgeUpdater](badgeupdater.md) for a specified app tile's badge, usually the tile of another app in the package. The [BadgeUpdater](badgeupdater.md) lets you change the appearance or content of that badge.

## -parameters
### -param applicationId
The unique ID of the tile whose badge you want to update.

## -returns
The object you will use to send changes to the application tile's badge.

## -remarks
The app identified by *applicationId* must belong to the same package as the caller.

## -examples

## -see-also
[CreateBadgeUpdaterForApplication](badgeupdatemanager_createbadgeupdaterforapplication_1263267855.md), [App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Guidelines and checklist for tiles and badges](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to clear a badge](http://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to send a glyph or numeric badge in a local notification](http://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to set up periodic notifications for badges](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [How to update a badge through push notifications](http://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Badge XML schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](http://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd)