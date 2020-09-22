---
-api-id: M:Windows.Management.Deployment.PackageManager.RequestAddPackageAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Management.Deployment.DeploymentOptions,Windows.Management.Deployment.PackageVolume,Windows.Foundation.Collections.IIterable{System.String},Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DeploymentProgress> PackageManager.RequestAddPackageAsync(Uri packageUri, IIterable<Uri> dependencyPackageUris, DeploymentOptions deploymentOptions, PackageVolume targetVolume, IIterable<String> optionalPackageFamilyNames, IIterable<Uri> relatedPackageUris, IIterable<Uri> packageUrisToInstall)
-->

# Windows.Management.Deployment.PackageManager.RequestAddPackageAsync

## -description
Requests a SmartScreen check and user verification before installing the app [Package(s)](/uwp/api/windows.applicationmodel.package). This method provides a **packageUrisToInstall** overload to specify external packages to be staged and registered.

## -parameters
### -param packageUri
The URI of the package to add. The URI must follow the file URI scheme (file://) since the only supported URI schemes are local file paths and local network paths.

### -param dependencyPackageUris
The URIs of the dependency packages to add. If there are no dependency packages or if the dependency packages are already registered, this parameter can be null.

### -param deploymentOptions
A valid enumeration value from the [DeploymentOptions](deploymentoptions.md) enumeration.

### -param targetVolume
The volume that the package is installed to.

### -param optionalPackageFamilyNames
Strings that specify the optional package family names from the main bundle to be staged and registered.

### -param relatedPackageUris
The URIs of additional packages in the main bundle that should be staged and registered.

### -param packageUrisToInstall
A list of other package URIs to be staged and registered. This can contain paths to external packages to be installed.

## -returns
The progress and result of adding the app package.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)
