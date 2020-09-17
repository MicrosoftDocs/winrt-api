---
-api-id: M:Windows.Gaming.UI.GameMonitor.RequestPermissionAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<GameMonitoringPermission> GameMonitor.RequestPermissionAsync()
-->

# Windows.Gaming.UI.GameMonitor.RequestPermissionAsync

## -description

Gets the game monitoring permission state of the device.

> [!IMPORTANT]
> As of Windows 10, version 1809 (10.0; Build 17763), this API is removed from the public API surface of Windows.

## -returns

The game monitoring permission state of the device.

## -remarks

If game monitoring is already enabled, the async result returns **GameMonitoringPermission::Allowed**.

If game monitoring is disabled by group policy, the async result returns **GameMonitoringPermission::DeniedBySystem**.

If game monitoring is not enabled, a dialog is displayed asking for consent to enable game monitoring. If the customer accepts, this method returns **GameMonitoringPermission::Allowed**. If not, it returns **GameMonitoringPermission::DeniedByUser**.

The app must have the **protectedApp** and **gameMonitor** capabilities to call this method.  If not, the API returns **E_UNEXPECTED**.

## -see-also

[Windows.Gaming.UI.GameMonitoringPermission](gamemonitoringpermission.md), [App capability declarations](/windows/uwp/packaging/app-capability-declarations)

## -examples

