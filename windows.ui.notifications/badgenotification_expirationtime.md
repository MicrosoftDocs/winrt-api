---
-api-id: P:Windows.UI.Notifications.BadgeNotification.ExpirationTime
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.DateTime> ExpirationTime { get;  set; }
-->

# Windows.UI.Notifications.BadgeNotification.ExpirationTime

## -description
Gets or sets the time that Windows will remove the badge from the tile. By default, local badge notifications do not expire and push, periodic, and scheduled badge notifications expire after three days. It is a best practice to explicitly set an expiration time to avoid stale content.

## -property-value
The date and time that the notification should be removed.

## -remarks

## -examples

## -see-also
[App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Guidelines and checklist for tiles and badges](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to clear a badge](https://docs.microsoft.com/previous-versions/windows/apps/hh700418(v=win.10)), [How to send a glyph or numeric badge in a local notification](https://docs.microsoft.com/previous-versions/windows/apps/hh700418(v=win.10)), [How to set up periodic notifications for badges](https://docs.microsoft.com/previous-versions/windows/apps/hh761476(v=win.10)), [How to update a badge through push notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Badge XML schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779719(v=win.10))
