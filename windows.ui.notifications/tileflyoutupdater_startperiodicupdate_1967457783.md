---
-api-id: M:Windows.UI.Notifications.TileFlyoutUpdater.StartPeriodicUpdate(Windows.Foundation.Uri,Windows.UI.Notifications.PeriodicUpdateRecurrence)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void StartPeriodicUpdate(Windows.Foundation.Uri tileFlyoutContent, Windows.UI.Notifications.PeriodicUpdateRecurrence requestedInterval)
-->

# Windows.UI.Notifications.TileFlyoutUpdater.StartPeriodicUpdate

## -description
Launches a series of [periodic](/previous-versions/windows/apps/jj150587(v=win.10)) updates for a tile flyout (mix view) notification, beginning with an immediate update when the method is called. Update content is retrieved from a specified Uniform Resource Identifier (URI).

## -parameters
### -param tileFlyoutContent
The Uniform Resource Identifier (URI) from which the XML content of the tile flyout update is retrieved.

### -param requestedInterval
The frequency with which the Uniform Resource Identifier (URI) is polled for new content, following the initial update.

## -remarks

## -examples

## -see-also
[StartPeriodicUpdate(Uri, DateTime, PeriodicUpdateRecurrence)](tileflyoutupdater_startperiodicupdate_1369986471.md)