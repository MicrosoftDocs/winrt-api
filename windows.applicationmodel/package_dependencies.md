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
> Although [Package](package.md) is supported in desktop apps, this member is supported only in UWP app. To access a package's dependencies from a desktop app, use [GetPackageInfo](https://msdn.microsoft.com/library/28f45b3b-a61f-44d3-b606-6966ad5866fa).

## -examples

```csharp
// Get the app package
Package currentPackage = Package.Current;

// Get a list of dependencies for the app package. This includes all resource packages, framework packages, and optional packages.
IReadOnlyList<Package> dependencies = currentPackage.Dependencies;
```

## -see-also
[App package information sample](https://code.msdn.microsoft.com/windowsapps/Package-sample-46e239fa), [App package information sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620581)
