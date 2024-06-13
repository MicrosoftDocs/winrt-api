---
-api-id: M:Windows.Management.Deployment.PackageManager.RemovePackageAsync(System.String,Windows.Management.Deployment.RemovalOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> RemovePackageAsync(System.String packageFullName, Windows.Management.Deployment.RemovalOptions removalOptions)
-->

# Windows.Management.Deployment.PackageManager.RemovePackageAsync

## -description
Removes a [Package](/uwp/api/windows.applicationmodel.package) for the current user asynchronously and receives progress and status messages on the removal operation. Dependency packages are also removed for the user if no other packages installed for the user depend on them.

## -parameters
### -param packageFullName
A string representation of the package identity to identify the package to be removed.

### -param removalOptions
A [RemovalOptions](removaloptions.md)-typed value that modifies the removal operation.

## -returns
A pointer that receives the address of an object that implements the [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) interface.

## -remarks

For a call to this method to be successful, the caller needs to fulfil one of these conditions:

* The caller is running in an AppContainer (Low IL) *and* it has the **packageManagement** restricted capability.
* The caller is running with Medium IL, or higher.
* The caller’s publisher matches the publisher of the package (or volume) being removed.

For descriptions of the terms above, and links to more info, see [Packaging, deployment, and process](/windows/apps/get-started/intro-pack-dep-proc).

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [RemovePackageAsync(String)](packagemanager_removepackageasync_1124236459.md)
