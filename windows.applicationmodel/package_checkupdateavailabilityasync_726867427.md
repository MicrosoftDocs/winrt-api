---
-api-id: M:Windows.ApplicationModel.Package.CheckUpdateAvailabilityAsync
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<PackageUpdateAvailabilityResult> Package.CheckUpdateAvailabilityAsync()
-->

# Windows.ApplicationModel.Package.CheckUpdateAvailabilityAsync

## -description

The *`CheckUpdateAvailabilityAsync` method allows developers to check for updates to the main app package listed in the .appinstaller file. It allows the developer to determine if the updates are required due to .appinstaller policy. This method currently only works for applications installed via .appinstaller files.

## -returns

A [PackageUpdateAvailabilityResult](packageupdateavailabilityresult.md) that indicates if an application has an update, and if the update is required.

## -remarks

If you try to use this method on the [Package](package.md) object returned by the [Current](package_current.md) property, this method will fail with an "Access denied" error. This is a known issue that may be fixed in a future release. The example on this page demonstrates how to retrieve update information about the current app's package.

This method is not supported in JavaScript. However, you can create a Windows Runtime component that calls this method and then call this component from a JavaScript UWP app. For more information, see [App Installer file API issues](/windows/msix/app-installer/app-installer-api-issues).

## -see-also

[PackageUpdateAvailabilityResult](packageupdateavailabilityresult.md),[PackageManager.FindPackageForUser](../windows.management.deployment/packagemanager_findpackageforuser_526853699.md),[App Installer APIs](/windows/msix/app-installer/app-installer-documentation#app-installer-file-apis)

## -examples

> [!NOTE]
> The [**MSIX Labs for Developers** repo](https://github.com/microsoft/MSIX-Labs/tree/master/DeveloperLabs) contains additional examples on modernizing desktop apps by taking advantage of MSIX, including an [exercise using the embedded .AppInstaller feature](https://github.com/microsoft/MSIX-Labs/blob/master/docs/index.md#exercise-15-embedded-appinstaller).

An app developer wants to have a button in their app that allows a user to check for app updates. To enable the app to check if an update is available, they use the `CheckUpdateAvailabilityAsync` method as shown below.

```csharp
private async void CheckForUpdatesButton_Click(object sender, RoutedEventArgs e)
{
    // Get the current app's package for the current user.
    var pm = new PackageManager();
    Package currentPackage = pm.FindPackageForUser(string.Empty, Package.Current.Id.FullName);

    PackageUpdateAvailabilityResult result = await currentPackage.CheckUpdateAvailabilityAsync();
    switch (result.Availability)
    {
        case PackageUpdateAvailability.Available:
            GoToUpdateAvailableUIView();
            break;
        case PackageUpdateAvailability.Required:
            GoToUpdateRequiredUIView();
            break;
        case PackageUpdateAvailability.NoUpdates:
            // Dismissable ‘Ok’ dialog.
            ShowNoUpdateAvailableDialog(); 
            break;
        case PackageUpdateAvailability.Unknown:
        default:
            // Log and ignore error.
            Logger.Log($"No update information associated with app {Package.Current.DisplayName}");
            // Dismissable ‘Ok’ dialog.
            ShowNoUpdateAvailableDialog();
            break;
    }
}
```

From inside the app, the developer wants to check for updates and start the update process if updates are available.

```csharp
public async void CheckForAvailableUpdatesAndLaunchAsync(string targetPackageFullName)
{
    // Get the current app's package for the current user.
    var pm = new PackageManager();
    Package package = pm.FindPackageForUser(string.Empty, targetPackageFullName);

    PackageUpdateAvailabilityResult result = await package.CheckUpdateAvailabilityAsync();
    switch (result.Availability)
    {
        case PackageUpdateAvailability.Available:
            GoToUpdateAvailableUIView();
            break;
        case PackageUpdateAvailability.Required:
            GoToUpdateRequiredUIView();
            break;
        case PackageUpdateAvailability.NoUpdates:
            // Launch target app and close AppInstaller.
            LaunchTargetApp(targetPackageFullName);
            await ConsolidateAppInstallerView();
            break;
        case PackageUpdateAvailability.Unknown:
        default:
            // Log and ignore error.
            Logger.Log($"No update information associated with app {targetPackageFullName}");
            // Launch target app and close AppInstaller.
            LaunchTargetApp(targetPackageFullName);
            await ConsolidateAppInstallerView();
            break;
    }
}
```
