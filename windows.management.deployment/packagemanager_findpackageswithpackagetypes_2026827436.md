---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackagesWithPackageTypes(System.String,System.String,Windows.Management.Deployment.PackageTypes)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackagesWithPackageTypes(System.String packageName, System.String packagePublisher, Windows.Management.Deployment.PackageTypes packageTypes)
-->

# Windows.Management.Deployment.PackageManager.FindPackagesWithPackageTypes

## -description
Finds all installed [Packages](/uwp/api/windows.applicationmodel.package) of specific types with the specified name and publisher.

## -parameters
### -param packageName
The package name. This parameter can't be **null**.

### -param packagePublisher
The package publisher. This parameter can't be **null**.

### -param packageTypes
A combination of [PackageTypes](packagetypes.md)-typed values that are combined by using a bitwise OR operation. The resulting value specifies the types of packages to be included in the result set.

## -returns
If the method succeeds, an enumerable collection of package objects with the same package name and publisher name is returned. Each package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified name and publisher are found, this method returns an empty list. The *packageTypes* parameter determines the types of packages to return.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [FindPackagesWithPackageTypes(PackageTypes)](packagemanager_findpackageswithpackagetypes_447761356.md), [FindPackagesWithPackageTypes(String, PackageTypes)](packagemanager_findpackageswithpackagetypes_1848672836.md)

## -capabilities
packageQuery
