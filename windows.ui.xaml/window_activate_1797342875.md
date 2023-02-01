---
-api-id: M:Windows.UI.Xaml.Window.Activate
-api-type: winrt method
---

<!-- Method syntax
public void Activate()
-->

# Windows.UI.Xaml.Window.Activate

## -description
Attempts to activate the application window by bringing it to the foreground and setting the input focus to it.



## -remarks
If you use the default app templates from Microsoft Visual Studio, Window.Activate is part of the initial code in the app.xaml code-behind file. Specifically, Activate is called from the default [OnLaunched](application_onlaunched_859642554.md) override. In cases where the template produces a page navigation experience, previous states are detected so that the navigation framework isn't overwritten if it already existed, but Activate is called regardless.

Calling Activate is required for all app activation scenario, not just app launch.

This method is important for the correct operation of an app. If an app does not call Activate on the [Current](application_current.md) window, and the app is not visible on screen, then the app will be terminated after 15 seconds if it's a UWP app. If the app or its splash screen is kept on screen there is no time limit, but eventually the app needs to call Activate to progress. Also, certain app contracts extend the time limit.

You can modify the default [OnLaunched](application_onlaunched_859642554.md) implementation in order to delay calling Activate. You might do this to have all app rendering be complete before the main [Window](window.md) is shown. For example, a delay can be useful to finish loading [Image](../windows.ui.xaml.controls/image.md) source files in the initial UI. (These load asynchronously and it's impractical to handle [ImageOpened](../windows.ui.xaml.controls/image_imageopened.md) from app.xaml code-behind.) On the other hand, delaying the call can create an undesirable user experience if the splash screen is visible for too long.

For secondary windows, you also need to call Activate. For more info about secondary windows, see [Show multiple views for an app](/windows/uwp/design/layout/show-multiple-views).

## -examples

## -see-also
[Application](application.md), [OnLaunched](application_onlaunched_859642554.md), [Activated](window_activated.md), [Handle app activation](/windows/uwp/launch-resume/activate-an-app), [Navigation](/windows/uwp/layout/navigation-basics)
