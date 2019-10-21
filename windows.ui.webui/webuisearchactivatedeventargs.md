---
-api-id: T:Windows.UI.WebUI.WebUISearchActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUISearchActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs, Windows.ApplicationModel.Activation.ISearchActivatedEventArgs, Windows.ApplicationModel.Activation.ISearchActivatedEventArgsWithLinguisticDetails, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUISearchActivatedEventArgs

## -description
Provides information about the activated event that fires when the user searches the app from the Search charm and the app isn't the main app on screen.

> **C#/C++/VB**
> This type appears as [SearchActivatedEventArgs](../windows.applicationmodel.activation/searchactivatedeventargs.md).

## -remarks
If your app integrates with the Search contract, a webUISearchActivatedEventArgs is passed to your app's [onactivated](https://docs.microsoft.com/previous-versions/windows/apps/br212679(v=win.10)) event handler when the user searches the app from the Search charm and your app is not the main app on screen. This type of activation is indicated by the [activationKind.search](../windows.applicationmodel.activation/activationkind.md) value returned by the [kind](webuisearchactivatedeventargs_kind.md) property.

Learn how to let users search with your app in [Quickstart: Adding search](https://docs.microsoft.com/previous-versions/windows/apps/hh465238(v=win.10)). Learn about responding to other search-related events and customizing the search box and suggestions using the [searchPane](../windows.applicationmodel.search/searchpane.md) class in the [Windows.ApplicationModel.Search](../windows.applicationmodel.search/windows_applicationmodel_search.md) namespace reference.



> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275)
<!--[jjacks - removed this link (https://go.microsoft.com/fwlink/p/?linkid=258277 404->http://msdn.microsoft.com/library/windows/apps/jj157115.aspx) because it doesn't work] and Using Windows Runtime objects in a multithreaded environment (.NET)-->
.

## -examples
The [Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892) demonstrates how to respond to a [search](../windows.applicationmodel.activation/activationkind.md) activated event.

```javascript
function activated(eventObject) {
    if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
        // Use setPromise to indicate to the system that the splash screen must not be torn down
        // until after processAll and navigate complete asynchronously.
        eventObject.setPromise(WinJS.UI.processAll().then(function () {
            // Navigate to either the first scenario or to the last running scenario
            // before suspension or termination.
            var url = WinJS.Application.sessionState.lastUrl || scenarios[0].url;
            return WinJS.Navigation.navigate(url);
        }));
    } else if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.search) {
        // Use setPromise to indicate to the system that the splash screen must not be torn down
        // until after processAll and navigate complete asynchronously.
        eventObject.setPromise(WinJS.UI.processAll().then(function () {
            if (eventObject.detail.queryText === "") {
                // Navigate to your landing page since the user is pre-scoping to your app.
            } else {
                // Display results in UI for eventObject.detail.queryText and eventObject.detail.language.
                // eventObject.detail.language represents user's locale.
            }
            // Navigate to the first scenario since it handles search activation.
            var url = scenarios[0].url;
            return WinJS.Navigation.navigate(url, { searchDetails: eventObject.detail });
        }));
    }
}
```

For JavaScript, `eventObject` contains a webUISearchActivatedEventArgs object.

## -see-also
[Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892)
