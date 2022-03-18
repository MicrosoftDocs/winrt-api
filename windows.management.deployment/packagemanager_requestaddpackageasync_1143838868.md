---
-api-id: M:Windows.Management.Deployment.PackageManager.RequestAddPackageAsync(Windows.Foundation.Uri,Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Management.Deployment.DeploymentOptions,Windows.Management.Deployment.PackageVolume,Windows.Foundation.Collections.IIterable{System.String},Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DeploymentProgress> PackageManager.RequestAddPackageAsync(Uri packageUri, IIterable<Uri> dependencyPackageUris, DeploymentOptions deploymentOptions, PackageVolume targetVolume, IIterable<String> optionalPackageFamilyNames, IIterable<Uri> relatedPackageUris)
-->

# Windows.Management.Deployment.PackageManager.RequestAddPackageAsync

## -description
Requests a SmartScreen check and user verification before installing the app [Package(s)](/uwp/api/windows.applicationmodel.package).

## -parameters
### -param packageUri
The URI of the package to add. The URI must follow the file URI scheme (file://) since the only supported URI schemes are local file paths and local network paths.

### -param dependencyPackageUris
The URIs of the dependency packages to add. If there are no dependency packages or if the dependency packages are already registered, this parameter can be null.

### -param deploymentOptions
A valid enumeration value from the [DeploymentOptions](deploymentoptions.md) enumeration.

### -param targetVolume
The volume that the package is installed to.

### -param optionalPackageFamilyNames
Strings that specify the optional package family names from the main bundle to be staged and registered.

### -param relatedPackageUris
The URIs of additional packages in the main bundle that should be staged and registered.

## -returns
The progress and the result of the app package deployment.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)

## -examples
The example demonstrates how to use RequestAddPackageAsync in a UWP app by hooking it up to a button click handler. This will invoke the SmartScreen request UI window.

```csharp
public async void OnInstallNowClicked(object sender, RoutedEventArgs args)
{
    var packageManager = new PackageManager();
    DeploymentOperation result = await packageManager.RequestAddPackageAsync(
            this.currentPackageUri,
            null /*no dependencies*/,
            DeploymentOptions.None,
            null /*stage to default package volume*/,
            null /*no optional packages*/,
            null /*no external packages*/);

    if (result.ExtendedErrorCode != null)
    {
        if (result.ExtendedErrorCode.HResult == 0x80073d01)
        {
            // SmartScreen blocked the app installation.
        }
        else
        {
            // The app installation failed for another reason.
        }
    }
}
```

