---
-api-id: M:Windows.Management.Deployment.PackageVolume.FindPackagesForUser(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVector<Windows.ApplicationModel.Package> FindPackagesForUser(System.String userSecurityId, System.String packageFamilyName)
-->

# Windows.Management.Deployment.PackageVolume.FindPackagesForUser

## -description
Gets a collection of info about all installed instances of the specified [Package](https://docs.microsoft.com/uwp/api/windows.applicationmodel.package) for the specified user or users.

## -parameters
### -param userSecurityId
The security identifier (SID) of the user or users. An empty string denotes the current user. The Everyone SID (S-1-1-0) denotes all users. Any SID other than that of the current user requires administrative privileges.

### -param packageFamilyName
The package family name.

## -returns
A collection of info about the specified packages.

## -remarks

## -examples

## -see-also

- [Package](https://docs.microsoft.com/uwp/api/windows.applicationmodel.package)
- [FindPackagesForUser(String)](packagevolume_findpackagesforuser_999371492.md), [FindPackagesForUser(String, String, String)](packagevolume_findpackagesforuser_292215772.md)
