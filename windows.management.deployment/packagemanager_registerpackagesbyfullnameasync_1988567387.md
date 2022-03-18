---
-api-id: M:Windows.Management.Deployment.PackageManager.RegisterPackagesByFullNameAsync(Windows.Foundation.Collections.IIterable{System.String},Windows.Management.Deployment.RegisterPackageOptions)
-api-type: winrt method
---

## -description

Registers the specified [Packages](/uwp/api/windows.applicationmodel.package) by their full name for the current user.

## -parameters

### -param packageFullNames

The list of full names for the packages you want to register.

### -param options

The package registration options for the operation.

## -returns

The status of the deployment request. The [DeploymentResult](deploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [DeploymentProgress](deploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)
