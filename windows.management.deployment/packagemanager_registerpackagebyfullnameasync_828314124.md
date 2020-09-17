---
-api-id: M:Windows.Management.Deployment.PackageManager.RegisterPackageByFullNameAsync(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Management.Deployment.DeploymentOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> RegisterPackageByFullNameAsync(System.String mainPackageFullName, Windows.Foundation.Collections.IIterable<System.String> dependencyPackageFullNames, Windows.Management.Deployment.DeploymentOptions deploymentOptions)
-->

# Windows.Management.Deployment.PackageManager.RegisterPackageByFullNameAsync

## -description
Registers a [Package](/uwp/api/windows.applicationmodel.package) (the main package) by its full name and its dependency packages for the current user.

## -parameters
### -param mainPackageFullName
A string that specifies the full name of the main package to be registered.

### -param dependencyPackageFullNames
Strings that specify the full names of the dependency packages to be registered.

### -param deploymentOptions
A [DeploymentOptions](deploymentoptions.md)-typed value that specifies the package deployment option.

## -returns
The status of the deployment request. The [DeploymentResult](deploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [DeploymentProgress](deploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks
To hide specifics about the manifest of a bundle package, instead of calling [RegisterPackageAsync](/uwp/api/windows.management.deployment.packagemanager.registerpackageasync), you can call RegisterPackageByFullNameAsync to register a package by its full name. Bundle packages and regular packages are both referenced by the common package full name and thus registration by full name reduces the amount of domain knowledge required by the caller.

RegisterPackageByFullNameAsync can't install a package for any user other than the caller. The *dependencyPackageFullNames* can contain 0 elements if there aren't any dependency packages.

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)

## -capabilities
packageManagement
