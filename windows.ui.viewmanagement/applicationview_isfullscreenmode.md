---
-api-id: P:Windows.UI.ViewManagement.ApplicationView.IsFullScreenMode
-api-type: winrt property
---

<!-- Property syntax
public bool IsFullScreenMode { get; }
-->

# Windows.UI.ViewManagement.ApplicationView.IsFullScreenMode

## -description
Gets a value that indicates whether the app is running in full-screen mode.

## -property-value
**true** if the app is running in full-screen mode; otherwise, **false**. The default is **false**.

## -remarks
The IsFullScreenMode property is set as a result of calls to the [TryEnterFullScreenMode](applicationview_tryenterfullscreenmode_1643702755.md) and [ExitFullScreenMode](applicationview_exitfullscreenmode_1516691675.md) methods. It can also be set to **true** when the app starts if the [PreferredLaunchWindowingMode](applicationview_preferredlaunchwindowingmode.md) property is set to **FullScreen**.

The system raises the [CoreWindow.SizeChanged](../windows.ui.core/corewindow_sizechanged.md) event when the value of this property changes. This is exposed to XAML apps as the [Window.SizeChanged](../windows.ui.xaml/window_sizechanged.md) event and to HTML apps as the [window.resize](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa741886(v=vs.85)) event.

### User experience

Full-screen mode is not the same as maximized or [Tablet mode (Windows 10 only)](/windows-hardware/design/device-experiences/continuum). When an app is in full-screen mode, it takes up the entirety of the screen. System elements, like title bars, status bars, or the taskbar, are hidden by default. In cases where a windowed mode is not available and apps always fill the entire screen, such as on phones or devices in Tablet mode (Windows 10 only), full-screen mode still causes the system elements to be hidden.

When the user switches away from the app to use another app, the full-screen nature of the app is preserved. When the user switches to the app again, it is full-screen.


In full-screen mode:

+ On the mobile device family, the user can swipe from the bottom to bring up the navigation bar (Back, Start, Cortana). They can also swipe from the top to bring up Action Center.
+ On the desktop device family, the user can swipe from the bottom to bring up the navigation bar (taskbar). They can swipe from the left to bring up Task View, from the right to bring up Action Center, and from the top to bring up the title bar.


You can suppress edge swipes and show a small UI instead by setting [FullScreenSystemOverlayMode](applicationview_fullscreensystemoverlaymode.md) to **Minimal**.

To play media full-screen, don't use full-screen mode. Set the [MediaPlayer.IsFullWindow](../windows.ui.xaml.controls/mediaelement_isfullwindow.md) property instead.

## -examples

## -see-also
[TryEnterFullScreenMode](applicationview_tryenterfullscreenmode_1643702755.md), [ExitFullScreenMode](applicationview_exitfullscreenmode_1516691675.md), [PreferredLaunchWindowingMode](applicationview_preferredlaunchwindowingmode.md), [Full screen mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FullScreenMode), [Window resizing sample](https://go.microsoft.com/fwlink/p/?LinkId=620026)
