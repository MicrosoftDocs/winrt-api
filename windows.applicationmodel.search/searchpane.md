---
-api-id: T:Windows.ApplicationModel.Search.SearchPane
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPane : Windows.ApplicationModel.Search.ISearchPane
-->

# Windows.ApplicationModel.Search.SearchPane

## -description
Deprecated. Use the [Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) (XAML) or the [WinJS.UI.SearchBox](http://msdn.microsoft.com/library/58f5cea3-a19b-48a8-abcc-17f38d8fa886) (HTML) control instead. Represents and manages the search pane that opens when a user activates the Search charm.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for XAMLUniversal Windows Platform (UWP) app, [WinJS.UI.SearchBox](http://msdn.microsoft.com/library/58f5cea3-a19b-48a8-abcc-17f38d8fa886) for HTMLUniversal Windows Platform (UWP) app) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

## -remarks
This object is available to apps that participate in the Search contract; you can learn more about adding the Search contract to your app in [Quickstart: Adding search](http://msdn.microsoft.com/library/d412c562-22d2-41c4-9f27-27503b89b9e9). In order to provide users with search results, you must add code to your activated event handler that responds when your app is activated for search. To learn more about responding to [search](../windows.applicationmodel.activation/activationkind.md) activation events see [webUISearchActivatedEventArgs](../windows.ui.webui/webuisearchactivatedeventargs.md) (JavaScript) or [SearchActivatedEventArgs](../windows.applicationmodel.activation/searchactivatedeventargs.md) (C#/C++/VB).

You can see code examples that demonstrate how to respond to search events and manage the search pane in the [Search contract sample](http://go.microsoft.com/fwlink/p/?linkid=234892).

## -examples
**For C#/C++/VB:** This example demonstrates how to ensure that your app can respond to user queries at any time by overriding [OnWindowCreated](../windows.ui.xaml/application_onwindowcreated_1983609380.md) in App.xaml.cs/App.xaml.cpp/App.xaml.vb to access the [SearchPane](searchpane.md) object and register handlers for [SearchPane](searchpane.md) events (like [QuerySubmitted](searchpane_querysubmitted.md)).

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

**For JavaScript:** This example demonstrates how to access the [searchPane](searchpane.md) to register a [querysubmitted](searchpane_querysubmitted.md) event handler.

> [!NOTE]
> To ensure that your app can respond to user queries at any time, make sure your [searchPane](searchpane.md) event handlers are registered in your app's global scope.

```javascript

// Register event handler for QuerySubmitted
Windows.ApplicationModel.Search.SearchPane.getForCurrentView().onquerysubmitted = function (eventObject) {
    // Respond to query and perform search
};
```



## -see-also
[Search contract sample](http://go.microsoft.com/fwlink/p/?linkid=234892), [Quickstart: Adding search](http://msdn.microsoft.com/library/d412c562-22d2-41c4-9f27-27503b89b9e9), [How to handle app activation (JS)](http://msdn.microsoft.com/library/9bc37944-d2d3-4874-88d3-21ade5e96065), [Handle app activation](http://msdn.microsoft.com/library/da9a6a43-f09d-4512-a2ab-9b6132431007), [SearchPane.GetForCurrentView method](searchpane_getforcurrentview_1363600702.md), [Windows.ApplicationModel.Activation.ActivationKind enum](../windows.applicationmodel.activation/activationkind.md), [Windows.ApplicationModel.Activation.SearchActivatedEventArgs class](../windows.applicationmodel.activation/searchactivatedeventargs.md), [Windows.ApplicationModel.Core.CoreApplicationView.Activated event](../windows.applicationmodel.core/coreapplicationview_activated.md)