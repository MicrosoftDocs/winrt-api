---
-api-id: T:Windows.ApplicationModel.Search.SearchSuggestionCollection
-api-type: winrt class
---

<!-- Class syntax.
public class SearchSuggestionCollection : Windows.ApplicationModel.Search.ISearchSuggestionCollection
-->

# Windows.ApplicationModel.Search.SearchSuggestionCollection

## -description
Represents a collection of search suggestions to be displayed in the search pane in response to a [suggestionsrequested](searchpane_suggestionsrequested.md) event.

## -remarks
The search pane can display 5 suggestions, at most. Additionally, each separator you use takes the place of a suggestion and lowers the number of suggestions that you can display. Learn more about displaying suggestions in [Guidelines and checklist for search](/windows/uwp/controls-and-patterns/search).

An app retrieves this object through the [searchPaneSuggestionsRequest.searchSuggestionCollection](searchpanesuggestionsrequest_searchsuggestioncollection.md) property while handling a [suggestionsrequested](searchpane_suggestionsrequested.md) event.

## -examples
The [Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample/C%23) demonstrates how to respond to a [suggestionsrequested](searchpane_suggestionsrequested.md) event, including how to use the searchSuggestionCollection.



[!code-csharp[all_suggestionsrequested_handler_linguisticdetails](../windows.applicationmodel.search/code/SearchContract/CS/Scenario3.xaml.cs#Snippetall_suggestionsrequested_handler_linguisticdetails)]

[!code-js[all_suggestionsrequested_handler_linguisticdetails](../windows.applicationmodel.search/code/SearchContract/js/js/scenario3.js#Snippetall_suggestionsrequested_handler_linguisticdetails)]

## -see-also
[Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [Guidelines and checklist for search](/windows/uwp/controls-and-patterns/search), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequestedEventArgs.Request property](searchpanesuggestionsrequestedeventargs_request.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequest.SearchSuggestionCollection property](searchpanesuggestionsrequest_searchsuggestioncollection.md)
