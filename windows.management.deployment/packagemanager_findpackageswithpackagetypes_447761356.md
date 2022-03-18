---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackagesWithPackageTypes(Windows.Management.Deployment.PackageTypes)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackagesWithPackageTypes(Windows.Management.Deployment.PackageTypes packageTypes)
-->

# Windows.Management.Deployment.PackageManager.FindPackagesWithPackageTypes

## -description
Retrieves information about specific [Package](/uwp/api/windows.applicationmodel.package) types that are installed across all users.

## -parameters
### -param packageTypes
A combination of [PackageTypes](packagetypes.md)-typed values that are combined by using a bitwise OR operation. The resulting value specifies the types of packages to be included in the result set.

## -returns
If the method succeeds, an enumerable collection of package objects is returned. Each package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. The *packageTypes* parameter determines the types of packages to return.

## -remarks
This method and its overloads require administrative privileges.

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [FindPackagesWithPackageTypes(String, String, PackageTypes)](packagemanager_findpackageswithpackagetypes_2026827436.md), [FindPackagesWithPackageTypes(String, PackageTypes)](packagemanager_findpackageswithpackagetypes_1848672836.md)

## -capabilities
packageQuery
