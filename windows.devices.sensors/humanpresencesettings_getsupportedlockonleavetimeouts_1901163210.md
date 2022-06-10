---
-api-id: M:Windows.Devices.Sensors.HumanPresenceSettings.GetSupportedLockOnLeaveTimeouts
-api-type: winrt method
---

# Windows.Devices.Sensors.HumanPresenceSettings.GetSupportedLockOnLeaveTimeouts

<!--
public static System.Collections.Generic.IReadOnlyList<System.TimeSpan> GetSupportedLockOnLeaveTimeouts ();
-->

## -description

Retrieves the collection of intervals (from the system settings) used to specify how much time should pass before locking the PC after a user is no longer detected.

## -returns

The collection of intervals (from the system settings) used to specify how much time should pass before locking the PC after a user is no longer detected.

## -remarks

Use [LockOnLeaveTimeout](humanpresencesettings_lockonleavetimeout.md) to get the currently selected interval.

## -see-also

[HumanPresenceFeatures.IsLockOnLeaveSupported](humanpresencefeatures_islockonleavesupported.md), [IsLockOnLeaveEnabled](humanpresencesettings_islockonleaveenabled.md)

## -examples
