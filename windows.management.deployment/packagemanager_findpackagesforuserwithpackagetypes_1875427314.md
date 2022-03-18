---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackagesForUserWithPackageTypes(System.String,System.String,System.String,Windows.Management.Deployment.PackageTypes)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackagesForUserWithPackageTypes(System.String userSecurityId, System.String packageName, System.String packagePublisher, Windows.Management.Deployment.PackageTypes packageTypes)
-->

# Windows.Management.Deployment.PackageManager.FindPackagesForUserWithPackageTypes

## -description
Retrieves information about [Packages](/uwp/api/windows.applicationmodel.package) of specific types with the specified package name and publisher name, installed for a specific user.

## -parameters
### -param userSecurityId
The user security identifier (SID). If this parameter is **null**, the packages are retrieved for the current user. Any user SID other than that of current user requires administrative privileges.

### -param packageName
The package name. This parameter can't be **null**.

### -param packagePublisher
The package publisher. This parameter can't be **null**.

### -param packageTypes
A combination of [PackageTypes](packagetypes.md)-typed values that are combined by using a bitwise OR operation. The resulting value specifies the types of packages to be included in the result set.

## -returns
If the method succeeds, an enumerable collection of package objects is returned. Each package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified package publisher and family name are found, this method returns an empty list. The *packageTypes* parameter determines the types of packages to return.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [FindPackagesForUserWithPackageTypes(String, PackageTypes)](packagemanager_findpackagesforuserwithpackagetypes_1422527170.md), [FindPackagesForUserWithPackageTypes(String, String, PackageTypes)](packagemanager_findpackagesforuserwithpackagetypes_1110730286.md)

## -capabilities
packageQuery
