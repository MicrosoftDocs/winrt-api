---
-api-id: M:Windows.Management.Deployment.PackageManager.AddPackageByUriAsync(Windows.Foundation.Uri,Windows.Management.Deployment.AddPackageOptions)
-api-type: winrt method
---

## -description

Adds a [Package](/uwp/api/windows.applicationmodel.package) (the main package) and any additional dependency packages, for the current user, using the specified deployment options.

## -parameters

### -param packageUri

The URI of the package to add. The URI can use the file URI scheme (file://) for local file paths and local network paths. HTTP and HTTPS protocols are also supported. Starting with Windows build 22556, The URI can point to a package or an App Installer file.

### -param options

The package deployment options for the operation.

## -returns

The status of the deployment request. The [DeploymentResult](deploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [DeploymentProgress](deploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks

This method simplifies the existing [AddPackageAsync](/uwp/api/windows.management.deployment.packagemanager.addpackageasync) overloads by consolidating all of the deployment options into a single parameter. This method also supports the following features not available with the the [AddPackageAsync](/uwp/api/windows.management.deployment.packagemanager.addpackageasync) overloads:

* You can use the [ExternalLocationURI](addpackageoptions_externallocationuri.md) property of the *options* parameter to specify the URI of an external disk location outside of the MSIX package where the package manifest can reference application content. For more information about this scenario and a related code sample, see [Grant package identity by packaging with external location](/windows/apps/desktop/modernize/grant-identity-to-nonpackaged-apps).

* You can use the [AllowUnsigned](addpackageoptions_allowunsigned.md) property of the *options* parameter to allow activation information from an executable in an unsigned package. For more information about this scenario and a related code sample, see [Hosted apps](/windows/uwp/launch-resume/hosted-apps).

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [AddPackageOptions](addpackageoptions.md),[Grant package identity by packaging with external location](/windows/apps/desktop/modernize/grant-identity-to-nonpackaged-apps), [Hosted apps](/windows/uwp/launch-resume/hosted-apps)

## -examples
