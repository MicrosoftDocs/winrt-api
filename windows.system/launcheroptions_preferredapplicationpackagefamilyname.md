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
[Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Association%20launching%20sample), [Launch the default app for a file](/windows/uwp/launch-resume/launch-the-default-app-for-a-file), [Launch the default app for a URI](/windows/uwp/launch-resume/launch-default-app), [Guidelines for file types and URIs](/windows/uwp/files/index), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)
