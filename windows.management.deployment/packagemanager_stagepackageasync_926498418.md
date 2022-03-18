---
-api-id: M:Windows.Management.Deployment.PackageManager.StagePackageAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Management.Deployment.DeploymentOptions,Windows.Management.Deployment.PackageVolume,Windows.Foundation.Collections.IIterable{System.String},Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DeploymentProgress> PackageManager.StagePackageAsync(Uri packageUri, IIterable<Uri> dependencyPackageUris, DeploymentOptions deploymentOptions, PackageVolume targetVolume, IIterable<String> optionalPackageFamilyNames, IIterable<Uri> externalPackageUris)
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

### -param optionalPackageFamilyNames

Strings that specify the optional package family names from the main bundle to be staged.

### -param externalPackageUris

The source URIs of other packages in the main bundle to be staged.

## -returns

An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)
