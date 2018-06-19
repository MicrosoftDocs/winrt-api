---
-api-id: P:Windows.System.LauncherOptions.PreferredApplicationPackageFamilyName
-api-type: winrt property
---

<!-- Property syntax
public string PreferredApplicationPackageFamilyName { get;  set; }
-->

# Windows.System.LauncherOptions.PreferredApplicationPackageFamilyName

## -description
Gets or sets a value that represents the package family name of the app in the Store that the user should install if no app exists to handle the file type or URI.

## -property-value
The package family name of the app.

## -remarks
In some cases the user may not have an app installed to handle the file that you are launching. By default, Windows will handle these cases by providing the user with a link to search for an appropriate app on the store. Use **LauncherOptions.PreferredApplicationDisplayName** in conjunction with **LauncherOptions.preferredApplicationPackageFamilyName** to provide the user with an app in the Microsoft Store that they can acquire to handle the file. The display name that you use should correspond to the display name of the app in the Microsoft Store.

You must set both of these preferred application properties to recommend an app. Setting one without the other will result in a failure.

> [!NOTE]
> You cannot set the preferred application properties and the fallback URI at the same time, since only one fallback may be used. The Launcher API will fail if both fallbacks are set.

> [!IMPORTANT]
> This property is only implemented on Desktop devices.

## -examples

See the code example in the [LauncherOptions.PreferredApplicationDisplayName](launcheroptions_preferredapplicationdisplayname.md) topic.

## -see-also
[Association launching sample](http://go.microsoft.com/fwlink/p/?linkid=231484), [How to launch the default app for a file (JavaScript)](http://msdn.microsoft.com/library/876edae5-f1a8-45f9-a1a6-50efb1025f96), [Launch the default app for a file](http://msdn.microsoft.com/library/bb45fcaf-df93-4c99-a8b5-59b799c7bd98), [How to launch the default app for a URI (JavaScript)](http://msdn.microsoft.com/library/0f9fa8db-3e51-4cf8-879d-2b79a8ddbb7d), [Launch the default app for a URI](http://msdn.microsoft.com/library/7b0d0af5-d89e-4db0-9b79-90201d79974f), [Guidelines for file types and URIs](http://msdn.microsoft.com/library/a6653b8f-763f-4d67-9d12-6af73a673bc5), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)