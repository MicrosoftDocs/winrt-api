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
You can give your app additional time to load by using this property to help you imitate the splash screen that Windows displays for your app. To learn how, see [How to extend the splash screen](http://msdn.microsoft.com/library/fd10a9ff-4e09-471f-886e-8b8246dc12de).

If no splash screen image is displayed, the location returned is where the image is expected.

## -examples


## -see-also
[Splash screen sample](http://go.microsoft.com/fwlink/p/?linkid=234889), [Quickstart: Adding a splash screen](http://msdn.microsoft.com/library/c70d1dd7-9e0e-4349-a496-88a5c3fd8e97), [How to extend the splash screen](http://msdn.microsoft.com/library/fd10a9ff-4e09-471f-886e-8b8246dc12de), [SplashScreen class](splashscreen.md), [Windows.ApplicationModel.Activation classes](windows_applicationmodel_activation_classes.md)