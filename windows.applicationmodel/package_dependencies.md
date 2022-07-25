---
-api-id: P:Windows.ApplicationModel.Package.Dependencies
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Package> Dependencies { get; }
-->

# Windows.ApplicationModel.Package.Dependencies

## -description

Gets the packages on which the current package depends.

## -property-value

The packages on which the current package depends.

## -remarks

> [!IMPORTANT]
> Although the [Package](package.md) class is supported in an unpackaged process (that is, a process belonging to an app that lacks package identity), the **Package.Current** property is supported only in a *packaged* process (that is, a process belonging to an app that *has* package identity). To access a package's dependencies from an unpackaged process, use [GetPackageInfo](/windows/desktop/api/appmodel/nf-appmodel-getpackageinfo). And for more info about packaging, see [Package a desktop or UWP app in Visual Studio](/windows/msix/package/packaging-uwp-apps).

## -examples

```csharp
// Get the app package
Package currentPackage = Package.Current;

// Get a list of dependencies for the app package. This includes all resource packages, framework packages, and optional packages.
IReadOnlyList<Package> dependencies = currentPackage.Dependencies;
```

## -see-also

[FindRelatedPackages](package_findrelatedpackages_1584363112.md),[App package information sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Package)
