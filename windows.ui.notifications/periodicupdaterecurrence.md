---
-api-id: T:Windows.UI.Notifications.PeriodicUpdateRecurrence
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Notifications.PeriodicUpdateRecurrence : int
-->

# PeriodicUpdateRecurrence

## -description
Specifies the time period for subsequent polls of the tile or badge data source for new content.
Used by [BadgeUpdater.StartPeriodicUpdate](badgeupdater_startperiodicupdate_1369986471.md), [TileUpdater.StartPeriodicUpdate](tileupdater_startperiodicupdate_1369986471.md), and [TileUpdater.StartPeriodicUpdateBatch](tileupdater_startperiodicupdatebatch_1331011351.md).

## -enum-fields
### -field HalfHour:0
Poll every half an hour.

### -field Hour:1
Poll every hour.

### -field SixHours:2
Poll every 6 hours.

### -field TwelveHours:3
Poll every 12 hours.

### -field Daily:4
Poll once a day.


## -remarks
Windows can delay the polling of your URL by up to 15 minutes if necessary to optimize power and performance.

## -examples

## -see-also
[BadgeUpdater.startPeriodicUpdate](badgeupdater_startperiodicupdate_1369986471.md), [TileUpdater.startPeriodicUpdate](tileupdater_startperiodicupdate_1369986471.md), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [How to set up periodic notifications for badges](/previous-versions/windows/apps/hh761476(v=win.10)), [Choose a notification delivery method](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)
