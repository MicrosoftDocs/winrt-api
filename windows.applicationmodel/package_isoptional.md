---
-api-id: P:Windows.ApplicationModel.Package.IsOptional
-api-type: winrt property
---

<!-- Property syntax
public bool IsOptional { get; }
-->

# Windows.ApplicationModel.Package.IsOptional

## -description
Indicates whether the package is optional.

## -property-value
Returns **true** if the package is optional; **false** otherwise.

## -remarks
Optional packages are dependent on another package that must be installed first. For example a map application may have optional geographic area packages.

## -examples

```csharp
// Get the main app package
Package currentPackage = Package.Current;

// Get a list of dependencies for the main package. This includes all resource packages, framework packages, and optional packages.
IReadOnlyList<Package> dependencies = currentPackage.Dependencies;

foreach (Package package in dependencies.Where(_ => _.IsOptional))
{
    // Iterate through a list of the optional packages
}
```

## -see-also
