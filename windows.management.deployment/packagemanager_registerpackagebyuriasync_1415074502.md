---
-api-id: M:Windows.Management.Deployment.PackageManager.RegisterPackageByUriAsync(Windows.Foundation.Uri,Windows.Management.Deployment.RegisterPackageOptions)
-api-type: winrt method
---

## -description

Registers a [Package](/uwp/api/windows.applicationmodel.package) (the main package) and its dependency packages for the current user, using the specified deployment options.

## -parameters

### -param manifestUri

The URI of the manifest for the main package.

### -param options

The package registration options for the operation.

## -returns

The status of the deployment request. The [DeploymentResult](deploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [DeploymentProgress](deploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks

This method simplifies the existing [RegisterPackageAsync](/uwp/api/windows.management.deployment.packagemanager.registerpackageasync) overloads by consolidating all of the deployment options into a single parameter. This method also supports the following features not available with the the [RegisterPackageAsync](/uwp/api/windows.management.deployment.packagemanager.registerpackageasync) overloads:

* You can use the [ExternalLocationURI](registerpackageoptions_externallocationuri.md) property of the *options* parameter to specify the URI of an external disk location outside of the MSIX package where the package manifest can reference application content. For more information about this scenario and a related code sample, see [Grant package identity by packaging with external location](/windows/apps/desktop/modernize/grant-identity-to-nonpackaged-apps).

* You can use the [AllowUnsigned](registerpackageoptions_allowunsigned.md) property of the *options* parameter to allow activation information from an executable in an unsigned package. For more information about this scenario and a related code sample, see [Hosted apps](/windows/uwp/launch-resume/hosted-apps).

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [RegisterPackageOptions](registerpackageoptions.md), [Grant package identity by packaging with external location](/windows/apps/desktop/modernize/grant-identity-to-nonpackaged-apps), [Hosted apps](/windows/uwp/launch-resume/hosted-apps)

## -examples
