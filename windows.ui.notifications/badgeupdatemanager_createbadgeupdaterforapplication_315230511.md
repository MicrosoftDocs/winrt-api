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
[CreateBadgeUpdaterForApplication](badgeupdatemanager_createbadgeupdaterforapplication_1263267855.md), [App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Guidelines and checklist for tiles and badges](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to clear a badge](/previous-versions/windows/apps/hh700418(v=win.10)), [How to send a glyph or numeric badge in a local notification](/previous-versions/windows/apps/hh700418(v=win.10)), [How to set up periodic notifications for badges](/previous-versions/windows/apps/hh761476(v=win.10)), [How to update a badge through push notifications](/previous-versions/windows/apps/hh465450(v=win.10)), [Badge XML schema](/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](/previous-versions/windows/apps/hh779719(v=win.10))
