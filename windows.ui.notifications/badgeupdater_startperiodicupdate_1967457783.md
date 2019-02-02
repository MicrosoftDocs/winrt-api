---
-api-id: M:Windows.UI.Notifications.BadgeUpdater.StartPeriodicUpdate(Windows.Foundation.Uri,Windows.UI.Notifications.PeriodicUpdateRecurrence)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void StartPeriodicUpdate(Windows.Foundation.Uri badgeContent, Windows.UI.Notifications.PeriodicUpdateRecurrence requestedInterval)
-->

# Windows.UI.Notifications.BadgeUpdater.StartPeriodicUpdate

## -description
Begins a series of timed updates for the badge from a web resource that the updater is bound to, beginning immediately. Note that only web resources (http/https) are allowed in a periodic update.

## -parameters
### -param badgeContent
The Uniform Resource Identifier (URI) from which the XML content of the badge update will be retrieved.

### -param requestedInterval
The frequency with which the Uniform Resource Identifier (URI) is polled for new badge content.

## -remarks

## -examples

## -see-also
[StartPeriodicUpdate(Uri, DateTime, PeriodicUpdateRecurrence)](badgeupdater_startperiodicupdate_1369986471.md), [App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Guidelines and checklist for tiles and badges](https://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to clear a badge](https://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to send a glyph or numeric badge in a local notification](https://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to set up periodic notifications for badges](https://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [How to update a badge through push notifications](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Badge XML schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](https://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd)
