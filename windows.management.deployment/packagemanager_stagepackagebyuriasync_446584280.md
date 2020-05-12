---
-api-id: M:Windows.Management.Deployment.PackageManager.StagePackageByUriAsync(Windows.Foundation.Uri,Windows.Management.Deployment.StagePackageOptions)
-api-type: winrt method
---

## -description

Stages a package to the system without registering it, using the specified deployment options.

## -parameters

### -param packageUri

The source URI of the main package.

### -param options

The package deployment options for the operation.

## -returns

The status of the deployment request. The [DeploymentResult](deploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [DeploymentProgress](deploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks

This method simplifies the existing [StagePackageAsync](https://docs.microsoft.com/uwp/api/windows.management.deployment.packagemanager.stagepackageasync) overloads by consolidating all of the deployment options into a single parameter. This method also supports the following features not available with the the [StagePackageAsync](https://docs.microsoft.com/uwp/api/windows.management.deployment.packagemanager.stagepackageasync) overloads:

* You can use the [ExternalLocationURI](stagepackageoptions_externallocationuri.md) property of the *options* parameter to specify the URI of an external disk location outside of the MSIX package where the package manifest can reference application content.

* You can use the [AllowUnsigned](stagepackageoptions_allowunsigned.md) property of the *options* parameter to allow activation information from an executable in an unsigned package.

## -see-also

[StagePackageOptions](stagepackageoptions.md)

## -examples

