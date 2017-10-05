---
-api-id: T:Windows.ApplicationModel.UserActivities.UserActivityState
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum UserActivityState : int {
	New = 0
	Published = 1
}
-->

# Windows.ApplicationModel.UserActivities.UserActivityState

## -description

Defines the states of a [UserActivity](useractivity.md).

## -enum-fields

### -field Published:1

The **UserActivity** has been published on this (or another) device.

### -field New:0

The **UserActivity** has not yet been published.

## -remarks

Whenever the app modifies a property of the [UserActivity](useractivity.md), you must call [UserActivity.SaveAsync()](useractivity_saveasync_2143735121.md) to publish the change and push the updated activity to other devices.

## -see-also
[UserActivity.SaveAsync()](useractivity_saveasync_2143735121.md)

## -examples
