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
> Although [Package](package.md) is supported in desktop apps, this member is supported only in UWP app. To access a package's dependencies from a desktop app, use [GetPackageInfo](https://docs.microsoft.com/windows/desktop/api/appmodel/nf-appmodel-getpackageinfo).

## -examples

```csharp
// Get the app package
Package currentPackage = Package.Current;

// Get a list of dependencies for the app package. This includes all resource packages, framework packages, and optional packages.
IReadOnlyList<Package> dependencies = currentPackage.Dependencies;
```

## -see-also
[App package information sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Package)
