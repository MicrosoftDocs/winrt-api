---
-api-id: M:Windows.Management.Deployment.PackageManager.StageUserDataAsync(System.String,Windows.Management.Deployment.DeploymentOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> StageUserDataAsync(System.String packageFullName, Windows.Management.Deployment.DeploymentOptions deploymentOptions)
-->

# Windows.Management.Deployment.PackageManager.StageUserDataAsync

## -description
Stages a [Package's](/uwp/api/windows.applicationmodel.package) roaming data to the system without registering the package. Call this method after staging the package but before registering the package for a particular user.

## -parameters
### -param packageFullName
The full name of the package.

### -param deploymentOptions
A bitwise combination of enumeration values from the [DeploymentOptions](deploymentoptions.md) enumeration that specify deployment options.

## -returns
An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.

## -remarks

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [StageUserDataAsync(String)](packagemanager_stageuserdataasync_1037604209.md)
