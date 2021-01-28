---
-api-id: M:Windows.Management.Deployment.PackageManager.ProvisionPackageForAllUsersAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DeploymentProgress> PackageManager.ProvisionPackageForAllUsersAsync(String packageFamilyName)
-->

# Windows.Management.Deployment.PackageManager.ProvisionPackageForAllUsersAsync

## -description
Enables an app [Package](/uwp/api/windows.applicationmodel.package) to be installed for all users on a device.

## -parameters

### -param packageFamilyName
The FamilyName of the app package to be installed.

## -returns
The progress and the result of the app package deployment.

## -remarks
To provision a package you must be an administrator. The app package to be provisioned must be staged, and it must be on the system volume.

If the package is already provisioned, this performs a "clean" reprovision. A "clean" reprovision will remove all previous installs of this package so the package will behave as if this were its first installation.

> [!NOTE]
> If you are provisioning optional packages, you must specify each optional package individually with its own method call.

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)

## -examples
This example demonstrates adding a staged or existing registered package for all users on a device.

```csharp
using Windows.Foundation;
using Windows.Management.Deployment;

public void provisionForAllUsers(string inputPackageFamilyName)
{
    var packageManager = new PackageManager();
    var result = packageManager.ProvisionPackageForAllUsersAsync(inputPackageFamilyName).AsTask().Result;
    if (result.ExtendedErrorCode != null)
    {
        System.Console.WriteLine("Error {0} provisioning {1}", result, inputPackageFamilyName);
        throw result.ExtendedErrorCode.HResult;
    }
}
```

