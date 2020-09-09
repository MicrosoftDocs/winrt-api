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

> [!IMPORTANT]
> As of Windows 10, version 1809 (10.0; Build 17763), this API is removed from the public API surface of Windows.

## -enum-fields
### -field Allowed:0

The customer has enabled game monitoring through the dialog displayed by [Windows.Gaming.UI.GameMonitor.RequestPermissionAsync](gamemonitor_requestpermissionasync_211338549.md), or game monitoring is already enabled.

### -field DeniedByUser:1

The customer has cancelled the dialog or chosen not to give consent to enable game monitoring.

### -field DeniedBySystem:2

The customer can't give consent for reasons outside their control, such as a group policy.

## -remarks

This class uses **TruePlay**, a system on Windows 10 that helps to combat cheating in PC games. As of Windows 10, version 1809 (10.0; Build 17763), TruePlay is removed from Windows. A game enrolled in TruePlay will run in a protected process, which mitigates a class of common attacks. The TruePlay APIs for UWP allow limited interaction between games and the game monitoring system on Windows 10 PCs.

You can use these WinRT APIs, in tandem with the native APIs in **&lt;gamemonitor.h&gt;**, to work with the game monitoring system. The documentation for TruePlay is no longer published.

## -see-also

[Windows.Gaming.UI.GameMonitor.RequestPermissionAsync](gamemonitor_requestpermissionasync_211338549.md),

## -examples
