---
-api-id: M:Windows.UI.Xaml.Application.OnLaunched(Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnLaunched(Windows.ApplicationModel.Activation.LaunchActivatedEventArgs args)
-->

# Windows.UI.Xaml.Application.OnLaunched

## -description
Invoked when the application is launched. Override this method to perform application initialization and to display initial content in the associated [Window](window.md).

## -parameters
### -param args
Event data for the event.

## -remarks
Override the OnLaunched method to perform any general app initialization that should occur only when the user launches your app normally (for example, by tapping the app tile). For info on other kinds of activation, see [OnActivated](application_onactivated_603737819.md). Specific activation kinds sometimes have a specific override, also a virtual method on [Application](application.md). For example, [OnFileActivated](application_onfileactivated_2046716329.md) is invoked for any core [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) event on the [Application](application.md) if the [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **File**.

The starting project templates include a basic implementation for OnLaunched. The implementation sets the initial root visual for the application by setting `Window.Current.Content` to a new instance of the class defined by the project template's MainPage XAML/code-behind pair. All [Application](application.md) overrides involved in an activation scenario should call [Window.Activate](window_activate_1797342875.md) in their implementations.

For example code of overrides of OnLaunched, create a new app project and examine the template-created code in the app.xaml code-behind.

> [!NOTE]
> The app.xaml code-behind from some project templates reference API in a SuspensionManager helper class. In this case, the OnLaunched override is asynchronous, because some of the SuspensionManager  API it calls is asynchronous. For more info, see [Minimize startup time](/previous-versions/windows/apps/hh994639(v=win.10)).

## -examples

## -see-also
[Launching and resuming apps](/windows/uwp/launch-resume/), [Handle app prelaunch](/windows/uwp/launch-resume/handle-app-prelaunch)
