---
-api-id: T:Windows.UI.WindowManagement.AppWindow
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class AppWindow 
-->

# Windows.UI.WindowManagement.AppWindow

## -description

Represents a system-managed container for the content of an app.

## -remarks

> [!NOTE]
> AppWindow is currently in preview. This means you can submit apps that use AppWindow to the Store, but some platform and framework components are known to not work with AppWindow (see Limitations).

An AppWindow can be used to represent a displayed portion of a Windows Runtime app when it has more than one window. It is similar in concept to an [ApplicationView](../windows.ui.viewmanagement/applicationview.md), but not the same in behavior and lifetime.

Unlike [ApplicationView](../windows.ui.viewmanagement/applicationview.md), each AppWindow does not have a corresponding [CoreWindow](../windows.ui.core/corewindow.md). They all share the same UI processing thread (including the event dispatcher) from which they were created.

To obtain an object of this type, call [AppWindow.TryCreateAsync](appwindow_trycreateasync_1875892381.md).

To connect content to your AppWindow, call [ElementCompositionPreview.SetAppWindowContent](../windows.ui.xaml.hosting/elementcompositionpreview_setappwindowcontent_20712035.md).

You can only connect XAML content to your AppWindow, there is no support for native DirectX or Holographic content.

To specify a preferred minimum size for the app window, use the [WindowManagementPreview.SetPreferredMinSize](/uwp/api/windows.ui.windowmanagement.preview.windowmanagementpreview.setpreferredminsize) method.

> [!TIP]
>For more info and code demonstrating AppWindow, see [Show multiple views for an app](/windows/uwp/design/layout/show-multiple-views) and [Show multiple views with AppWindow](/windows/uwp/design/layout/app-window).
>
> A sample that shows how to use the AppWindow API can be found in the Windows Universal Samples repo on GitHub under [Samples/AppWindow](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/AppWindow).

### Limitations

Limitations in the current preview version of AppWindow include (this is a non-exhaustive list):

* Any API that uses the GetForCurrentView pattern is not working for AppWindow since the CurrentView refers to the ApplicationView which is a separate entity from the AppWindow.
* Fullscreen media playback is unavailable in MediaElement or MediaPlayerElement.
* MessageDialog will not be modal to the correct window, recommendation is to use [ContentDialog](/uwp/api/Windows.UI.Xaml.Controls.ContentDialog#contentdialog-in-appwindow-or-xaml-islands) instead.
* WebView is not fully supported. You can use an in-proc WebView, but anything outside of static HTML content may or may not work properly.
* If you set the Window.Current.Content property in XAML, it destroys all the XAML content in your AppWindow. Avoid using this as a pattern to reset your content when suspending your app if you use AppWindow.
* Smooth Window Resize is not working for AppWindows. The frame and the content will resize independently, which can look unpolished when content layout is slow.
* DisplayInformation is not accessible for AppWindow. If your AppWindow is on a different monitor than your ApplicationView you will not be able to query for the correct display information.
* UserInteractionMode cannot be set for an AppWindow.
* Print dialogs (2D and 3D) will not be parented to the correct window.
* AppWindow cannot detect when edge gestures are being invoked.
* AppWindow cannot be used to satisfy an activation request through ActivationViewSwitcher.

## -see-also

## -examples
