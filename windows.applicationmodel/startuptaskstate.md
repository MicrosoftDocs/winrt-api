---
-api-id: T:Windows.ApplicationModel.StartupTaskState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.StartupTaskState : int
-->

# StartupTaskState

## -description
Represents the state (enabled, disabled, or disabled by user) of a startup task.

## -enum-fields
### -field Disabled:0
The task is disabled.

### -field DisabledByUser:1
The task was disabled by the user. It can only be re-enabled by the user.

### -field Enabled:2
The task is enabled.

### -field DisabledByPolicy:3
The task is disabled by the administrator or group policy. Platforms that don't support startup tasks also report **DisabledByPolicy**.

### -field EnabledByPolicy:4
The task is enabled by the administrator or group policy.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | DisabledByPolicy |
| 1803 | 17134 | EnabledByPolicy |

## -examples

## -see-also
