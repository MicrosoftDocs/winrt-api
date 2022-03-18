---
-api-id: M:Windows.Management.Deployment.PackageManager.StageUserDataAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> StageUserDataAsync(System.String packageFullName)
-->

# Windows.Management.Deployment.PackageManager.StageUserDataAsync

## -description
Stages a [Package's](/uwp/api/windows.applicationmodel.package) roaming data to the system without registering the package. Call this method after staging the package but before registering the package for a particular user.

## -parameters
### -param packageFullName
The full name of the package.

## -returns
An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [StageUserDataAsync(String, DeploymentOptions)](packagemanager_stageuserdataasync_1411865639.md)
