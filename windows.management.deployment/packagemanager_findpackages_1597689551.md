---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackages(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackages(System.String packageName, System.String packagePublisher)
-->

# Windows.Management.Deployment.PackageManager.FindPackages

## -description
Finds all installed [Packages](/uwp/api/windows.applicationmodel.package) with the specified name and publisher.

## -parameters
### -param packageName
The package name. This parameter cannot be **null**.

### -param packagePublisher
The package publisher. This parameter cannot be **null**.

## -returns
If the method succeeds, an enumerable collection of package objects with the same package name and publisher name is returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified name and publisher are found, this method returns an empty list.

## -remarks
This method requires administrative privileges. This method returns packages installed for **all users** on the device, not just the current user. To retrieve packages for a specific user only, use [FindPackagesForUser](packagemanager_findpackagesforuser_292215772.md).

> [!NOTE]
> Parameter formats matter — passing the wrong format silently returns an empty collection:
>
> - The *packageName* parameter corresponds to [Package.Id.Name](/uwp/api/windows.applicationmodel.packageid.name) — for example, `Microsoft.WindowsCalculator`. This is **not** [Package.Id.FullName](/uwp/api/windows.applicationmodel.packageid.fullname) (which includes version and architecture).
> - The *packagePublisher* parameter corresponds to [Package.Id.Publisher](/uwp/api/windows.applicationmodel.packageid.publisher) — the full X.500 distinguished name string, for example, `CN=Microsoft Corporation, O=Microsoft Corporation, L=Redmond, S=Washington, C=US`. This is **not** [Package.Id.PublisherId](/uwp/api/windows.applicationmodel.packageid.publisherid) (the hashed short form).
>
> Use [FindPackages(String)](packagemanager_findpackages_331793265.md) with [Package.Id.FamilyName](/uwp/api/windows.applicationmodel.packageid.familyname) as a simpler and less error-prone alternative when you don't need to match on publisher separately.

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [Enumerate app packages by name and publisher sample](https://github.com/microsoft/Windows-classic-samples/tree/master/Samples/PackageManagerFindPackagesByNameAndPublisher), [FindPackages](packagemanager_findpackages_1246181969.md), [FindPackages(String)](packagemanager_findpackages_331793265.md)

## -capabilities
packageQuery
