---
-api-id: M:Windows.Management.Deployment.PackageManager.AddPackageByAppInstallerFileAsync(Windows.Foundation.Uri,Windows.Management.Deployment.AddPackageByAppInstallerOptions,Windows.Management.Deployment.PackageVolume)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DeploymentProgress> PackageManager.AddPackageByAppInstallerFileAsync(Uri appInstallerFileUri, AddPackageByAppInstallerOptions options, PackageVolume targetVolume)
-->

# Windows.Management.Deployment.PackageManager.AddPackageByAppInstallerFileAsync

## -description
Allows single or multiple app [Packages](/uwp/api/windows.applicationmodel.package) to be installed with an .appinstaller file.

## -parameters
### -param appInstallerFileUri
A Uri to the .appinstaller file.

### -param options
The options as specified in [AddPackageByAppInstallerOptions](addpackagebyappinstalleroptions.md).

### -param targetVolume
The volume that the package is installed to.

## -returns

## -remarks
This method is not supported in JavaScript. However, you can create a Windows Runtime component that calls this method and then call this component from a JavaScript UWP app. For more information, see [App Installer file API issues](/windows/msix/app-installer/app-installer-api-issues).

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [App Installer APIs](/windows/msix/app-installer/app-installer-documentation)

## -examples

## -capabilities
packageManagement
