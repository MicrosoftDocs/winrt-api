---
-api-id: P:Windows.System.LauncherOptions.TreatAsUntrusted
-api-type: winrt property
---

<!-- Property syntax
public bool TreatAsUntrusted { get;  set; }
-->

# Windows.System.LauncherOptions.TreatAsUntrusted

## -description
Gets or sets a value that indicates whether the system should display a warning that the file or URI is potentially unsafe when starting the app associated with a file or URI.

## -property-value
True if the warning should be displayed; otherwise false.

## -remarks
> [!IMPORTANT]
> This property is only implemented on Desktop devices.

## -examples

See the code example in the [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md) topic.

## -see-also
[Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Association%20launching%20sample), [Launch the default app for a file](/windows/uwp/launch-resume/launch-the-default-app-for-a-file), [Launch the default app for a URI](/windows/uwp/launch-resume/launch-default-app), [Guidelines for file types and URIs](/windows/uwp/files/index), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)
