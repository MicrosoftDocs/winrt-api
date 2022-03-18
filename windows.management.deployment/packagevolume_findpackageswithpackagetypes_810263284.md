---
-api-id: M:Windows.Management.Deployment.PackageVolume.FindPackagesWithPackageTypes(Windows.Management.Deployment.PackageTypes,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVector<Windows.ApplicationModel.Package> FindPackagesWithPackageTypes(Windows.Management.Deployment.PackageTypes packageTypes, System.String packageName, System.String packagePublisher)
-->

# Windows.Management.Deployment.PackageVolume.FindPackagesWithPackageTypes

## -description
Gets a collection of info about all installed instances of the specified [Packages](/uwp/api/windows.applicationmodel.package) from the specified publisher with the specified package types for all registered users.

## -parameters
### -param packageTypes
A bitwise combination of the enumeration values that specifies the types of packages to return.

### -param packageName
The full name of the package.

### -param packagePublisher
The publisher of the package.

## -returns
A collection of info about the specified packages.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [FindPackagesWithPackageTypes(PackageTypes)](packagevolume_findpackageswithpackagetypes_447761356.md), [FindPackagesWithPackageTypes(PackageTypes, String)](packagevolume_findpackageswithpackagetypes_1447839348.md)
