---
-api-id: E:Windows.ApplicationModel.Search.SearchPane.SuggestionsRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SuggestionsRequested<Windows.ApplicationModel.Search.SearchPane,  Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs>
-->

# Windows.ApplicationModel.Search.SearchPane.SuggestionsRequested

## -description
Fires when the user's query text changes and the app needs to provide new suggestions to display in the search pane.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](http://msdn.microsoft.com/library/58f5cea3-a19b-48a8-abcc-17f38d8fa886) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

Suggestions can come from three sources: search history, local files, or from a source specified by the app. Suggestions are grouped by their source and display in the following order in the search pane: search history, local files, and then app-specified sources.

If your app participates in the Search contract and you want your app to display suggestions from sources that you specify, you must register a handler to respond when this event fires. In your [SuggestionsRequested](searchpane_suggestionsrequested.md) event handler, respond by obtaining suggestions and populating the [SearchSuggestionCollection](searchsuggestioncollection.md) based on the user's [SearchPaneSuggestionsRequestedEventArgs](searchpanesuggestionsrequestedeventargs.md).[QueryText](searchpanesuggestionsrequestedeventargs_querytext.md).

> [!NOTE]
> If you want to respond to this event asynchronously, you must use [SearchPaneSuggestionsRequestedEventArgs](searchpanesuggestionsrequestedeventargs.md).[Request](searchpanesuggestionsrequestedeventargs_request.md).[GetDeferral](searchpanesuggestionsrequest_getdeferral_254836512.md).

Suggestions can't be provided for an empty search box, so this event isn't fired when the user updates the search box to be empty.

### Types of search suggestions

There are two types of suggestions your app can display: suggestions that help users refine a query (query suggestions), and suggestions that are actual results of a query (result suggestions). You may choose to display either or both types of suggestions.

If you provide query suggestions and the user selects one, your app should respond by displaying results for the selected, refined query in your app's search results page.

If you provide result suggestions, you must also register a [ResultSuggestionChosen](searchpane_resultsuggestionchosen.md) event handler so that you can respond when the user selects one of your result suggestions and you can display the result to the user.

### Obtaining suggestions

Here are a few examples of sources your app can use to obtain suggestions:

+ From an app-defined, static, local list
+ From a URL that supports suggestions in [OpenSearch format](http://go.microsoft.com/fwlink/p/?linkid=251110)


### Displaying app-provided suggestions in the search pane

After you obtain suggestions, you display them in the search pane by adding them to the [Request](searchpanesuggestionsrequestedeventargs_request.md).[SearchSuggestionCollection](searchsuggestioncollection.md).

At most, the search pane can display 5 suggestions. If you choose to display both query suggestions and result suggestions, you should group the suggestions by suggestion type (query or result) and separate the groups using [AppendSearchSeparator](searchsuggestioncollection_appendsearchseparator_842802100.md). Each separator takes the place of a suggestion and must be followed by at least one suggestion, decreasing the number of suggestions that you can display.

To learn more about using suggestions to create a good search experience for your users in [Guidelines and checklist for search](http://msdn.microsoft.com/library/c328faa3-f6ae-4970-8372-b413f1290c39).

<!--<section  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"><title>Automatic suggestions</title><sectioncontents><p>If you want your app to display suggestions that are automatically provided</p><p>By default, suggestions are automatically provided based on the user's local files that are accessible by your app and the previous searches the user has performed with your app.</p><p>If automatic suggestions are enabled, you do not need to do additional the <xref targtype="class_winrt" rid="w_appmod_search.searchsuggestioncollection">searchSuggestionCollection</xref> object is pre-populated with suggestions. </p><p>If you want your app to provide its own suggestions to the user, you can disable one or both sources of automatic suggestions. Disable automatic suggestions based on the user's local files with the <xref targtype="method_winrt" rid="w_appmod_search.searchpane_setlocalcontentsuggestionsettings">SetLocalContentSuggestionSettings</xref> method and disable automatic suggestions based on the user's search history in your app with the <xref targtype="property_winrt" rid="w_appmod_search.searchpane_searchhistoryenabled">SearchHistoryEnabled</xref> property.</p></sectioncontents></section>-->

## -examples
The [Search contract sample](http://go.microsoft.com/fwlink/p/?linkid=234892) demonstrates how to access the [searchPane](searchpane.md) to respond to a [suggestionsrequested](searchpane_suggestionsrequested.md) event.

> **For Javascript**
> To ensure that your app can respond to user queries at any time, make sure your [searchPane](searchpane.md) event handlers are registered in your app's global scope.



[!code-csharp[all_suggestionsrequested_handler_linguisticdetails](../windows.applicationmodel.search/code/SearchContract/CS/Scenario3.xaml.cs#Snippetall_suggestionsrequested_handler_linguisticdetails)]

[!code-js[all_suggestionsrequested_handler_linguisticdetails](../windows.applicationmodel.search/code/SearchContract/js/js/scenario3.js#Snippetall_suggestionsrequested_handler_linguisticdetails)]

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
}
```



## -see-also
[Guidelines and checklist for search](http://msdn.microsoft.com/library/c328faa3-f6ae-4970-8372-b413f1290c39), [Search contract sample](http://go.microsoft.com/fwlink/p/?linkid=234892), [SearchPane class](searchpane.md), [SearchPane.ResultSuggestionChosen event](searchpane_resultsuggestionchosen.md), [SearchSuggestionCollection class](searchsuggestioncollection.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequest.SearchSuggestionCollection property](searchpanesuggestionsrequest_searchsuggestioncollection.md)
tionsrequestedeventargs.md), [SearchPaneSuggestionsRequest.SearchSuggestionCollection property](searchpanesuggestionsrequest_searchsuggestioncollection.md)
st_searchsuggestioncollection.md)