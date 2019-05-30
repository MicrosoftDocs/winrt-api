---
-api-id: T:Windows.ApplicationModel.Search.SearchPane
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPane : Windows.ApplicationModel.Search.ISearchPane
-->

# Windows.ApplicationModel.Search.SearchPane

## -description
Deprecated. Use the [Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) (XAML) or the [WinJS.UI.SearchBox](https://docs.microsoft.com/previous-versions/windows/apps/dn301949(v=win.10)) (HTML) control instead. Represents and manages the search pane that opens when a user activates the Search charm.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for XAMLUniversal Windows Platform (UWP) app, [WinJS.UI.SearchBox](https://docs.microsoft.com/previous-versions/windows/apps/dn301949(v=win.10)) for HTMLUniversal Windows Platform (UWP) app) and the SearchPane. Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

## -remarks
This object is available to apps that participate in the Search contract; you can learn more about adding the Search contract to your app in [Quickstart: Adding search](https://docs.microsoft.com/previous-versions/windows/apps/hh465238(v=win.10)). In order to provide users with search results, you must add code to your activated event handler that responds when your app is activated for search. To learn more about responding to [search](../windows.applicationmodel.activation/activationkind.md) activation events see [webUISearchActivatedEventArgs](../windows.ui.webui/webuisearchactivatedeventargs.md) (JavaScript) or [SearchActivatedEventArgs](../windows.applicationmodel.activation/searchactivatedeventargs.md) (C#/C++/VB).

You can see code examples that demonstrate how to respond to search events and manage the search pane in the [Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892).

## -examples
**For C#/C++/VB:** This example demonstrates how to ensure that your app can respond to user queries at any time by overriding [OnWindowCreated](../windows.ui.xaml/application_onwindowcreated_1983609380.md) in App.xaml.cs/App.xaml.cpp/App.xaml.vb to access the SearchPane object and register handlers for SearchPane events (like [QuerySubmitted](searchpane_querysubmitted.md)).

```csharp
protected override void OnWindowCreated(WindowCreatedEventArgs args)
{
    // At window creation time, access the SearchPane object and register SearchPane events
    // (like QuerySubmitted, SuggestionsRequested, and ResultSuggestionChosen) so that the app
    // can respond to the user's search queries at any time.

    // Get search pane
    Windows.ApplicationModel.Search.SearchPane searchPane = SearchSearchPane.GetForCurrentView();
    
    // Register event handlers for SearchPane events

    // Register QuerySubmitted event handler
    searchPane.QuerySubmitted += new TypedEventHandler<SearchPane, SearchPaneQuerySubmittedEventArgs>(OnQuerySubmitted);
    
    // Register a SuggestionsRequested if your app displays its own suggestions in the search pane (like from a web service)
    // Register a ResultSuggestionChosen if your app uses result suggestions in the search pane    
}
```

**For JavaScript:** This example demonstrates how to access the searchPane to register a [querysubmitted](searchpane_querysubmitted.md) event handler.

> [!NOTE]
> To ensure that your app can respond to user queries at any time, make sure your searchPane event handlers are registered in your app's global scope.

```javascript

// Register event handler for QuerySubmitted
Windows.ApplicationModel.Search.SearchPane.getForCurrentView().onquerysubmitted = function (eventObject) {
    // Respond to query and perform search
};
```



## -see-also
[Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892), [Quickstart: Adding search](https://docs.microsoft.com/previous-versions/windows/apps/hh465238(v=win.10)), [How to handle app activation (JS)](https://docs.microsoft.com/previous-versions/windows/apps/hh465102(v=win.10)), [Handle app activation](https://docs.microsoft.com/windows/uwp/launch-resume/activate-an-app), [SearchPane.GetForCurrentView method](searchpane_getforcurrentview_1363600702.md), [Windows.ApplicationModel.Activation.ActivationKind enum](../windows.applicationmodel.activation/activationkind.md), [Windows.ApplicationModel.Activation.SearchActivatedEventArgs class](../windows.applicationmodel.activation/searchactivatedeventargs.md), [Windows.ApplicationModel.Core.CoreApplicationView.Activated event](../windows.applicationmodel.core/coreapplicationview_activated.md)
