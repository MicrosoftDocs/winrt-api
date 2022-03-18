---
-api-id: M:Windows.Management.Deployment.PackageManager.StagePackageAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Management.Deployment.DeploymentOptions,Windows.Management.Deployment.PackageVolume)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> StagePackageAsync(Windows.Foundation.Uri packageUri, Windows.Foundation.Collections.IIterable<Windows.Foundation.Uri> dependencyPackageUris, Windows.Management.Deployment.DeploymentOptions deploymentOptions, Windows.Management.Deployment.PackageVolume targetVolume)
-->

# Windows.Management.Deployment.PackageManager.StagePackageAsync

## -description
Stages a [Package](/uwp/api/windows.applicationmodel.package) to the system without registering it.

## -parameters
### -param packageUri
The source URI of the main package.

### -param dependencyPackageUris
The source URIs of the dependency packages. If there are no dependency packages or dependency packages are already staged, this parameter can be null.

### -param deploymentOptions
A bitwise combination of enumeration values from the [DeploymentOptions](deploymentoptions.md) enumeration. The resulting value specifies the package deployment options.

### -param targetVolume
The target volume on which to stage the package.

## -returns
An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [StagePackageAsync(Uri, IIterable(Uri))](packagemanager_stagepackageasync_1881962702.md), [StagePackageAsync(Uri, IIterable(Uri), DeploymentOptions)](packagemanager_stagepackageasync_1546392990.md)
