---
-api-id: M:Windows.UI.WebUI.WebUINavigatedOperation.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.WebUI.WebUINavigatedDeferral GetDeferral()
-->

# Windows.UI.WebUI.WebUINavigatedOperation.GetDeferral

## -description
Requests that the completion of app navigation be delayed.

## -returns
The navigated deferral object.

## -remarks
When an app navigates or reloads its top level document, the system freezes the app’s visuals until the app indicates that it is ready to display its UI. The system transitions back to the app’s live UI when the app returns from its navigated event handler. However, some apps need to start asynchronous operations to retrieve state information and set up their UI (like using fragment loading to display app pages). Apps that must complete navigation asynchronously can get a deferral object from the navigated event arguments. This object enables the app to complete navigation outside its handler. When the app acquires the deferral object, its navigation is not completed when the navigation handler returns.

An app can complete navigation after its required asynchronous operations complete and it is ready to display its UI. App navigation is delayed until the app calls the [WebUINavigatedDeferral.complete](webuinavigateddeferral_complete_1807836922.md) method.

Note that before an app completes navigation the app will appear hung to the user. It is important for the app to complete navigation as quickly as possible.

## -examples

## -see-also
[WebUINavigatedDeferral](webuinavigatedoperation_getdeferral_254836512.md)