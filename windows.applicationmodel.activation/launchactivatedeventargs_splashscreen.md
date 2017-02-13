---
-api-id: P:Windows.ApplicationModel.Activation.LaunchActivatedEventArgs.SplashScreen
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Activation.SplashScreen SplashScreen { get; }
-->

# Windows.ApplicationModel.Activation.LaunchActivatedEventArgs.SplashScreen

## -description
Gets the splash screen object that provides information about the transition from the splash screen to the activated app.

## -property-value
The object that provides splash screen information.

## -remarks
This property is only meaningful when the app is activated under a contract that expects a window to be presented. If the contract doesn't require a window or if the app is being activated for a background task, this call will fail.

You can listen for the [SplashScreen.Dismissed](splashscreen_dismissed.md) event to trigger additional loading tasks.

## -examples

## -see-also
