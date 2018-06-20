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
Used by [BadgeUpdater.StartPeriodicUpdate](badgeupdater_startperiodicupdate.md), [TileUpdater.StartPeriodicUpdate](tileupdater_startperiodicupdate.md), and [TileUpdater.StartPeriodicUpdateBatch](tileupdater_startperiodicupdatebatch.md).

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
[BadgeUpdater.startPeriodicUpdate](badgeupdater_startperiodicupdate.md), [TileUpdater.startPeriodicUpdate](tileupdater_startperiodicupdate.md), [How to set up periodic notifications for tiles](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [How to set up periodic notifications for badges](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Choose a notification delivery method](http://msdn.microsoft.com/library/fdb43ede-c5f2-493f-952c-55401ec5172b)