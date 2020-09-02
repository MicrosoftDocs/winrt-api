---
-api-id: M:Windows.ApplicationModel.Search.SearchPane.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Search.SearchPane GetForCurrentView()
-->

# Windows.ApplicationModel.Search.SearchPane.GetForCurrentView

## -description
Retrieves an instance of the search pane from which users can search within the app.

## -returns
An instance of the search pane, which provides a consistent, touch-friendly search box and optional search suggestions for searching within the current application.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10)) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

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
[SearchPane class](searchpane.md)