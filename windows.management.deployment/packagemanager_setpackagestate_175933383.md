---
-api-id: M:Windows.Management.Deployment.PackageManager.SetPackageState(System.String,Windows.Management.Deployment.PackageState)
-api-type: winrt method
---

<!-- Method syntax
public void SetPackageState(System.String packageFullName, Windows.Management.Deployment.PackageState packageState)
-->

# Windows.Management.Deployment.PackageManager.SetPackageState

## -description
Sets the state of a [Package](/uwp/api/windows.applicationmodel.package), for example, to usable, tampered with, and so on.

## -parameters
### -param packageFullName
The full name of the package.

### -param packageState
One of the enumeration values.

## -remarks
When SetPackageState is used with a [PackageState](packagestate.md) of **Tampered**, all processes that are part of the package are terminated. If the package is a framework package, all processes for all packages that depend on the framework are also terminated. This method requires administrative privileges
<!--[jjacks - WinBlue bug 492738 directed to remove because the info is not to be public] and the package state is stored under HKLM\Software\\Microsoft\\Windows\\CurrentVersion\\AppModel\\StateChange\\PackageList. It can be set for one user or across all users.-->
and alters the status for all users.

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)

## -capabilities
packageManagement
