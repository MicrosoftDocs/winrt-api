---
-api-id: P:Windows.ApplicationModel.PackageStatus.Disabled
-api-type: winrt property
---

<!-- Property syntax
public bool Disabled { get; }
-->

# Windows.ApplicationModel.PackageStatus.Disabled

## -description
Indicates whether the package has been disabled.

## -property-value
**TRUE** indicates that the package is disabled; otherwise **FALSE**.

## -remarks
Disabled packages must be enabled before they can be used.

Packages are disabled by using [PackageManager.SetPackageStatus](../windows.management.deployment/packagemanager_setpackagestatus.md) and enabled by using [PackageManager.ClearPackageStatus](../windows.management.deployment/packagemanager_clearpackagestatus.md).

## -examples

## -see-also
