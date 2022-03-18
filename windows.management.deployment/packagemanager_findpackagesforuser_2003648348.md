---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackagesForUser(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackagesForUser(System.String userSecurityId, System.String packageFamilyName)
-->

# Windows.Management.Deployment.PackageManager.FindPackagesForUser

## -description
Retrieves information about a specified family of [Packages](/uwp/api/windows.applicationmodel.package) installed for a specific user.

## -parameters
### -param userSecurityId
The user security identifier (SID). If this parameter is String.Empty, the packages are retrieved for the current user.

### -param packageFamilyName
The family name of packages to find. This parameter cannot be **null**.

## -returns
If the method succeeds, an enumerable collection of package objects is returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified package family name are found, this method returns an empty list.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [FindPackagesForUser(String)](packagemanager_findpackagesforuser_999371492.md), [FindPackagesForUser(String, String, String)](packagemanager_findpackagesforuser_292215772.md)

## -capabilities
packageQuery
