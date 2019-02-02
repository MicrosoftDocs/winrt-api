---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneSuggestionsRequest : Windows.ApplicationModel.Search.ISearchPaneSuggestionsRequest
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest

## -description
Stores suggestions and information about the request for suggestions.

## -remarks
If your app provides its own suggestions to display in the search pane, use the [searchPaneSuggestionsRequest.searchSuggestionCollection](searchpanesuggestionsrequest_searchsuggestioncollection.md) property to add your app's suggestions to the collection of suggestions to display.

The search pane can display 5 suggestions, at most. Additionally, each separator you use takes the place of a suggestion and lowers the number of suggestions that you can display.

## -examples
The [Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892) demonstrates how to respond to a [suggestionsrequested](searchpane_suggestionsrequested.md) event, including how to access the [searchPaneSuggestionsRequest](searchpanesuggestionsrequest.md).



[!code-csharp[all_suggestionsrequested_handler_deferral](../windows.applicationmodel.search/code/SearchContract/CS/Scenario6.xaml.cs#Snippetall_suggestionsrequested_handler_deferral)]

[!code-js[all_suggestionsrequested_handler_deferral](../windows.applicationmodel.search/code/SearchContract/js/js/scenario6.js#Snippetall_suggestionsrequested_handler_deferral)]

## -see-also
[Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequestedEventArgs.Request property](searchpanesuggestionsrequestedeventargs_request.md)
onsrequestedeventargs_request.md)
