---
-api-id: M:Windows.Management.Deployment.PackageVolume.FindPackageForUser(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVector<Windows.ApplicationModel.Package> FindPackageForUser(System.String userSecurityId, System.String packageFullName)
-->

# Windows.Management.Deployment.PackageVolume.FindPackageForUser

## -description
Gets a collection of info about the installed instances of the specified [Package](/uwp/api/windows.applicationmodel.package) for the specified user or users.

## -parameters
### -param userSecurityId
The security identifier (SID) of the user or users. An empty string denotes the current user. The Everyone SID (S-1-1-0) denotes all users. Any SID other than that of the current user requires administrative privileges.

### -param packageFullName
The full name of the package.

## -returns
A collection of info about all installed instances of the specified package for the specified user or users.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)
