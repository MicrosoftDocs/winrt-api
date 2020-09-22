---
-api-id: M:Windows.Management.Deployment.PackageManager.UpdatePackageAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Management.Deployment.DeploymentOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> UpdatePackageAsync(Windows.Foundation.Uri packageUri, Windows.Foundation.Collections.IIterable<Windows.Foundation.Uri> dependencyPackageUris, Windows.Management.Deployment.DeploymentOptions deploymentOptions)
-->

# Windows.Management.Deployment.PackageManager.UpdatePackageAsync

## -description
Updates an installed [Package](/uwp/api/windows.applicationmodel.package) or its dependency packages for the current user.

## -parameters
### -param packageUri
The source URI of the main package.

### -param dependencyPackageUris
The source URIs of the dependency packages.

### -param deploymentOptions
One of the permitted enumeration values. **ForceApplicationShutdown** and **None** are the only valid options for this method and specifying any other deployment option results in an E_INVALIDARG return value.

## -returns
The status of the deployment request. The [DeploymentResult](deploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [DeploymentProgress](deploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks
An installed package can be updated only if the version of the update package is higher than that of the installed package. If no previous version of the package exists, the operation fails.

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)

## -capabilities
packageManagement
