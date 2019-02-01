---
-api-id: M:Windows.ApplicationModel.Search.SearchSuggestionCollection.AppendQuerySuggestions(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public void AppendQuerySuggestions(Windows.Foundation.Collections.IIterable<System.String> suggestions)
-->

# Windows.ApplicationModel.Search.SearchSuggestionCollection.AppendQuerySuggestions

## -description
Appends a list of query suggestions to the list of search suggestions for the search pane.

## -parameters
### -param suggestions
The list of query suggestions.

## -remarks
A query suggestion is a suggestion that the user can select as his or her query.

The search pane can display 5 suggestions, at most. Additionally, each separator you use takes the place of a suggestion and lowers the number of suggestions that you can display. Learn more about displaying suggestions in [Guidelines and checklist for search](https://msdn.microsoft.com/library/c328faa3-f6ae-4970-8372-b413f1290c39).

## -examples

## -see-also
[Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892), [Guidelines and checklist for search](https://msdn.microsoft.com/library/c328faa3-f6ae-4970-8372-b413f1290c39), [SearchSuggestionCollection class](searchsuggestioncollection.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequestedEventArgs.Request property](searchpanesuggestionsrequestedeventargs_request.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequest.SearchSuggestionCollection property](searchpanesuggestionsrequest_searchsuggestioncollection.md)
