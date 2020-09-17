---
-api-id: M:Windows.Management.Deployment.PackageManager.RegisterPackageByFamilyNameAsync(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Management.Deployment.DeploymentOptions,Windows.Management.Deployment.PackageVolume,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DeploymentProgress> PackageManager.RegisterPackageByFamilyNameAsync(String mainPackageFamilyName, IIterable<String> dependencyPackageFamilyNames, DeploymentOptions deploymentOptions, PackageVolume appDataVolume, IIterable<String> optionalPackageFamilyNames)
-->

# Windows.Management.Deployment.PackageManager.RegisterPackageByFamilyNameAsync


## -description

Registers a [Package](/uwp/api/windows.applicationmodel.package) (the main package) by its family name and its dependency packages for the current user.

## -parameters

### -param mainPackageFamilyName

A string that specifies the family name of the main package to be registered.

### -param dependencyPackageFamilyNames

Strings that specify the family names of the dependency packages to be registered.

### -param deploymentOptions

A [DeploymentOptions](deploymentoptions.md)-typed value that specifies the package deployment option.

### -param appDataVolume

The package volume to store that app data on.

### -param optionalPackageFamilyNames

Strings that specify the optional package family names from the main bundle to be registered.

## -returns

A report of the deployment progress. The object implements the **IAsyncOperationWithProgress** pattern.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)
