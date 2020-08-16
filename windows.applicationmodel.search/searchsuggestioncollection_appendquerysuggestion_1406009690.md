---
-api-id: M:Windows.ApplicationModel.Search.SearchSuggestionCollection.AppendQuerySuggestion(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void AppendQuerySuggestion(System.String text)
-->

# Windows.ApplicationModel.Search.SearchSuggestionCollection.AppendQuerySuggestion

## -description
Appends a query suggestion to the list of search suggestions for the search pane.

## -parameters
### -param text
The text of the query suggestion.

## -remarks
A query suggestion is a suggestion that the user can select as his or her query.

The search pane can display 5 suggestions, at most. Additionally, each separator you use takes the place of a suggestion and lowers the number of suggestions that you can display. Learn more about displaying suggestions in [Guidelines and checklist for search](https://docs.microsoft.com/windows/uwp/controls-and-patterns/search).

## -examples

## -see-also
[Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [Guidelines and checklist for search](https://docs.microsoft.com/windows/uwp/controls-and-patterns/search), [SearchSuggestionCollection class](searchsuggestioncollection.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequestedEventArgs.Request property](searchpanesuggestionsrequestedeventargs_request.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequest.SearchSuggestionCollection property](searchpanesuggestionsrequest_searchsuggestioncollection.md)
