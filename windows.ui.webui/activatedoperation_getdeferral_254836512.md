---
-api-id: M:Windows.UI.WebUI.ActivatedOperation.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.WebUI.ActivatedDeferral GetDeferral()
-->

# Windows.UI.WebUI.ActivatedOperation.GetDeferral

## -description
Requests that the completion of app activation be delayed.

## -returns
The activation deferral object.

## -remarks
When an app starts, the system displays its splash screen until the app indicates that it is ready to display its UI by returning from its activation handler. The app has several seconds to set up its state and initial UI. The UI for the app is displayed to the user when the app returns from its activation handler. However, some apps need to start asynchronous operations to retrieve state information and set up their UI (like using fragment loading to display app pages). Apps that must complete activation asynchronously can get a deferral object from the activation event arguments. This object enables the app to complete activation outside its handler. When the app acquires the deferral object, its activation is not completed when the activation handler returns.

An app can complete activation after its required asynchronous operations complete and it is ready to display its UI. App activation is delayed until the app calls the [ActivatedDeferral.complete](activateddeferral_complete_1807836922.md) method.

Requesting a deferral enables an app to display its static splash screen for up to 15 seconds. If the app hasn't completed activation after 15 seconds, the system considers the app hung and will terminate it if the user navigates away from the splash screen.

Note that in normal circumstances and app should take no more than a few seconds to finish activation. If your app requires more than 3 or 4 seconds to restore state and prepare its UI, then you should finish activation and display an [extended splash screen](/previous-versions/windows/apps/hh700390(v=win.10)) screen until your app is ready.

## -examples

## -see-also
[App lifecycle](/windows/uwp/launch-resume/app-lifecycle), [How to extend the splash screen](/previous-versions/windows/apps/hh700390(v=win.10)), [ActivatedDeferral](activateddeferral.md), [App activated, resume, and suspend using the WRL sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BJavaScript%5D-Windows%208%20app%20samples/JavaScript/Windows%208%20app%20samples/App%20activated%2C%20resume%2C%20and%20suspend%20using%20the%20WRL%20%20sample%20(Windows%208)/JavaScript)
