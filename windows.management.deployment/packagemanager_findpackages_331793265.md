---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackages(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackages(System.String packageFamilyName)
-->

# Windows.Management.Deployment.PackageManager.FindPackages

## -description
Retrieves information about a specified family of [Packages](/uwp/api/windows.applicationmodel.package) installed across all users.

## -parameters
### -param packageFamilyName
The package family name. This parameter cannot be **null**.

## -returns
If the method succeeds, an enumerable collection of package objects with the same package family name will be returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified package family name are found, this method returns an empty list.

## -remarks
This method requires administrative privileges. Each package in the [IIterable(Package)](../windows.foundation.collections/iiterable_1.md) collection may be installed for the current user or for another user. This method differs from [FindPackages(String packageName, String pulisherName)](packagemanager_findpackages_1597689551.md) method. Here the *packageFamilyName* parameter is a single string, comprised of the package name and package publisher hash.

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [FindPackages()](packagemanager_findpackages_1246181969.md), [FindPackages(String, String)](packagemanager_findpackages_1597689551.md)

## -capabilities
packageQuery
