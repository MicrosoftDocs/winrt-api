---
-api-id: E:Windows.ApplicationModel.Search.Core.SearchSuggestionManager.SuggestionsRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SuggestionsRequested<Windows.ApplicationModel.Search.Core.SearchSuggestionManager,  Windows.ApplicationModel.Search.Core.SearchSuggestionsRequestedEventArgs>
-->

# Windows.ApplicationModel.Search.Core.SearchSuggestionManager.SuggestionsRequested

## -description
Raised when the user's query text changes and the app needs to provide new suggestions to display in the search box.

## -remarks
Suggestions can come from three sources: search history, local files, or from a source specified by the app. Suggestions are grouped by their source and display in the following order in the search pane: search history, local files, and then app-specified sources.

If your app participates in the Search contract and you want your app to display suggestions from sources that you specify, you must register a handler to respond when this event fires. In your SuggestionsRequested event handler, respond by obtaining suggestions and populating the [SearchSuggestionCollection](../windows.applicationmodel.search/searchsuggestioncollection.md) based on the user's [QueryText](searchsuggestionsrequestedeventargs_querytext.md).

> [!NOTE]
> If you want to respond to this event asynchronously, you must get a deferral from the [Request](searchsuggestionsrequestedeventargs_request.md) property.

Suggestions can't be provided for an empty search box, so this event isn't raised when the user updates the search box to be empty.

### Types of search suggestions

There are two types of suggestions your app can display: suggestions that help users refine a query (query suggestions), and suggestions that are actual results of a query (result suggestions). You may choose to display either or both types of suggestions.

If you provide query suggestions and the user selects one, your app should respond by displaying results for the selected, refined query in your app's search results page.

If you provide result suggestions, you must also register a [ResultSuggestionChosen](../windows.ui.xaml.controls/searchbox_resultsuggestionchosen.md) event handler so that you can respond when the user selects one of your result suggestions and you can display the result to the user.

### Obtaining suggestions

Here are a few examples of sources your app can use to obtain suggestions:

+ From an app-defined, static, local list
+ From a URL that supports suggestions in [OpenSearch format](https://www.opensearch.org)


### Displaying app-provided suggestions in the search box control

After you obtain suggestions, you display them in the search pane by adding them to the [SearchSuggestionCollection](../windows.applicationmodel.search/searchsuggestioncollection.md) of the [Request](searchsuggestionsrequestedeventargs_request.md).

If you choose to display both query suggestions and result suggestions, you should group the suggestions by suggestion type (query or result) and separate the groups using [AppendSearchSeparator](../windows.applicationmodel.search/searchsuggestioncollection_appendsearchseparator_842802100.md). Each separator takes the place of a suggestion and must be followed by at least one suggestion, decreasing the number of suggestions that you can display.

## -examples

## -see-also
[SearchBox](../windows.ui.xaml.controls/searchbox.md)
