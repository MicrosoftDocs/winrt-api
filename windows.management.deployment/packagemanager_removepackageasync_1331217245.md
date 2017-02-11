---
-api-id: M:Windows.Management.Deployment.PackageManager.RemovePackageAsync(System.String,Windows.Management.Deployment.RemovalOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> RemovePackageAsync(System.String packageFullName, Windows.Management.Deployment.RemovalOptions removalOptions)
-->

# Windows.Management.Deployment.PackageManager.RemovePackageAsync

## -description
Removes a package for the current user asynchronously and receives progress and status messages on the removal operation. Dependency packages are also removed for the user if no other packages installed for the user depend on them.

## -parameters
### -param packageFullName
A string representation of the package identity to identify the package to be removed.

### -param removalOptions
A [RemovalOptions](removaloptions.md)-typed value that modifies the removal operation.

## -returns
A pointer that receives the address of an object that implements the [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) interface.

## -remarks

## -examples

## -see-also
[RemovePackageAsync(String)](packagemanager_removepackageasync_1124236459.md)