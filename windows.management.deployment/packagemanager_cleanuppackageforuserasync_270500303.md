---
-api-id: M:Windows.Management.Deployment.PackageManager.CleanupPackageForUserAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> CleanupPackageForUserAsync(System.String packageName, System.String userSecurityId)
-->

# Windows.Management.Deployment.PackageManager.CleanupPackageForUserAsync

## -description
Cleans up a specified [Package](/uwp/api/windows.applicationmodel.package) for a specified user. Used to cleanup packages installed for a user after their user profile is deleted.

## -parameters
### -param packageName
The package name.

### -param userSecurityId
The user security identifier (SID).

## -returns
The status of the deployment request. The [DeploymentResult](deploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [DeploymentProgress](deploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks
The app binaries are not cleaned up unless the app is installed for has no other users. This method does not clear the registration of the app from the user's profile. Before you call this method, be sure that the user's profile is deleted. If the user profile is not deleted and the user logs back to the profile, the profile may show traces of the app. There may also be broken file type associations and broken tile links for the app. The caller must have administrative privilege or the call fails. In addition, the policy to allow deployment operations in special profiles must be enabled. By default, this policy is disabled.

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)

## -capabilities
packageManagement
