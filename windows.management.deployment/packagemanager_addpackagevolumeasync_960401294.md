---
-api-id: M:Windows.Management.Deployment.PackageManager.AddPackageVolumeAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Management.Deployment.PackageVolume> AddPackageVolumeAsync(System.String packageStorePath)
-->

# Windows.Management.Deployment.PackageManager.AddPackageVolumeAsync

## -description
Creates a new volume. The caller must be a member of the administrators group.

## -parameters
### -param packageStorePath
The absolute path of the [Package](/uwp/api/windows.applicationmodel.package) store.

## -returns
An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperation** interface and returns the newly added [PackageVolume](packagevolume.md).

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)

## -capabilities
packageManagement
