---
-api-id: M:Windows.ApplicationModel.Package.FindRelatedPackages(Windows.ApplicationModel.FindRelatedPackagesOptions)
-api-type: winrt method
---

# Windows.ApplicationModel.Package.FindRelatedPackages(Windows.ApplicationModel.FindRelatedPackagesOptions)

<!--
public System.Collections.Generic.IList<Windows.ApplicationModel.Package> FindRelatedPackages (Windows.ApplicationModel.FindRelatedPackagesOptions options);
-->

## -description

The **FindRelatedPackages** method provides the dependencies and then dependents for a given package as a Package list. The list can be filtered by the type of dependency using the **options** parameter.

## -parameters

### -param options

The [FindRelatedPackageOptions](findrelatedpackagesoptions.md) which defines the search options.

## -returns

Returns an **IList\<Package\>** containing the results of the search.

## -remarks

Any caller (with the **packageQuery** capability or Medium IL, or without if the call is for the current package) can use this API to get the list of dependents (any package which defines a **Dependency** in its manifest) of a given Package. The package can use this data to display its consumers to the user or make servicing decisions based on it. For example, Edge can display all PWAs installed on the device. This API is aware of all registered packages.

## -examples

### Get display names of dependent packages example

For a Host Runtime Provider package, the list of dependent packages is useful to be displayed to the user. In the sample below, the current package gets the list of Display Names of all Host Runtime Consumers dependent on it.

```csharp
static List<string> GetDisplayNamesOfHostedAppsForCurrentPackage()
{
  List<string> displayNames = new();

  // Configure package options to get packages dependent on the app package
  var pkgdependents = PackageRelationship.Dependents;                      
  FindRelatedPackagesOptions hostRuntimeDependents = new(pkgdependents)
  {
      IncludeFrameworks = false,
      IncludeHostRuntimes = true,
      IncludeOptionals = false,
      IncludeResources = false
  };

  // Get a list of packages which are dependent on the app package.
  IList<Package> hostedPackages = Package.Current.FindRelatedPackages(hostRuntimeDependents);

  // Iterate over the dependent packages and get their display names.
  foreach (Package package in hostedPackages)
  {
    displayNames.Add(package.DisplayName);
  }

  return displayNames;
}
```

### Get package dependencies example

A dependent package also can gather more information about its dependencies and handle different cases appropriately. In the sample below, the current package gets the list of packages on which it has a non-optional dependency.

```csharp
static IList<Package> GetNonOptionalDependenciesForCurrentPackage()
{
  // Configure package options to get non-optional dependencies
  var pkgdependents = PackageRelationship.Dependencies;                      
  FindRelatedPackagesOptions nonOptionalDependency = new(pkgdependents)
  {
      IncludeFrameworks = true,
      IncludeHostRuntimes = true,
      IncludeOptionals = false,
      IncludeResources = true
  };

  // Find and return the packages which are non-optional dependencies
  return Package.Current.FindRelatedPackages(nonOptionalDependency);
}
```

## -see-also

[Package.Dependencies](package_dependencies.md),[FindRelatedPackageOptions](findrelatedpackagesoptions.md)
