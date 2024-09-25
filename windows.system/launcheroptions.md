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

In some cases, when you call [Launcher](launcher.md) static methods to launch an app associated with a file type or URI protocol, you must specify exactly which app you want to be launched by passing a **LauncherOptions** parameter with the [TargetApplicationPackageFamilyName](launcheroptions_targetapplicationpackagefamilyname.md) property set to the package family name for the app package containing that app.

Two such cases are as follows:

1. You want to launch an app with a URI and pass extra input data to the launched app, using [Launcher.LaunchUriAsync(Uri, LauncherOptions, ValueSet)](launcher_launchuriasync_569877360.md).
1. You want to launch an app with a URI and wait for the app to send output data back to your app, using any overload of [Launcher.LaunchUriForResultsAsync](launcher_launchuriforresultsasync_148601521.md).

In these cases, both the calling app and launched app need to agree on how to interpret the extra data passed from one app to the other. The calling app cannot launch any app that happens to be the default for that URI protocol. In other cases, the **TargetApplicationPackageFamilyName** property is optional.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IgnoreAppUriHandlers |
| 1703 | 15063 | LimitPickerToCurrentAppAndAppUriHandlers |

## -examples

See the code example in the [LaunchUriAsync(Uri, LauncherOptions)](launcher_launchfileasync_1480137410.md) topic.

## -see-also

[Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Association%20launching%20sample), [Launch the default app for a file](/windows/uwp/launch-resume/launch-the-default-app-for-a-file), [Launch the default app for a URI](/windows/uwp/launch-resume/launch-default-app), [Guidelines for file types and URIs](/windows/uwp/files/index), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)
