---
-api-id: E:Windows.ApplicationModel.Search.SearchPane.ResultSuggestionChosen
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ResultSuggestionChosen<Windows.ApplicationModel.Search.SearchPane,  Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs>
-->

# Windows.ApplicationModel.Search.SearchPane.ResultSuggestionChosen

## -description
Fires when the user selects one of the suggested results that was provided by the app and displayed in the search pane.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10)) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

If your app participates in the Search contract and displays suggestions for possible results in the search pane, you should register an event handler to respond when this event fires. In your ResultSuggestionChosen event handler, respond by getting the [SearchPaneResultSuggestionChosenEventArgs](searchpaneresultsuggestionchoseneventargs.md).[Tag](searchpaneresultsuggestionchoseneventargs_tag.md) of the chosen result and using it to take the user to the result in your app UI.

> [!NOTE]
> If you want to display result suggestions, you must also listen for and handle the [SuggestionsRequested](searchpane_suggestionsrequested.md) event.

## -examples
**For C#/C++/VB:** This example demonstrates how to ensure that your app can respond to user queries at any time by overriding [OnWindowCreated](../windows.ui.xaml/application_onwindowcreated_1983609380.md) in App.xaml.cs/App.xaml.cpp/App.xaml.vb to access the [SearchPane](searchpane.md) object and register handlers for [SearchPane](searchpane.md) events (like [QuerySubmitted](searchpane_querysubmitted.md) and ResultSuggestionChosen).

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
    searchPane.SuggestionsRequested += new TypedEventHandler<SearchPane, SearchPaneSuggestionsRequestedEventArgs>(OnSuggestionsRequested);

    // Register a ResultSuggestionChosen if your app displays result suggestions in the search pane
    searchPane.ResultSuggestionChosen += new TypedEventHandler<SearchPane, SearchPaneResultSuggestionChosenEventArgs>(OnResultSuggestionChosen);
    
}
```

**For JavaScript:** This example demonstrates how to access the [searchPane](searchpane.md) to register a resultsuggestionchosen event handler.

> [!NOTE]
> To ensure that your app can respond to user queries at any time, make sure your [searchPane](searchpane.md) event handlers are registered in your app's global scope.

```javascript

// Register event handler for ResultSuggestionChosen
Windows.ApplicationModel.Search.SearchPane.getForCurrentView().onresultsuggestionchosen = function (eventObject) {
    // Respond when user chooses a result suggestion
};
```



## -see-also
[Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [Object class](/dotnet/api/system.object?redirectedfrom=MSDN), [SearchPane class](searchpane.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneResultSuggestionChosenEventArgs class](searchpaneresultsuggestionchoseneventargs.md)
