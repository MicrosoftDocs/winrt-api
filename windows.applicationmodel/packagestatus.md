---
-api-id: T:Windows.ApplicationModel.PackageStatus
-api-type: winrt class
---

<!-- Class syntax.
public class PackageStatus : Windows.ApplicationModel.IPackageStatus
-->

# Windows.ApplicationModel.PackageStatus

## -description
Provides the status of the package.

## -remarks
Use the [Package.Status](package_status.md) property to get the PackageStatus. The [Package.Status](package_status.md) and all of the properties of the PackageStatus class are read-only, so you cannot change their values. To get updated information about the status of the package, access the [Package.Status](package_status.md) property again to get a new instance of the PackageStatus class.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | IsPartiallyStaged |

## -examples

## -see-also
