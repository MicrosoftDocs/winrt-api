---
-api-id: M:Windows.Management.Deployment.PackageManager.RegisterPackageAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Management.Deployment.DeploymentOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> RegisterPackageAsync(Windows.Foundation.Uri manifestUri, Windows.Foundation.Collections.IIterable<Windows.Foundation.Uri> dependencyPackageUris, Windows.Management.Deployment.DeploymentOptions deploymentOptions)
-->

# Windows.Management.Deployment.PackageManager.RegisterPackageAsync

## -description
Registers a [Package](/uwp/api/windows.applicationmodel.package) (the main package) and its dependency packages for the current user, using the specified deployment options.

## -parameters
### -param manifestUri
The Uri of the main package.

### -param dependencyPackageUris
The Uris of the dependency packages.

### -param deploymentOptions
A bitwise combination of enumeration values from the [DeploymentOptions](deploymentoptions.md) enumeration that specify deployment options.

## -returns
An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [RegisterPackageAsync(Uri, IIterable(Uri), DeploymentOptions, PackageVolume)](packagemanager_registerpackageasync_1668904418.md)
