---
-api-id: M:Windows.Management.Deployment.PackageManager.AddPackageAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Management.Deployment.DeploymentOptions,Windows.Management.Deployment.PackageVolume,Windows.Foundation.Collections.IIterable{System.String},Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DeploymentProgress> PackageManager.AddPackageAsync(Uri packageUri, IIterable<Uri> dependencyPackageUris, DeploymentOptions options, PackageVolume targetVolume, IIterable<String> optionalPackageFamilyNames, IIterable<Uri> packageUrisToInstall, IIterable<Uri> relatedPackageUris)
-->

# Windows.Management.Deployment.PackageManager.AddPackageAsync

## -description
Adds a [Package](/uwp/api/windows.applicationmodel.package) (the main package) and its dependency packages for the current user, using the specified deployment options.

## -parameters
### -param packageUri
The URI of the package to add. The URI must follow the file URI scheme (file://) since the only supported URI schemes are local file paths and local network paths.

### -param dependencyPackageUris
The URIs of framework dependencies to add. If there are no dependency packages or if the dependency packages are already registered, this parameter can be null.

### -param options
The deployment options for the package.

### -param targetVolume
The volume to which the package is added.

### -param optionalPackageFamilyNames
The package family names from the main bundle to be registered.

### -param packageUrisToInstall
The URIs of optional packages to be installed with the main app package. 

### -param relatedPackageUris
URIs of related optional packages to be updated to the same version as the new optional packages.

## -returns
The DeploymentProgress percentage of completion over the entire course of the deployment operation.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)
