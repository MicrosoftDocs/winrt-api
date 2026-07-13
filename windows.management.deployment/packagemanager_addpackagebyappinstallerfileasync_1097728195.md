---
-api-id: M:Windows.Management.Deployment.PackageManager.AddPackageByAppInstallerFileAsync(Windows.Foundation.Uri,Windows.Management.Deployment.AddPackageByAppInstallerOptions,Windows.Management.Deployment.PackageVolume)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> PackageManager.AddPackageByAppInstallerFileAsync(Uri appInstallerFileUri, AddPackageByAppInstallerOptions options, PackageVolume targetVolume)
-->

# Windows.Management.Deployment.PackageManager.AddPackageByAppInstallerFileAsync

## -description
Allows single or multiple app [Packages](/uwp/api/windows.applicationmodel.package) to be installed with an .appinstaller file.

## -parameters
### -param appInstallerFileUri
A Uri to the .appinstaller file.

### -param options
The options as specified in [AddPackageByAppInstallerOptions](addpackagebyappinstalleroptions.md).

### -param targetVolume
The volume that the package is installed to.

## -returns
An [IAsyncOperationWithProgress](/uwp/api/windows.foundation.iasyncoperationwithprogress-2) with a [DeploymentResult](/uwp/api/windows.management.deployment.deploymentresult) that indicates whether the deployment was successful, and [DeploymentProgress](/uwp/api/windows.management.deployment.deploymentprogress) that provides progress updates during the installation.

## -remarks
This method is not supported in JavaScript. However, you can create a Windows Runtime component that calls this method and then call this component from a JavaScript UWP app. For more information, see [App Installer file API issues](/windows/msix/app-installer/app-installer-api-issues).

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [App Installer APIs](/windows/msix/app-installer/app-installer-documentation)

## -examples

The following example uses **AddPackageByAppInstallerFileAsync** to install packages defined in an .appinstaller file. Note that the returned [IAsyncOperationWithProgress](/uwp/api/windows.foundation.iasyncoperationwithprogress-2) is assigned to a variable before monitoring its completion. Failing to hold a reference to the operation can cause it to be garbage-collected and never complete.

```csharp
using System;
using System.Threading;
using Windows.Foundation;
using Windows.Management.Deployment;

public static int Main(string[] args)
{
    string inputFileUri = args[0];
    int returnValue = 0;

    Uri appInstallerFileUri = new Uri(inputFileUri);

    PackageManager packageManager = new PackageManager();
    PackageVolume packageVolume = packageManager.GetDefaultPackageVolume();

    // Important: assign the operation to a variable to prevent it from
    // being garbage-collected before completion.
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> deploymentOperation =
        packageManager.AddPackageByAppInstallerFileAsync(
            appInstallerFileUri,
            AddPackageByAppInstallerOptions.ForceTargetAppShutdown,
            packageVolume);

    // This event is signaled when the operation completes
    ManualResetEvent opCompletedEvent = new ManualResetEvent(false);

    // Define the delegate using a statement lambda
    deploymentOperation.Completed = (operation, status) => { opCompletedEvent.Set(); };

    // Wait until the operation completes
    opCompletedEvent.WaitOne();

    // Check the status of the operation
    if (deploymentOperation.Status == AsyncStatus.Error)
    {
        DeploymentResult deploymentResult = deploymentOperation.GetResults();
        Console.WriteLine("Error code: {0}", deploymentOperation.ErrorCode);
        Console.WriteLine("Error text: {0}", deploymentResult.ErrorText);
        returnValue = 1;
    }
    else if (deploymentOperation.Status == AsyncStatus.Canceled)
    {
        Console.WriteLine("Installation canceled");
    }
    else if (deploymentOperation.Status == AsyncStatus.Completed)
    {
        Console.WriteLine("Installation succeeded");
    }
    else
    {
        returnValue = 1;
        Console.WriteLine("Installation status unknown");
    }

    return returnValue;
}
```

## -capabilities
packageManagement
