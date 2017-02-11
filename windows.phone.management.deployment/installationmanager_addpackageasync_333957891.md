---
-api-id: M:Windows.Phone.Management.Deployment.InstallationManager.AddPackageAsync(System.String,Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Phone.Management.Deployment.PackageInstallResult, uint> AddPackageAsync(System.String title, Windows.Foundation.Uri sourceLocation)
-->

# Windows.Phone.Management.Deployment.InstallationManager.AddPackageAsync

## -description
Starts the installation process for the app specified by the app title and location URI.

## -parameters
### -param title
The name of the app to install.

### -param sourceLocation
The URI location of the app to install.

## -returns
The asynchronous operation that represents the installation process.

## -remarks

## -examples
```csharp
void InstallMyCoolApp()
{
    Uri uri = new Uri(@"https://PlaceHolderServerName/XAP/MyCoolApp.xap");
    string appTitle = "Cool App";

    Windows.Foundation.IAsyncOperationWithProgress<PackageInstallResult, uint> result;

    // Queue up an installation request.
    result = InstallationManager.AddPackageAsync(appTitle, uri);

    // Note: You could save "result" as a member variable to enable 
    // the installation to be cancelled later.
}
```



## -see-also
[AddPackageAsync(String, Uri, String, String, Uri)](installationmanager_addpackageasync_292805853.md)