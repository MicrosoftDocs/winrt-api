---
-api-id: P:Windows.System.LauncherOptions.DesiredRemainingView
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.ViewManagement.ViewSizePreference DesiredRemainingView { get;  set; }
-->

# Windows.System.LauncherOptions.DesiredRemainingView

## -description
Launch a target app and have the currently running source app remain on the screen by sharing the space equally with the target app or by taking up more or less space than the target app.

## -property-value
A [ViewSizePreference](../windows.ui.viewmanagement/viewsizepreference.md)-typed value that specifies the app’s desired view size.

## -remarks
Source apps that call [LaunchUriAsync](launcher_launchuriasync_53691900.md) or [LaunchFileAsync](launcher_launchfileasync_1480137410.md) can request that they remain on screen after a URI or file launch. By default, Windows will attempt to share all available space equally between the source app and the target app that handles the URI or file. Source apps can use the DesiredRemainingView property to indicate to the system that they prefer their app window to take up more or less of the available space. DesiredRemainingView can also be used to indicate that the source app does not need to remain on screen after the file or URI launch and can be completely replaced by the target app. This property only specifies the preferred window size of the calling app. It doesn't specify the behavior of other apps that may happen to also be on screen at the same time.



> [!NOTE]
> Windows takes into account multiple different factors when determining the source app's final window size, for example, the preference of the source app, the number of apps on screen, the screen orientation, and so on. By setting DesiredRemainingView, you aren't guaranteed a specific windowing behavior for the source app.



> [!IMPORTANT]
> This property is only implemented on Desktop devices.

## -examples

## -see-also
[ViewSizePreference](../windows.ui.viewmanagement/viewsizepreference.md), [Association launching sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/AssociationLaunching)
