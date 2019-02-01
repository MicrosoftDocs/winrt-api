---
-api-id: E:Windows.ApplicationModel.Search.SearchPane.QuerySubmitted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler QuerySubmitted<Windows.ApplicationModel.Search.SearchPane,  Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs>
-->

# Windows.ApplicationModel.Search.SearchPane.QuerySubmitted

## -description
Fires when the user submits the text in the search box and the app needs to display search results.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](https://msdn.microsoft.com/library/58f5cea3-a19b-48a8-abcc-17f38d8fa886) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

If your app participates in the Search contract, register an event handler to respond when this event fires. In your [QuerySubmitted](searchpane_querysubmitted.md) event handler, respond by taking the user to your search results page and populating it with results based on the [SearchPaneQuerySubmittedEventArgs](searchpanequerysubmittedeventargs.md).[QueryText](searchpanequerysubmittedeventargs_querytext.md).

## -examples
**For C#/C++/VB:** This example demonstrates how to ensure that your app can respond to user queries at any time by overriding [OnWindowCreated](../windows.ui.xaml/application_onwindowcreated_1983609380.md) in App.xaml.cs/App.xaml.cpp/App.xaml.vb to access the [SearchPane](searchpane.md) object and register handlers for [SearchPane](searchpane.md) events (like [QuerySubmitted](searchpane_querysubmitted.md)).

```csharp
protected override void OnWindowCreated(WindowCreatedEventArgs args)
{
    // At window creation time, access the SearchPane object and register SearchPane events
    // (like QuerySubmitted, SuggestionsRequested, and ResultSuggestionChosen) so that the app
    // can respond to the user's search queries at any time.

    // Get search pane
    Windows.ApplicationModel.Search.SearchPane searchPane = SearchPane.GetForCurrentView();
    
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
[Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892), [SearchPane class](searchpane.md), [SearchPane.QueryChanged event](searchpane_querychanged.md), [SearchPaneQuerySubmittedEventArgs class](searchpanequerysubmittedeventargs.md)
