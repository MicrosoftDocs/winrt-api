---
-api-id: M:Windows.UI.Notifications.BadgeUpdater.StartPeriodicUpdate(Windows.Foundation.Uri,Windows.Foundation.DateTime,Windows.UI.Notifications.PeriodicUpdateRecurrence)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void StartPeriodicUpdate(Windows.Foundation.Uri badgeContent, Windows.Foundation.DateTime startTime, Windows.UI.Notifications.PeriodicUpdateRecurrence requestedInterval)
-->

# Windows.UI.Notifications.BadgeUpdater.StartPeriodicUpdate

## -description
Begins a series of timed updates for the badge from a web resource that the updater is bound to. Updates begin at a specified time. Note that only web resources (http/https) are allowed in a periodic update.

## -parameters
### -param badgeContent
The Uniform Resource Identifier (URI) from which the XML content of the badge update will be retrieved.

### -param startTime
The time at which the Uniform Resource Identifier (URI) should first be polled for new badge content.

### -param requestedInterval
The frequency with which the Uniform Resource Identifier (URI) is polled for new badge content, following the initial update at *startTime*.

## -remarks

## -examples

## -see-also
[StartPeriodicUpdate(Uri, PeriodicUpdateRecurrence)](badgeupdater_startperiodicupdate_1967457783.md), [App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Guidelines and checklist for tiles and badges](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to clear a badge](https://docs.microsoft.com/previous-versions/windows/apps/hh700418(v=win.10)), [How to send a glyph or numeric badge in a local notification](https://docs.microsoft.com/previous-versions/windows/apps/hh700418(v=win.10)), [How to set up periodic notifications for badges](https://docs.microsoft.com/previous-versions/windows/apps/hh761476(v=win.10)), [How to update a badge through push notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Badge XML schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779719(v=win.10))
