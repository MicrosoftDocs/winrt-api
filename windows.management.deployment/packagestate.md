---
-api-id: T:Windows.Management.Deployment.PackageState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Management.Deployment.PackageState : int
-->

# PackageState

## -description
Represents the state of the package.

## -enum-fields
### -field Normal:0
The package is usable.

### -field LicenseInvalid:1
The license of the package is not valid.

### -field Modified:2
The package payload was modified by an unknown source.

### -field Tampered:3
The package payload was tampered with intentionally.


## -remarks

## -examples

## -see-also
[Packaging apps](https://docs.microsoft.com/windows/uwp/packaging/index), [PackageManager.SetPackageState](packagemanager_setpackagestate_175933383.md)
