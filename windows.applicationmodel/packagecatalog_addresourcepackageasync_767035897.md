---
-api-id: M:Windows.ApplicationModel.PackageCatalog.AddResourcePackageAsync(System.String,System.String,Windows.ApplicationModel.AddResourcePackageOptions)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<PackageInstallProgress> PackageCatalog.AddResourcePackageAsync(String resourcePackageFamilyName, String resourceID, AddResourcePackageOptions options)
-->

# Windows.ApplicationModel.PackageCatalog.AddResourcePackageAsync

## -description
Adds a resource package to an existing app package.

## -parameters
### -param resourcePackageFamilyName
Package family name that uniquely identifies the app's package.

### -param resourceID
The resource ID of the package.

### -param options
Options to specify the behavior when adding a resource package to an app.  

## -returns
The progress report of adding a resource package.

## -remarks

## -see-also

## -examples
```csharp
async void btnInstallFrenchProofingTools_Click(object sender, EventArgs e) 
{ 
    var packageCatalog = PackageCatalog.OpenForCurrentPackage(); 
    string familyName = "Microsoft.Word_8wekyb3d8bbwe"; 
    // The resourceId specified in the AppxManifest.xml should be unique within a PackageFamily
    string resourceId = "FR_ProofingTools"; 

    // Install the resource package and start reporting progress on the current 
    // progressBar in the UI
    var installedPackage = await packageCatalog.AddResourcePackageAsync(familyName, resourceId, AddResourcePackageOptions.RestartApplication) 
    .AsTask<PackageCatalogAddResourcePackageResult, PackageInstallProgress>(new Progress<PackageInstallProgress> 
    (progress => { progressBar.CurrentValue = progress.PercentComplete; })); 
} 
```

