---
-api-id: M:Windows.Management.Deployment.PackageManager.StagePackageAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Management.Deployment.DeploymentOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> StagePackageAsync(Windows.Foundation.Uri packageUri, Windows.Foundation.Collections.IIterable<Windows.Foundation.Uri> dependencyPackageUris, Windows.Management.Deployment.DeploymentOptions deploymentOptions)
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
A combination of [DeploymentOptions](deploymentoptions.md)-typed values that are combined by using a bitwise OR operation. The resulting value specifies the package deployment options.

## -returns
The status of the deployment request. The [DeploymentResult](deploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [DeploymentProgress](deploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [StagePackageAsync(Uri, IIterable(Uri))](packagemanager_stagepackageasync_1881962702.md)
