---
-api-id: M:Windows.Management.Deployment.PackageManager.StagePackageAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Management.Deployment.DeploymentOptions,Windows.Management.Deployment.PackageVolume,Windows.Foundation.Collections.IIterable{System.String},Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DeploymentProgress> PackageManager.StagePackageAsync(Uri packageUri, IIterable<Uri> dependencyPackageUris, DeploymentOptions options, PackageVolume targetVolume, IIterable<String> optionalPackageFamilyNames, IIterable<Uri> packageUrisToInstall, IIterable<Uri> relatedPackageUris)
-->

# Windows.Management.Deployment.PackageManager.StagePackageAsync

## -description
Stages a [Package](/uwp/api/windows.applicationmodel.package) to the system without registering it.

## -parameters
### -param packageUri
The source URI of the main package.

### -param dependencyPackageUris
The URIs of framework dependencies to add. If there are no dependency packages or if the dependency packages are already registered, this parameter can be null.

### -param options
The deployment options for the package.

### -param targetVolume
The volume to which the package is added.

### -param optionalPackageFamilyNames
The package family names from the main bundle to be staged.

### -param packageUrisToInstall

### -param relatedPackageUris
The URIs of additional packages in the main bundle that should be staged.

## -returns
The status of the deployment request. The [DeploymentResult](deploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [DeploymentProgress](deploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)
