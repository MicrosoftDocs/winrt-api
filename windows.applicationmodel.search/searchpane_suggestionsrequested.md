---
-api-id: E:Windows.ApplicationModel.Search.SearchPane.SuggestionsRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SuggestionsRequested<Windows.ApplicationModel.Search.SearchPane,  Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs>
-->

# Windows.ApplicationModel.Search.SearchPane.SuggestionsRequested

## -description

Occurs when the user's query text changes and the app needs to provide new suggestions to display in the search pane.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) and the SearchPane. Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

Suggestions can come from three sources: search history, local files, or from a source specified by the app. Suggestions are grouped by their source and display in the following order in the search pane: search history, local files, and then app-specified sources.

If your app participates in the Search contract and you want your app to display suggestions from sources that you specify, you must register a handler to respond when this event fires. In your SuggestionsRequested event handler, respond by obtaining suggestions and populating the [SearchSuggestionCollection](searchsuggestioncollection.md) based on the user's [SearchPaneSuggestionsRequestedEventArgs](searchpanesuggestionsrequestedeventargs.md).[QueryText](searchpanesuggestionsrequestedeventargs_querytext.md).

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
+ From a URL that supports suggestions in [OpenSearch format](http://www.opensearch.org)

### Displaying app-provided suggestions in the search pane

After you obtain suggestions, you display them in the search pane by adding them to the [Request](searchpanesuggestionsrequestedeventargs_request.md).[SearchSuggestionCollection](searchsuggestioncollection.md).

At most, the search pane can display 5 suggestions. If you choose to display both query suggestions and result suggestions, you should group the suggestions by suggestion type (query or result) and separate the groups using [AppendSearchSeparator](searchsuggestioncollection_appendsearchseparator_842802100.md). Each separator takes the place of a suggestion and must be followed by at least one suggestion, decreasing the number of suggestions that you can display.

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [SearchPane class](searchpane.md), [SearchPane.ResultSuggestionChosen event](searchpane_resultsuggestionchosen.md), [SearchSuggestionCollection class](searchsuggestioncollection.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequest.SearchSuggestionCollection property](searchpanesuggestionsrequest_searchsuggestioncollection.md), [SearchPaneSuggestionsRequest.SearchSuggestionCollection property](searchpanesuggestionsrequest_searchsuggestioncollection.md)
