---
-api-id: P:Windows.UI.WebUI.WebUIFileSavePickerActivatedEventArgs.SplashScreen
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Activation.SplashScreen SplashScreen { get; }
-->

# Windows.UI.WebUI.WebUIFileSavePickerActivatedEventArgs.SplashScreen

## -description
Gets the splash screen object that provides information about the transition from the splash screen to the activated app.

## -property-value
The object that provides splash screen information.

## -remarks

## -examples
The [Splash screen sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Splash%20screen%20sample) demonstrates how to retrieve a [splashScreen](../windows.applicationmodel.activation/splashscreen.md) object in its [activated](webuiapplication_activated.md) event handler, if the app was launched:

```javascript

// Identify and respond to all app activated events.
WinJS.Application.onactivated = function (eventObject) {

    // App was launched
    if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
        // Retrieve splash screen object
        splash = eventObject.detail.splashScreen;
        
        // Add code get image coordinates or listen for the dismissed event

        WinJS.UI.processAll();
    }
    // Add code to respond to other activated event types
};
```

In the sample, `eventObject` is an object provides information about the activated event. In the case of a [ActivationKind.launch](../windows.applicationmodel.activation/activationkind.md) activated event, the `eventObject` is a [WebUILaunchActivatedEventArgs](webuilaunchactivatedeventargs.md) object.

## -see-also
