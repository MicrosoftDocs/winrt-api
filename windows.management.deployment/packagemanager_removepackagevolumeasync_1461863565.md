---
-api-id: M:Windows.Management.Deployment.PackageManager.RemovePackageVolumeAsync(Windows.Management.Deployment.PackageVolume)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> RemovePackageVolumeAsync(Windows.Management.Deployment.PackageVolume volume)
-->

# Windows.Management.Deployment.PackageManager.RemovePackageVolumeAsync

## -description
Removes the specified volume.

## -parameters
### -param volume
The volume to remove.

## -returns
An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.

## -remarks

For a call to this method to be successful, the caller needs to fulfil one of these conditions:

* The caller is running in an AppContainer (Low IL) *and* it has the **packageManagement** restricted capability.
* The caller is running with Medium IL, or higher.
* The caller’s publisher matches the publisher of the package (or volume) being removed.

For descriptions of the terms above, and links to more info, see [Packaging, deployment, and process](/windows/apps/get-started/intro-pack-dep-proc).

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)
