---
-api-id: M:Windows.System.Update.SystemUpdateManager.TrySetUserActiveHours(Windows.Foundation.TimeSpan,Windows.Foundation.TimeSpan)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public bool SystemUpdateManager.TrySetUserActiveHours(TimeSpan start, TimeSpan end)
-->

# Windows.System.Update.SystemUpdateManager.TrySetUserActiveHours

## -description
Try to set the user defined Active Hours during which automatic reboots for update will not be allowed.

## -parameters
### -param start
Start time of active hours.

### -param end
End time of active hours.

## -returns
Returns true if active hours were set. Returns false otherwise.

## -remarks
The maximum number of hours allowed between start time and end time can be retrieved using [Windows.System.Update.SystemUpdateManager.UserActiveHoursMax](systemupdatemanager_useractivehoursstart.md)

## -see-also

## -examples

