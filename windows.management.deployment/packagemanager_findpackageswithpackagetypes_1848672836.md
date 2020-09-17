---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackagesWithPackageTypes(System.String,Windows.Management.Deployment.PackageTypes)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackagesWithPackageTypes(System.String packageFamilyName, Windows.Management.Deployment.PackageTypes packageTypes)
-->

# Windows.Management.Deployment.PackageManager.FindPackagesWithPackageTypes

## -description
Retrieves information about a specified family of [Packages](/uwp/api/windows.applicationmodel.package) and specific package types that are installed across all users.

## -parameters
### -param packageFamilyName
The package family name. This parameter can't be **null**.

### -param packageTypes
A combination of [PackageTypes](packagetypes.md)-typed values that are combined by using a bitwise OR operation. The resulting value specifies the types of packages to be included in the result set.

## -returns
If the method succeeds, an enumerable collection of package objects with the same package family name is returned. Each package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified package family name are found, this method returns an empty list. The *packageTypes* parameter determines the types of packages to return.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [FindPackagesWithPackageTypes(PackageTypes)](packagemanager_findpackageswithpackagetypes_447761356.md), [FindPackagesWithPackageTypes(String, String, PackageTypes)](packagemanager_findpackageswithpackagetypes_2026827436.md)

## -capabilities
packageQuery
