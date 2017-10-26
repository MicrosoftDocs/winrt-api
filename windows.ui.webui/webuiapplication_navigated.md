---
-api-id: E:Windows.UI.WebUI.WebUIApplication.Navigated
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.UI.WebUI.NavigatedEventHandler Navigated
-->

# Windows.UI.WebUI.WebUIApplication.Navigated

## -description
Occurs when the app is navigating.

## -remarks
In most cases an HTML based UWP app should never have to navigate or reload its top level document. To maintain global state and create a smooth user experience it is preferable that apps dynamically load and tear down their HTML as they need to within the same top level page.

However on some rare occasions your app may need to navigate or reload its top level document. When that happens the navigated event will be raised after the top level document is navigated or reloaded. It is raised after the **DOMContentLoaded** event and before the **onLoad** event. This event informs the new page that it is being loaded because of an in app navigation, not a new activation. You can use this event to restore any saved state for the page and re-initialize your app’s UI.

> [!NOTE]
> Before this event is raised your app’s visuals will be frozen so that the user continues to see the previous page of your app. After **navigated** completes the system transitions to the UI of your new page. This allows your app to set up its UI on the new page before the user can see it. If you need to use asynchronous methods to initialize your UI you can use the [navigatedOperation](webuinavigatedeventargs_navigatedoperation.md) on the eventArgs to defer completion of the navigation.

## -examples
Register for the navigated event and use the WebUINavigatedDeferral object to delay unfreezing your app’s UI until state is loaded asynchronously from a file.

```javascript
function navigatedHandler(eventArgs) {

    var deferral = eventArgs.navigatedOperation.getDeferral();

    // Populate the text box with the previously saved value while the app visuals are frozen
    app.local.readText(myfile, "default").then(function (str) {
        document.getElementById("userText").value = str;

        // Complete the deferral to transition back to a live view of the app
        deferral.complete();
    }, function(error) {
        document.getElementById("userText").value = 'undefined';

        // Complete the deferral even in the case where readText fails 
        // else the app would appear hung to the user
        deferral.complete();
    });
}

Windows.UI.WebUI.WebUIApplication.addEventListener("navigated", navigatedHandler, false);


```



## -see-also
