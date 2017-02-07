---
-api-id: T:Windows.ApplicationModel.Background.DeviceTriggerResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Background.DeviceTriggerResult : int
-->

# DeviceTriggerResult

## -description
Indicates whether the device background task operation was allowed or denied, and if it was denied specifies the reason.

## -enum-fields
### -field Allowed:0
The device background task was triggered.

### -field DeniedByUser:1
The device background task was denied by the user.

### -field DeniedBySystem:2
The device background task was denied due to system policy.

### -field LowBattery:3
The device background task cannot run because the battery is low.


## -remarks

## -examples

## -see-also