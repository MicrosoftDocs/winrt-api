---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackages(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackages(System.String packageName, System.String packagePublisher)
-->

# Windows.Management.Deployment.PackageManager.FindPackages

## -description
Finds all installed packages with the specified name and publisher.

## -parameters
### -param packageName
The package name. This parameter cannot be **null**.

### -param packagePublisher
The package publisher. This parameter cannot be **null**.

## -returns
If the method succeeds, an enumerable collection of package objects with the same package name and publisher name is returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified name and publisher are found, this method returns an empty list.

## -remarks
This method requires administrative privileges.

## -examples

## -see-also
[Enumerate app packages by name and publisher sample](http://code.msdn.microsoft.com/windowsdesktop/Package-Manager-Inventory-fe747b8a), [FindPackages()](packagemanager_findpackages_1246181969.md), [FindPackages(String)](packagemanager_findpackages_331793265.md)

## -capabilities
packageQuery