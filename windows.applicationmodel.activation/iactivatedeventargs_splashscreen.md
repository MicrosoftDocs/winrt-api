---
-api-id: P:Windows.ApplicationModel.Activation.IActivatedEventArgs.SplashScreen
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Activation.SplashScreen SplashScreen { get; }
-->

# Windows.ApplicationModel.Activation.IActivatedEventArgs.SplashScreen

## -description
Gets the splash screen object that provides information about the transition from the splash screen to the activated app.

## -property-value
The splash screen object.

## -remarks
This property is only meaningful when the app is activated under a contract that expects a window to be presented. If the contract doesn't require a window or if the app is being activated for a background task, this call will fail.

## -examples

## -see-also
