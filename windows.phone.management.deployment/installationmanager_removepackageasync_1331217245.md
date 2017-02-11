---
-api-id: M:Windows.Phone.Management.Deployment.InstallationManager.RemovePackageAsync(System.String,Windows.Management.Deployment.RemovalOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Phone.Management.Deployment.PackageInstallResult, uint> RemovePackageAsync(System.String packageFullName, Windows.Management.Deployment.RemovalOptions removalOptions)
-->

# Windows.Phone.Management.Deployment.InstallationManager.RemovePackageAsync

## -description
Removes a package for the current user asynchronously and receives progress and status messages on the removal operation. Dependency packages are also removed for the user if no other packages installed for the user depend on them.

## -parameters
### -param packageFullName
A string representation of the package identity to identify the package to be removed.

### -param removalOptions
Options that modify the removal operation.

## -returns
An object that represents the asynchronous removal operation and includes progress updates.

## -remarks

## -examples

## -see-also
