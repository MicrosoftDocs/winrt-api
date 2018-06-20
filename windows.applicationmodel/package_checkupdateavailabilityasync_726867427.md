---
-api-id: M:Windows.ApplicationModel.Package.CheckUpdateAvailabilityAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<PackageUpdateAvailabilityResult> Package.CheckUpdateAvailabilityAsync()
-->

# Windows.ApplicationModel.Package.CheckUpdateAvailabilityAsync

## -description

The CheckUpdateAvailabilityAsync method allows developers to check for updates to the main app package listed in the .appinstaller file. It allows the developer to determine if the updates are required due to .appinstaller policy. This method currently only works for applications installed via .appinstaller files.


## -returns

A [PackageUpdateAvailability](packageupdateavailability.md) enum that indicates if an application has an update, and if the update is required.

## -remarks

## -see-also
[Windows.ApplicationModel.PackageUpdateAvailability](packageupdateavailability.md)

## -examples