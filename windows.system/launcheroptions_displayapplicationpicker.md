---
-api-id: P:Windows.System.LauncherOptions.DisplayApplicationPicker
-api-type: winrt property
---

<!-- Property syntax
public bool DisplayApplicationPicker { get;  set; }
-->

# Windows.System.LauncherOptions.DisplayApplicationPicker

## -description
Gets or sets a value that indicates whether to display the **Open With** dialog whenever the association launching API is called.

## -property-value
True if the **Open With** dialog should always be displayed; otherwise false.

## -remarks
You should use the **Open With** dialog box when the user may want to select an app other than the default for a particular file. For example if your app allows the user to launch an image file, the default handler will likely be a viewer app. In some cases the user may want to edit the image instead of viewing it. Use the **Open With** option along with an alternative command in the AppBar or in a context menu to let the user bring up the **Open With** dialog and select the editor app in these types of scenarios.

> [!IMPORTANT]
> This property is only implemented on Desktop devices.

## -examples

See the code example in the [LaunchUriAsync(Uri, LauncherOptions)](launcher_launchfileasync_1480137410.md) topic.

## -see-also
[Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Association%20launching%20sample), [How to launch the default app for a file (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/hh452687(v=win.10)), [Launch the default app for a file](https://docs.microsoft.com/windows/uwp/launch-resume/launch-the-default-app-for-a-file), [How to launch the default app for a URI (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/hh452690(v=win.10)), [Launch the default app for a URI](https://docs.microsoft.com/windows/uwp/launch-resume/launch-default-app), [Guidelines for file types and URIs](https://docs.microsoft.com/windows/uwp/files/index), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)
