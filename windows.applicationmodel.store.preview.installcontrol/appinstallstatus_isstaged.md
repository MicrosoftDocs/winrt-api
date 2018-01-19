---
-api-id: P:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallStatus.IsStaged
-api-type: winrt property
---

<!-- Property syntax.
public bool IsStaged { get; }
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallStatus.IsStaged

## -description
Gets a value that indicates whether an app restart is pending.

## -property-value
True if an app restart is pending; otherwise, false.

## -remarks
If this property is **True** and the [InstallState](appinstallstatus_installstate.md) property has the value **Error**, this means that the pending restart is being blocked because the app is currently in use.

## -see-also

## -examples

## -capabilities
runFullTrust
