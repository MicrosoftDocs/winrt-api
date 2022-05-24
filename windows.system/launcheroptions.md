---
-api-id: T:Windows.System.LauncherOptions
-api-type: winrt class
---

<!-- Class syntax.
public class LauncherOptions : Windows.System.ILauncherOptions, Windows.System.ILauncherOptions2, Windows.System.ILauncherOptions3, Windows.System.ILauncherOptions4, Windows.System.ILauncherViewOptions
-->

# Windows.System.LauncherOptions

## -description

Specifies the options used to launch the default app for a file or URI.

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IgnoreAppUriHandlers |
| 1703 | 15063 | LimitPickerToCurrentAppAndAppUriHandlers |

## -examples

See the code example in the [LaunchUriAsync(Uri, LauncherOptions)](launcher_launchfileasync_1480137410.md) topic.

## -see-also

[Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Association%20launching%20sample), [Launch the default app for a file](/windows/uwp/launch-resume/launch-the-default-app-for-a-file), [Launch the default app for a URI](/windows/uwp/launch-resume/launch-default-app), [Guidelines for file types and URIs](/windows/uwp/files/index), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)
