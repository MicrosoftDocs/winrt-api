---
-api-id: T:Windows.System.AutoUpdateTimeZoneStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum AutoUpdateTimeZoneStatus : int 
-->

# Windows.System.AutoUpdateTimeZoneStatus

## -description
The status of the automatic time zone request.

## -enum-fields
### -field TimedOut:1
Request timed out. 
Try again with a longer timeout or prompt the user to select a time zone selection.
You can alternatively include a way for the user to set the time zone at a later time.

### -field Failed:2
The time zone could not be detected due to lack of hardware support, or catastrophic failure.
Avoid calling the [AutoUpdateTimeZoneAsync](timezonesettings_autoupdatetimezoneasync_2027519787.md) method again.
Prompt the user to select a time zone.
You can alternatively include a way for the user to set the time zone at a later time.

### -field Attempted:0
Time zone detection attempted. 
The time zone may still be incorrect.
Confirm time zone selection with the user.
You can alternatively include a way for the user to set the time zone at a later time.


## -remarks

## -see-also
[TimeZoneSettings](timezonesettings.md)

## -examples

