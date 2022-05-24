---
-api-id: M:Windows.UI.Notifications.ToastNotifier.AddToSchedule(Windows.UI.Notifications.ScheduledToastNotification)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void AddToSchedule(Windows.UI.Notifications.ScheduledToastNotification scheduledToast)
-->

# Windows.UI.Notifications.ToastNotifier.AddToSchedule

## -description
Adds a [ScheduledToastNotification](scheduledtoastnotification.md) for later display by Windows.

> [!IMPORTANT]
> This method is only supported in applications which use WinRT as their default application framework.

## -parameters
### -param scheduledToast
The scheduled toast notification, which includes its content and timing instructions.

## -remarks
This method passes the toast notification to the schedule but doesn't specify the time the toast should display. That information is included in the [ScheduledToastNotification](scheduledtoastnotification.md).

Be sure to handle these exceptions when calling **AddToSchedule**:

* **Exception**: `System.Exception: 'Not enough quota is available to process this command. (Exception from HRESULT: 0x80070718)'`
+ **Possible cause**: You've exceeded the maximum allowed number of scheduled notifications.

**Fix**: ToastNotifier.addToSchedule will fail if you attempt to schedule more than 4096 notifications. Reduce your number of scheduled notifications.
+ **Possible cause**: Your notification is scheduled for a time in the past relative to the current system clock time.

**Fix**: Make sure that the scheduled notification time specified in your [ScheduledToastNotification](scheduledtoastnotification.md) is in the future. Examine the system clock time.


## -examples

## -see-also
