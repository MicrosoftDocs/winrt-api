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
When the [dismissed](splashscreen_dismissed.md) event fires, the first view of your app is visible on the user's screen.

Avoid increasing the time required to load your app by using this event as a trigger to perform loading tasks (like loading network data) and animations.

## -examples


## -see-also
[Splash screen sample](https://go.microsoft.com/fwlink/p/?linkid=234889), [Quickstart: Adding a splash screen](https://msdn.microsoft.com/library/c70d1dd7-9e0e-4349-a496-88a5c3fd8e97), [How to extend the splash screen](https://msdn.microsoft.com/library/fd10a9ff-4e09-471f-886e-8b8246dc12de), [SplashScreen class](splashscreen.md), [Windows.ApplicationModel.Activation classes](windows_applicationmodel_activation_classes.md)
