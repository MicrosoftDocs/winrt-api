---
-api-id: T:Windows.ApplicationModel.Activation.SplashScreen
-api-type: winrt class
---

<!-- Class syntax.
public class SplashScreen : Windows.ApplicationModel.Activation.ISplashScreen
-->

# Windows.ApplicationModel.Activation.SplashScreen

## -description

Provides a dismissal event and image location information for the app's splash screen.

## -remarks

Access this object from your app's activated event handler by using the [SplashScreen](iactivatedeventargs_splashscreen.md) property on the event object that is passed into your handler.

### For JavaScript

Respond to [onactivated](/previous-versions/windows/apps/br212679(v=win.10)) events in your activated event handler. To learn how to respond to activated events, see [App lifecycle](/windows/uwp/launch-resume/app-lifecycle).

If you notice a flicker during the transition to your extended splash screen, add `onload=""` on your  tag like this: `<img id="extendedSplashImage" src="/images/splash-sdk.png" alt="Splash screen image" onload="" />`. This helps prevent flickering by making the system wait until your image has been rendered before it switches to your extended splash screen.

Additionally, if you use fragment loading to load an extended splash screen page, you may still notice a flicker between when the Windows splash screen is dismissed and when your page is displayed. You see this flicker because fragment loading begins to load your imitation splash screen page asynchronously, before the [onactivated](/previous-versions/windows/apps/br212679(v=win.10)) event handler finishes executing. You can prevent this unsightly flicker by avoiding the use of fragment loading to load your extended splash screen page (as demonstrated by the [Splash screen sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/SplashScreen)). When your additional loading tasks are complete (also as demonstrated by the [Splash screen sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/SplashScreen)) you can then navigate to your app’s main page. Alternatively, if you wish to continue the use of fragment loading in your extended splash screen page, you can also prevent the flicker by getting an activation deferral and responding to [onactivated](/previous-versions/windows/apps/br212679(v=win.10)) events asynchronously. Get a deferral for an activated event by calling the [activatedOperation](../windows.ui.webui/activatedoperation.md).[getDeferral](../windows.ui.webui/activatedoperation_getdeferral_254836512.md) method.

### For C#/C++/VB

Respond to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events by overloading the corresponding activated event handler method. For example, use [OnLaunched](../windows.ui.xaml/application_onlaunched_859642554.md) to respond to [ActivationKind.Launch](activationkind.md) activation events. To learn how to respond to activated events, see [App lifecycle](/windows/uwp/launch-resume/app-lifecycle).

If you notice a flicker during the transition to your extended splash screen, see the Remarks section in [How to extend the splash screen (HTML)](/en-us/previous-versions/windows/apps/hh700390(v=win.10)) for help.

The [SplashScreen](iactivatedeventargs_splashscreen.md) property is available on all [Windows.ApplicationModel.Activation](windows_applicationmodel_activation_classes.md) classes.

<!--<p  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">If you notice a flicker during the transition to your extended splash screen,  add <inline_code devlang="html">onload=""</inline_code> on your <xref targtype="element">&lt;img&gt;</xref> tag like this: <inline_code devlang="html">&lt;img id="extendedSplashImage" src="/images/splash-sdk.png" alt="Splash screen image" onload="" /&gt;</inline_code>. This helps prevent flickering by making the system wait until your image has been rendered before it switches to your extended splash screen.</p>-->

## -examples

The [Splash screen sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/SplashScreen) demonstrates how to retrieve a SplashScreen object in its activated event handler, when the app launches.

```csharp
protected override void OnLaunched(LaunchActivatedEventArgs args)
{
    if (args.PreviousExecutionState != ApplicationExecutionState.Running)
    {
        bool loadState = (args.PreviousExecutionState == ApplicationExecutionState.Terminated);
        ExtendedSplash extendedSplash = new ExtendedSplash(args.SplashScreen, loadState);
        Window.Current.Content = extendedSplash;
    }

    Window.Current.Activate();
}
```

```javascript
function activated(eventObject) {
    if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
        // Retrieve splash screen object
        splash = eventObject.detail.splashScreen;

        // Retrieve the window coordinates of the splash screen image.
        SdkSample.coordinates = splash.imageLocation;

        // Register an event handler to be executed when the splash screen has been dismissed.
        splash.addEventListener("dismissed", onSplashScreenDismissed, false);

        // Create and display the extended splash screen using the splash screen object.
        ExtendedSplash.show(splash);

        // Listen for window resize events to reposition the extended splash screen image accordingly.
        // This is important to ensure that the extended splash screen is formatted properly in response to snapping, unsnapping, rotation, etc...
        window.addEventListener("resize", onResize, false);

        // Use setPromise to indicate to the system that the splash screen must not be torn down
        // until after processAll and navigate complete asynchronously.
        eventObject.setPromise(WinJS.UI.processAll().then(function () {
            // Navigate to either the first scenario or to the last running scenario
            // before suspension or termination.
            var url = WinJS.Application.sessionState.lastUrl || scenarios[0].url;
            return WinJS.Navigation.navigate(url);
        }));
    }
}

// Register your activated event handler
WinJS.Application.addEventListener("activated", activated, false);
```

You can use the object passed to your activated event handler to get information about the activated event. In the example, the object contains information about a [launch](activationkind.md) activation and is either a [webUILaunchActivatedEventArgs](../windows.ui.webui/webuilaunchactivatedeventargs.md) (JavaScript) or a [LaunchActivatedEventArgs](launchactivatedeventargs.md) (C#/C++/VB) object, depending on the programming language. The **Kind** property on this object lets you distinguish between different types of activation (like [ActivationKind.launch](activationkind.md) or [ActivationKind.search](activationkind.md)).

## -see-also

[Windows.ApplicationModel.Activation classes](windows_applicationmodel_activation_classes.md), [Splash screen sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/SplashScreen), [Splash screens](/windows/uwp/launch-resume/splash-screens), [Add a splash screen](/windows/uwp/launch-resume/add-a-splash-screen), [App lifecycle](/windows/uwp/launch-resume/app-lifecycle), [Display a splash screen for more time](/windows/uwp/launch-resume/create-a-customized-splash-screen), [Splash screen sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620608), [How to extend the splash screen](/previous-versions/windows/apps/hh700390(v=win.10))