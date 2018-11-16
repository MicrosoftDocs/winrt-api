---
-api-id: T:Windows.System.Profile.SystemOutOfBoxExperienceState
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum SystemOutOfBoxExperienceState : int 
-->

# Windows.System.Profile.SystemOutOfBoxExperienceState

## -description
Defines constants that specify the current stage in the lifecycle of the Out-of-Box Experience (OOBE).

## -enum-fields
### -field Completed:2
Indicates that the OOBE has completed on this device.

### -field InProgress:1
Indicates that the OOBE has started and is in progress on this device.

### -field NotStarted:0
Indicates that the OOBE has not yet started on this device. This is the value reported for devices that have no OOBE.

## -remarks
The Out-of-Box Experience (OOBE) is the flow that occurs the first time the user turns on a Windows 10 device. The OOBE obtains acceptance of the EULA, sets the system default locale, and helps set up the initial user account.

## -see-also

## -examples
See [SystemSetupInfo](systemsetupinfo.md).
