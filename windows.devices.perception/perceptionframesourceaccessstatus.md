---
-api-id: T:Windows.Devices.Perception.PerceptionFrameSourceAccessStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Perception.PerceptionFrameSourceAccessStatus : int
-->

# PerceptionFrameSourceAccessStatus

## -description
Indicates the access status an app is allowed for a particular type of frame source.

## -enum-fields
### -field Unspecified:0
Access status is not specified.

### -field Allowed:1
The app is allowed to access the type of perception frame source it requested.

### -field DeniedByUser:2
The app is not allowed to access the type of perception frame source it requested because the user denied the app access to camera devices.

### -field DeniedBySystem:3
The app is not allowed to access the type of perception frame source it requested because system access to camera devices is denied. This usually occurs when the user denies all apps access to camera devices in the system privacy settings.


## -remarks

## -examples

## -see-also