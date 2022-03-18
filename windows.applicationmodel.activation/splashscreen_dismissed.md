---
-api-id: E:Windows.ApplicationModel.Activation.SplashScreen.Dismissed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Dismissed<Windows.ApplicationModel.Activation.SplashScreen,  object>
-->

# Windows.ApplicationModel.Activation.SplashScreen.Dismissed

## -description
Fires when the app's splash screen is dismissed.

## -remarks
When the dismissed event fires, the first view of your app is visible on the user's screen.

Avoid increasing the time required to load your app by using this event as a trigger to perform loading tasks (like loading network data) and animations.

## -examples


## -see-also
[Splash screen sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/SplashScreen), [Quickstart: Adding a splash screen](/previous-versions/windows/apps/hh465346(v=win.10)), [How to extend the splash screen](/previous-versions/windows/apps/hh700390(v=win.10)), [SplashScreen class](splashscreen.md), [Windows.ApplicationModel.Activation classes](windows_applicationmodel_activation_classes.md)
