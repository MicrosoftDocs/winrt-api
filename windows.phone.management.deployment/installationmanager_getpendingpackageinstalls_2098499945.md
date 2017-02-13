---
-api-id: M:Windows.Phone.Management.Deployment.InstallationManager.GetPendingPackageInstalls
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.Foundation.IAsyncOperationWithProgress<Windows.Phone.Management.Deployment.PackageInstallResult, uint>> GetPendingPackageInstalls()
-->

# Windows.Phone.Management.Deployment.InstallationManager.GetPendingPackageInstalls

## -description
Returns all of the app installations currently in progress.

## -returns
A list of the app installations currently in progress. The list contains the [PackageInstallResult](packageinstallresult.md) (pending) for each installation, which are wrapped by the async operation class ([IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md)). See [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e) for more info on how to get progress info.

## -remarks

## -examples

## -see-also
