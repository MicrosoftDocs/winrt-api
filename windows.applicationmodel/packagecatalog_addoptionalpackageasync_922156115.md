---
-api-id: M:Windows.ApplicationModel.PackageCatalog.AddOptionalPackageAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<PackageCatalogAddOptionalPackageResult> PackageCatalog.AddOptionalPackageAsync(String optionalPackageFamilyName)
-->

# Windows.ApplicationModel.PackageCatalog.AddOptionalPackageAsync


## -description

Adds an optional package to the package catalog.

## -parameters

### -param optionalPackageFamilyName

The package family of the optional package to add to the catalog.

## -returns

The result of starting the asynchronous operation to add the package.

## -remarks

This method only works for optional packages in a related set.

## -examples

The example below installs an optional app package based on its app package family name.

```csharp
var packageCatalog = PackageCatalog.OpenForCurrentPackage();
string familyName = "<Your app package family name>";
Package installedPackage = await packageCatalog.AddOptionalPackageAsync(familyName);
```

## -see-also

