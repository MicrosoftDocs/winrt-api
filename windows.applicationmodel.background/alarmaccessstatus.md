---
-api-id: T:Windows.ApplicationModel.Background.AlarmAccessStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Background.AlarmAccessStatus : int
-->

# AlarmAccessStatus

## -description
Indicates whether the user has given permission for the app to set alarms.

## -enum-fields
### -field Unspecified:0
The user has not responded to a permission request for the app to set alarms.

### -field AllowedWithWakeupCapability:1
The user has given permission for the app to set alarms, and alarms can wake up the computer from standby.

### -field AllowedWithoutWakeupCapability:2
The user has given permission for the app to set alarms, but the alarms cannot wake up the computer from standby.

### -field Denied:3
The user has denied permission for the app to set alarms.


## -remarks

## -examples

## -see-also