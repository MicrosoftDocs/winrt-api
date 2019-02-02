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
Override the [OnLaunched](application_onlaunched_859642554.md) method to perform any general app initialization that should occur only when the user launches your app normally (for example, by tapping the app tile). For info on other kinds of activation, see [OnActivated](application_onactivated_603737819.md). Specific activation kinds sometimes have a specific override, also a virtual method on [Application](application.md). For example, [OnFileActivated](application_onfileactivated_2046716329.md) is invoked for any core [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) event on the [Application](application.md) if the [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **File**.

The starting project templates include a basic implementation for [OnLaunched](application_onlaunched_859642554.md). The implementation sets the initial root visual for the application by setting `Window.Current.Content` to a new instance of the class defined by the project template's MainPage XAML/code-behind pair. All [Application](application.md) overrides involved in an activation scenario should call [Window.Activate](window_activate_1797342875.md) in their implementations.

For example code of overrides of [OnLaunched](application_onlaunched_859642554.md), create a new app project and examine the template-created code in the app.xaml code-behind.

> [!NOTE]
> The app.xaml code-behind from some project templates reference API in a SuspensionManager helper class. In this case, the [OnLaunched](application_onlaunched_859642554.md) override is asynchronous, because some of the SuspensionManager  API it calls is asynchronous. For more info, see [Minimize startup time](https://msdn.microsoft.com/library/b38f6c63-520b-4bf6-a47a-9a4af6303e71).

## -examples

## -see-also
[Launching and resuming apps](https://docs.microsoft.com/windows/uwp/launch-resume/), [Handle app prelaunch](https://msdn.microsoft.com/library/a4838ac2-22d7-46ba-9eb2-f3c248e22f52)
