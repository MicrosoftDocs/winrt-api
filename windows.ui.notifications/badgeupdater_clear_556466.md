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
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Guidelines and checklist for tiles and badges](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to clear a badge](/previous-versions/windows/apps/hh700418(v=win.10)), [How to send a glyph or numeric badge in a local notification](/previous-versions/windows/apps/hh700418(v=win.10)), [How to set up periodic notifications for badges](/previous-versions/windows/apps/hh761476(v=win.10)), [How to update a badge through push notifications](/previous-versions/windows/apps/hh465450(v=win.10)), [Badge XML schema](/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](/previous-versions/windows/apps/hh779719(v=win.10))
