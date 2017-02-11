---
-api-id: P:Windows.ApplicationModel.Search.SearchSuggestionsRequest.SearchSuggestionCollection
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Search.SearchSuggestionCollection SearchSuggestionCollection { get; }
-->

# Windows.ApplicationModel.Search.SearchSuggestionsRequest.SearchSuggestionCollection

## -description
The suggestions to display in the search pane or in-app search box for the current query. Apps provide suggestions to display by appending them to this [SearchSuggestionCollection](searchsuggestioncollection.md) object.

## -property-value
The suggestions to display. Apps provide suggestions by appending them to this [SearchSuggestionCollection](searchsuggestioncollection.md) object.

## -remarks
Use the [SearchSuggestionCollection](searchsuggestioncollection.md) object to append app-provided suggestions and search separators to display in the search pane or in-app search box.

When the request for suggestions is completed, either by returning from the [SuggestionsRequested](../windows.ui.xaml.controls/searchbox_suggestionsrequested.md) event handler or by calling [Complete](searchsuggestionsrequestdeferral_complete.md), the search pane or in-app search box displays the suggestions in the [SearchSuggestionCollection](searchsuggestioncollection.md).

## -examples

## -see-also
