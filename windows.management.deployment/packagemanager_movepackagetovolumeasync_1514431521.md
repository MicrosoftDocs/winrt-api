---
-api-id: M:Windows.Management.Deployment.PackageManager.MovePackageToVolumeAsync(System.String,Windows.Management.Deployment.DeploymentOptions,Windows.Management.Deployment.PackageVolume)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> MovePackageToVolumeAsync(System.String packageFullName, Windows.Management.Deployment.DeploymentOptions deploymentOptions, Windows.Management.Deployment.PackageVolume targetVolume)
-->

# Windows.Management.Deployment.PackageManager.MovePackageToVolumeAsync

## -description
Moves the specified [Package](/uwp/api/windows.applicationmodel.package) to the specified volume using the specified deployment options.

## -parameters
### -param packageFullName
The full name of the package to move.

### -param deploymentOptions
One of the enumeration values that specifies a deployment option.

### -param targetVolume
The target volume.

## -returns
An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.

## -remarks
This method lets the caller move a package from one logical volume to another.

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)

## -capabilities
packageManagement
