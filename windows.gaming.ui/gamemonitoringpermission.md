---
-api-id: T:Windows.Gaming.UI.GameMonitoringPermission
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum GameMonitoringPermission : int 
-->

# Windows.Gaming.UI.GameMonitoringPermission

## -description

Indicates the game monitoring permission state of the device.

## -enum-fields
### -field Allowed:0

The customer has enabled game monitoring through the dialog displayed by [Windows.Gaming.UI.GameMonitor.RequestPermissionAsync](gamemonitor_requestpermissionasync_211338549.md), or game monitoring is already enabled.

### -field DeniedByUser:1

The customer has cancelled the dialog or chosen not to give consent to enable game monitoring.

### -field DeniedBySystem:2

The customer can't give consent for reasons outside their control, such as a group policy.

## -remarks

## -see-also

* [Windows.Gaming.UI.GameMonitor.RequestPermissionAsync](gamemonitor_requestpermissionasync_211338549.md)

## -examples

