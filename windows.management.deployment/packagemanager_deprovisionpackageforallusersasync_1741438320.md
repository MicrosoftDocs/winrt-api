---
-api-id: M:Windows.Management.Deployment.PackageManager.DeprovisionPackageForAllUsersAsync(System.String)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DeploymentProgress> PackageManager.DeprovisionPackageForAllUsersAsync(String packageFamilyName)
-->

# Windows.Management.Deployment.PackageManager.DeprovisionPackageForAllUsersAsync

## -description
Deprovisions an app [Package](/uwp/api/windows.applicationmodel.package) so new users on the device will no longer have the app automatically installed. 

## -parameters
### -param packageFamilyName
The package family name of the package to be deprovisioned.

## -returns
An async operation with the current [DeploymentProgress](deploymentprogress.md) status.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [PackageManager.RemovePackageAsync(String, RemovalOptions)](packagemanager_removepackageasync_1331217245.md)

## -examples

