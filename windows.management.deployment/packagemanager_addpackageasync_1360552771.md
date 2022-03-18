---
-api-id: M:Windows.Management.Deployment.PackageManager.AddPackageAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Management.Deployment.DeploymentOptions,Windows.Management.Deployment.PackageVolume,Windows.Foundation.Collections.IIterable{System.String},Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DeploymentProgress> PackageManager.AddPackageAsync(Uri packageUri, IIterable<Uri> dependencyPackageUris, DeploymentOptions deploymentOptions, PackageVolume targetVolume, IIterable<String> optionalPackageFamilyNames, IIterable<Uri> externalPackageUris)
-->

# Windows.Management.Deployment.PackageManager.AddPackageAsync


## -description

Adds a [Package](/uwp/api/windows.applicationmodel.package) and its dependency packages to the specified volume for the current user, using the specified deployment options.

## -parameters

### -param packageUri

The Uri of the source package to add. The URI must follow the file URI scheme (file://) since the only supported URI schemes are local file paths and local network paths.

### -param dependencyPackageUris

The Uris of the dependency packages to add. If there are no dependency packages or if the dependency packages are already registered, this parameter can be null.

### -param deploymentOptions

A bitwise combination of enumeration values from the [DeploymentOptions](deploymentoptions.md) enumeration. **ForceApplicationShutdown** and **None** are the only valid options for this method. Specifying any other option results in an E_INVALIDARG return value.

### -param targetVolume

The volume that the package is added to.

### -param optionalPackageFamilyNames

The package family names from the main bundle to be registered.

### -param externalPackageUris

The URIs of the other packages in the main bundle to be registered.

## -returns

The DeploymentProgress percentage of completion over the entire course of the deployment operation.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [DeploymentOptions](deploymentoptions.md)

## -examples

