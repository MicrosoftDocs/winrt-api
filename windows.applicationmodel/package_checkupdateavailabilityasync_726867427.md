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

The **CheckUpdateAvailabilityAsync** method allows developers to check for updates to the main app package listed in the .appinstaller file. It allows the developer to determine if the updates are required due to .appinstaller policy. This method currently only works for applications installed via .appinstaller files.


## -returns

A [PackageUpdateAvailabilityResult](packageupdateavailabilityresult.md) that indicates if an application has an update, and if the update is required.

## -remarks

## -see-also
[PackageUpdateAvailabilityResult](packageupdateavailabilityresult.md)

## -examples

An app developer wants to have a button in their app that allows a user to check for app updates. To enable the app to check if an update is available, they use the CheckUpdateAvailabilityAsync method as shown below. 

```csharp

private async void CheckForUpdatesButton_Click(object sender, RoutedEventArgs e)
{
    PackageUpdateAvailabilityResult result = await Package.Current.CheckUpdateAvailabilityAsync();
    switch (result.Availability)
    {
        case PackageUpdateAvailability.Available:
            GoToUpdateAvailableUIView();
            break;
        case PackageUpdateAvailability.Required:
            GoToUpdateRequiredUIView();
            break;
        case PackageUpdateAvailability.NoUpdates:
            ShowNoUpdateAvailableDialog(); // dismissable ‘Ok’ dialog
            break;
        case PackageUpdateAvailability.Unknown:
        default:
            // Log and ignore error.
            Logger.Log($"No update information associated with app {Package.Current.DisplayName}");
            ShowNoUpdateAvailableDialog(); // dismissable ‘Ok’ dialog
            break;
    }
}

```

From inside the app, the developer wants to check for updates and start the update process if updates are available. 

```csharp

public async void CheckForAvailableUpdatesAndLaunchAsync(string targetPackageFullName)
{
    PackageManager pm = new PackageManager();
    Package package = pm.FindPackageForUser(string.Empty /*current user*/, targetPackageFullName);

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
            // Launch target app and close AppInstaller
            LaunchTargetApp(targetPackageFullName);
            await ConsolidateAppInstallerView();
            break;
        case PackageUpdateAvailability.Unknown:
        default:
            // Log and ignore error.
            Logger.Log($"No update information associated with app {targetPackageFullName}");
            // Launch target app and close AppInstaller
            LaunchTargetApp(targetPackageFullName);
            await ConsolidateAppInstallerView();
            break;
    }
}

```
