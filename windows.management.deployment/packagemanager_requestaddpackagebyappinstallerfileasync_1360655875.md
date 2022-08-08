---
-api-id: M:Windows.Management.Deployment.PackageManager.RequestAddPackageByAppInstallerFileAsync(Windows.Foundation.Uri,Windows.Management.Deployment.AddPackageByAppInstallerOptions,Windows.Management.Deployment.PackageVolume)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DeploymentProgress> PackageManager.RequestAddPackageByAppInstallerFileAsync(Uri appInstallerFileUri, AddPackageByAppInstallerOptions options, PackageVolume targetVolume)
-->

# Windows.Management.Deployment.PackageManager.RequestAddPackageByAppInstallerFileAsync

## -description
Allows single or multiple app [Packages](/uwp/api/windows.applicationmodel.package) to be installed with an .appinstaller file. This will perform a SmartScreen filter and user verification before installing the app package(s).

## -parameters
### -param appInstallerFileUri
A Uri to the .appinstaller file.

### -param options
The options as specified in [AddPackageByAppInstallerOptions](addpackagebyappinstalleroptions.md).

### -param targetVolume
The volume that the package is installed to.

## -returns

## -remarks
This method is identical to [AddPackageByAppInstallerAsync](packagemanager_addpackagebyappinstallerfileasync_1097728195.md) except this uses the SmartScreen filter.

This method is not supported in JavaScript. However, you can create a Windows Runtime component that calls this method and then call this component from a JavaScript UWP app. For more information, see [App Installer file API issues](/windows/msix/app-installer/app-installer-api-issues).

## -see-also
[App Installer APIs](/windows/msix/app-installer/app-installer-api-issues)

## -examples

[Package](/uwp/api/windows.applicationmodel.package)

## -capabilities
packageManagement
