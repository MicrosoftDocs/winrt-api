---
-api-id: M:Windows.ApplicationModel.PackageCatalog.RemoveOptionalPackagesAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<PackageCatalogRemoveOptionalPackagesResult> PackageCatalog.RemoveOptionalPackagesAsync(IIterable<String> optionalPackageFamilyNames)
-->

# Windows.ApplicationModel.PackageCatalog.RemoveOptionalPackagesAsync

## -description
Removes installed optional app packages from the user account. 

## -parameters

### -param optionalPackageFamilyNames
A list of optional package family name strings.

## -returns
The result of removing the optional package in the form of: [PackageCatalogRemoveOptionalPackagesResult](/uwp/api/windows.applicationmodel.packagecatalogremoveoptionalpackagesresult).

## -remarks
A package family name can be found in the FamilyName property of the [PackageId](/uwp/api/windows.applicationmodel.packageid).

## -see-also

## -examples
This sample demonstrates removing all of the optional packages from a main app package.

```csharp
public async void RemoveOptionalPackages() 
{ 
    // Create a list of the optional package family names
    List<string> optionalPackageList = new List<string>(); 
    foreach (var package in Windows.ApplicationModel.Package.Current.Dependencies) 
    { 
        if (package.IsOptional) 
        { 
            optionalPackageList.Add(package.Id.FamilyName); 
        } 
    } 

    // Remove the optional packages from the list    
    PackageCatalog catalog = Windows.ApplicationModel.PackageCatalog.OpenForCurrentPackage(); 
    var removalResult = await catalog.RemoveOptionalPackagesAsync(optionalPackageList); 
    if (removalResult.ExtendedError != null) 
    { 
        throw removalResult.ExtendedError; 
    } 
}
```

