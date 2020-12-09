---
-api-id: P:Windows.System.LauncherUIOptions.SelectionRect
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.Rect> SelectionRect { get;  set; }
-->

# Windows.System.LauncherUIOptions.SelectionRect

## -description
Gets or sets the selection rectangle on the screen where the user opened a file or URI.

## -property-value
The selection rectangle.

## -remarks
To get or set the invocation point, use the [InvocationPoint](launcheruioptions_invocationpoint.md) method.



> [!IMPORTANT]
> This property is only implemented on Desktop devices.

## -examples

## -see-also
[Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Association%20launching%20sample), [Launch the default app for a file](/windows/uwp/launch-resume/launch-the-default-app-for-a-file), [Launch the default app for a URI](/windows/uwp/launch-resume/launch-default-app), [Guidelines for file types and URIs](/windows/uwp/files/index), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)
