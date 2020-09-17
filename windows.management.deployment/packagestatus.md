---
-api-id: T:Windows.Management.Deployment.PackageStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Management.Deployment.PackageStatus : uint
-->

# PackageStatus

## -description
Provides info about the status of a [Package](/uwp/api/windows.applicationmodel.package).

## -enum-fields
### -field OK:0
The package is usable.

### -field LicenseIssue:1
The license of the package is not valid.

### -field Modified:2
The package payload was modified by an unknown source.

### -field Tampered:4
The package payload was tampered with intentionally.

### -field Disabled:8
The package is not available for use. It can still be serviced.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)
