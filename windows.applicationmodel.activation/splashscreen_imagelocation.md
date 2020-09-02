---
-api-id: P:Windows.ApplicationModel.Activation.SplashScreen.ImageLocation
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect ImageLocation { get; }
-->

# Windows.ApplicationModel.Activation.SplashScreen.ImageLocation

## -description
The coordinates of the app's splash screen image relative to the window.

## -property-value
The coordinates of the splash screen image relative to the window and scaled for the dots per inch (dpi) of the device.

## -remarks
You can give your app additional time to load by using this property to help you imitate the splash screen that Windows displays for your app. To learn how, see [How to extend the splash screen](/previous-versions/windows/apps/hh700390(v=win.10)).

If no splash screen image is displayed, the location returned is where the image is expected.

## -examples


## -see-also
[Splash screen sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/SplashScreen), [Quickstart: Adding a splash screen](/previous-versions/windows/apps/hh465346(v=win.10)), [How to extend the splash screen](/previous-versions/windows/apps/hh700390(v=win.10)), [SplashScreen class](splashscreen.md), [Windows.ApplicationModel.Activation classes](windows_applicationmodel_activation_classes.md)
