---
-api-id: T:Windows.ApplicationModel.PackageUpdateAvailabilityResult
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class PackageUpdateAvailabilityResult 
-->

# Windows.ApplicationModel.PackageUpdateAvailabilityResult

## -description

Describes whether the main app package listed in the .appinstaller file requires updates.

## -remarks

## -see-also
[Windows.ApplicationModel.Package.CheckUpdateAvailabilityAsync](package_checkupdateavailabilityasync_726867427.md), [PackageUpdateAvailability](packageupdateavailability.md)

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
