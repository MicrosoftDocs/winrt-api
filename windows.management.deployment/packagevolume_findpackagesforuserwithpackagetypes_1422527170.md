---
-api-id: M:Windows.Management.Deployment.PackageVolume.FindPackagesForUserWithPackageTypes(System.String,Windows.Management.Deployment.PackageTypes)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVector<Windows.ApplicationModel.Package> FindPackagesForUserWithPackageTypes(System.String userSecurityId, Windows.Management.Deployment.PackageTypes packageTypes)
-->

# Windows.Management.Deployment.PackageVolume.FindPackagesForUserWithPackageTypes

## -description
Gets a collection of info about all installed instances of all [Packages](/uwp/api/windows.applicationmodel.package) for the specified user or users and with the specified package types.

## -parameters
### -param userSecurityId
The security identifier (SID) of the user or users. An empty string denotes the current user. The Everyone SID (S-1-1-0) denotes all users. Any SID other than that of the current user requires administrative privileges.

### -param packageTypes
A bitwise combination of the enumeration values that specifies the types of packages to return.

## -returns
A collection of info about the specified packages.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [FindPackagesForUserWithPackageTypes(String, PackageTypes, String, String)](packagevolume_findpackagesforuserwithpackagetypes_20830398.md), [FindPackagesForUserWithPackageTypes(String, PackageTypes, String)](packagevolume_findpackagesforuserwithpackagetypes_852356674.md)
