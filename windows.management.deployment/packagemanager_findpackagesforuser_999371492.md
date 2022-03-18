---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackagesForUser(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackagesForUser(System.String userSecurityId)
-->

# Windows.Management.Deployment.PackageManager.FindPackagesForUser

## -description
Finds all [Packages](/uwp/api/windows.applicationmodel.package) installed for the specified user.

## -parameters
### -param userSecurityId
The user security identifier (SID). If this parameter is **string.Empty**, the packages are retrieved for the current user.

## -returns
If the method succeeds, an enumerable collection of package objects is returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location.

## -remarks
This method and its overloads require administrative privileges if the user security ID specified is different from the user security ID of the calling user. Otherwise, an **AccessDeniedException** is thrown. Similar to the [FindPackages](packagemanager_findpackages_1246181969.md) method, this method and its overloads can be used to enumerate the installed packages for a particular user.

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [Enumerate app packages by user SID sample](https://github.com/microsoft/Windows-classic-samples/tree/master/Samples/PackageManagerFindPackagesByUserSecurityId), [FindPackagesForUser(String, String)](packagemanager_findpackagesforuser_2003648348.md), [FindPackagesForUser(String, String, String)](packagemanager_findpackagesforuser_292215772.md)

## -capabilities
packageQuery
