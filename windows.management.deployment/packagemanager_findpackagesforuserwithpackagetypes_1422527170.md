---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackagesForUserWithPackageTypes(System.String,Windows.Management.Deployment.PackageTypes)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackagesForUserWithPackageTypes(System.String userSecurityId, Windows.Management.Deployment.PackageTypes packageTypes)
-->

# Windows.Management.Deployment.PackageManager.FindPackagesForUserWithPackageTypes

## -description
Finds packages of specific types that are installed for the specified user.

## -parameters
### -param userSecurityId
The user security identifier (SID). If this parameter is **null**, the packages are retrieved for the current user. Any user SID other than that of current user requires administrative privileges.

### -param packageTypes
A combination of [PackageTypes](packagetypes.md)-typed values that are combined by using a bitwise OR operation. The resulting value specifies the types of packages to be included in the result set.

## -returns
If the method succeeds, an enumerable collection of package objects is returned. Each package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. The *packageTypes* parameter determines the types of packages to return.

## -remarks
This method and its overloads require administrative privileges if the user SID specified is different from the user SID of the calling user. Otherwise, an **AccessDeniedException** is thrown.

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [FindPackagesForUserWithPackageTypes(String, String, String, PackageTypes)](packagemanager_findpackagesforuserwithpackagetypes_1875427314.md), [FindPackagesForUserWithPackageTypes(String, String, PackageTypes)](packagemanager_findpackagesforuserwithpackagetypes_1110730286.md)

## -capabilities
packageQuery
