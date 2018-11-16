---
-api-id: E:Windows.System.Profile.SystemSetupInfo.OutOfBoxExperienceStateChanged
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
static public event EventHandler OutOfBoxExperienceStateChanged<object>
-->

# Windows.System.Profile.SystemSetupInfo.OutOfBoxExperienceStateChanged

## -description
Raised when the current stage in the lifecycle of the Out-of-Box Experience (OOBE) changes.

## -remarks
Subscribers are guaranteed that the event will be raised at least one time, at the time of registration, even if OOBE state never changes. This obviates a window of time where events could otherwise be lost between querying state and registering for state changes.

## -see-also
[SystemOutOfBoxExperienceState](systemoutofboxexperiencestate.md)

## -examples
See [SystemSetupInfo](systemsetupinfo.md).
