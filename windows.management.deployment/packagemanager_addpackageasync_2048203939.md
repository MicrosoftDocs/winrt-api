---
-api-id: M:Windows.Management.Deployment.PackageManager.AddPackageAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Management.Deployment.DeploymentOptions,Windows.Management.Deployment.PackageVolume)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> AddPackageAsync(Windows.Foundation.Uri packageUri, Windows.Foundation.Collections.IIterable<Windows.Foundation.Uri> dependencyPackageUris, Windows.Management.Deployment.DeploymentOptions deploymentOptions, Windows.Management.Deployment.PackageVolume targetVolume)
-->

# Windows.Management.Deployment.PackageManager.AddPackageAsync

## -description
Adds a [Package](/uwp/api/windows.applicationmodel.package) (the main package) and its dependency packages to the specified volume for the current user, using the specified deployment options.

## -parameters
### -param packageUri
The Uri of the package to add. The URI must follow the file URI scheme (file://) since the only supported URI schemes are local file paths and local network paths.

### -param dependencyPackageUris
The Uris of the dependency packages to add. If there are no dependency packages or if the dependency packages are already registered, this parameter can be null.

### -param deploymentOptions
A bitwise combination of enumeration values from the [DeploymentOptions](deploymentoptions.md) enumeration. **ForceApplicationShutdown** and **None** are the only valid options for this method. Specifying any other option results in an E_INVALIDARG return value.

### -param targetVolume
The volume to which the package is added.

## -returns
The status of the deployment request. The [DeploymentResult](deploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [DeploymentProgress](deploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [Add app package sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Add%20app%20package%20sample), [AddPackageAsync(Uri, IIterable(Uri), DeploymentOptions)](packagemanager_addpackageasync_973949101.md)

## -capabilities
packageManagement
