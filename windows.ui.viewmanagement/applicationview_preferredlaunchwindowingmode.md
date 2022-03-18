---
-api-id: P:Windows.UI.ViewManagement.ApplicationView.PreferredLaunchWindowingMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.ViewManagement.ApplicationViewWindowingMode PreferredLaunchWindowingMode { get;  set; }
-->

# Windows.UI.ViewManagement.ApplicationView.PreferredLaunchWindowingMode

## -description
Gets or sets a value that indicates the windowing mode the app launches with.

## -property-value
An enumeration value that indicates the windowing mode of the app.

## -remarks
By default, PreferredLaunchWindowingMode is set to **Auto**. In this mode, the size and position of your app window on startup is managed automatically by Windows.

You can set PreferredLaunchWindowingMode to override the automatic behavior with one of these values. 
+ **PreferredLaunchViewSize**: When launched, the window is sized as specified by the [ApplicationView.PreferredLaunchViewSize](applicationview_preferredlaunchviewsize.md) property.
+ **FullScreen**: The window is launched in full-screen mode. (Full-screen mode in not the same as maximized. See [IsFullScreenMode](applicationview_isfullscreenmode.md) for more info.)

For the very first launch of an app the PreferredLaunchWindowingMode will always be **Auto** and the [ApplicationView.PreferredLaunchViewSize](applicationview_preferredlaunchviewsize.md) will be determined by system policies. The API applies to the next launch of the app.


You typically set this property when the user sets their preference via an in-app option, or when you call [TryEnterFullScreenMode](applicationview_tryenterfullscreenmode_1643702755.md) and [ExitFullScreenMode](applicationview_exitfullscreenmode_1516691675.md). You can set this property during app startup (before the call to [CoreWindow.Activate](../windows.ui.core/corewindow_activate_1797342875.md)) to specify a first launch behavior. However, you shouldn't set it during every launch as this can cause your app to do extra sizing and positioning work during startup.

## -examples
This example shows how to toggle full-screen mode and set the PreferredLaunchWindowingMode property.

```xaml
<Button x:Name="ToggleFullScreenModeButton" Content="Toggle full screen" 
        Click="ToggleFullScreenModeButton_Click">
```

```csharp
private void ToggleFullScreenModeButton_Click(object sender, RoutedEventArgs e)
{
    var view = ApplicationView.GetForCurrentView();
    if (view.IsFullScreenMode)
    {
        view.ExitFullScreenMode();
        ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.Auto;
        // The SizeChanged event will be raised when the exit from full-screen mode is complete.
    }
    else
    {
        if (view.TryEnterFullScreenMode())
        {
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            // The SizeChanged event will be raised when the entry to full-screen mode is complete.
        }
    }
}
```



## -see-also
[IsFullScreenMode](applicationview_isfullscreenmode.md), [TryEnterFullScreenMode](applicationview_tryenterfullscreenmode_1643702755.md), [ExitFullScreenMode](applicationview_exitfullscreenmode_1516691675.md), [Full screen mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FullScreenMode), [Window resizing sample](https://go.microsoft.com/fwlink/p/?LinkId=620026)
