---
-api-id: T:Windows.Management.Deployment.PackageInstallState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Management.Deployment.PackageInstallState : int
-->

# PackageInstallState

## -description
Represents the install state of the [Package](https://docs.microsoft.com/uwp/api/windows.applicationmodel.package).

## -enum-fields
### -field NotInstalled:0
The package has not been installed.

### -field Staged:1
The package has been downloaded.

### -field Installed:2
The package is ready for use.

### -field Paused:6
The installation of the package has been paused.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | Paused |

## -examples

## -see-also

- [Package](https://docs.microsoft.com/uwp/api/windows.applicationmodel.package)
- [Packaging apps](https://docs.microsoft.com/windows/uwp/packaging/index)
- [PackageUserInformation.InstallState](packageuserinformation_installstate.md)
