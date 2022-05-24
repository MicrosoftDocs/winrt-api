---
-api-id: M:Windows.Management.Deployment.PackageManager.ProvisionPackageForAllUsersAsync(System.String,Windows.Management.Deployment.PackageAllUserProvisioningOptions)
-api-type: winrt method
---

# Windows.Management.Deployment.PackageManager.ProvisionPackageForAllUsersAsync(System.String,Windows.Management.Deployment.PackageAllUserProvisioningOptions)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult,Windows.Management.Deployment.DeploymentProgress> ProvisionPackageForAllUsersAsync (string mainPackageFamilyName, Windows.Management.Deployment.PackageAllUserProvisioningOptions options);
-->


## -description

Enables an app [Package](/uwp/api/windows.applicationmodel.package) to be installed for all users on a device, including options for specifying additional optional packages to be installed.


## -parameters

### -param mainPackageFamilyName

The FamilyName of the app package to be installed.

### -param options

A [PackageAllUserProvisioningOptions](packagealluserprovisioningoptions.md) object specifying the provisioning options.

## -returns

The progress and the result of the app package deployment.

## -remarks

To provision a package you must be an administrator. The app package to be provisioned must be staged, and it must be on the system volume.

If the package is already provisioned, this performs a "clean" reprovision. A "clean" reprovision will remove all previous installs of this package so the package will behave as if this were its first installation.

## -see-also

## -examples


