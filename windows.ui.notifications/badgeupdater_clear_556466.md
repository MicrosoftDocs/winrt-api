---
-api-id: M:Windows.UI.Notifications.BadgeUpdater.Clear
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Clear()
-->

# Windows.UI.Notifications.BadgeUpdater.Clear

## -description
Removes the badge from the tile that the updater is bound to.

## -remarks
The badge can also be cleared by setting the badge value to "0" or "none".

> [!NOTE]
> If your badge is using periodic updates, you must also call [StopPeriodicUpdate](badgeupdater_stopperiodicupdate_376301793.md) or the badge will reappear at the next polling interval.

## -examples

## -see-also
[App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Guidelines and checklist for tiles and badges](https://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to clear a badge](https://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to send a glyph or numeric badge in a local notification](https://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to set up periodic notifications for badges](https://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [How to update a badge through push notifications](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Badge XML schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](https://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd)
