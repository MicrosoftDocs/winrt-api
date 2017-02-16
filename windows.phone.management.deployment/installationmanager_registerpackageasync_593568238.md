---
-api-id: M:Windows.Phone.Management.Deployment.InstallationManager.RegisterPackageAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Management.Deployment.DeploymentOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Phone.Management.Deployment.PackageInstallResult, uint> RegisterPackageAsync(Windows.Foundation.Uri manifestUri, Windows.Foundation.Collections.IIterable<Windows.Foundation.Uri> dependencyPackageUris, Windows.Management.Deployment.DeploymentOptions deploymentOptions)
-->

# Windows.Phone.Management.Deployment.InstallationManager.RegisterPackageAsync

## -description
Registers a package (the main package) and its dependency packages for the current user.

## -parameters
### -param manifestUri
The path to the package manifest of the main package.

### -param dependencyPackageUris
The paths to the dependency packages. If there are no dependency packages or if the dependency packages are already registered, this parameter can be null. When [DeploymentOptions](../windows.management.deployment/deploymentoptions.md) is set to **DevelopmentMode**, leave this parameter null.

### -param deploymentOptions
Options that modify the deployment operation.

## -returns
An object that represents the asynchronous deployment operation and includes progress updates.

## -remarks

## -examples

## -see-also
