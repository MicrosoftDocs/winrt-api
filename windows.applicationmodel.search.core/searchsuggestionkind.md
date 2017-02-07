---
-api-id: T:Windows.ApplicationModel.Search.Core.SearchSuggestionKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Search.Core.SearchSuggestionKind : int
-->

# SearchSuggestionKind

## -description
Specifies the type of a [SearchSuggestion](searchsuggestion.md).

## -enum-fields
### -field Query:0
The suggestion is a query suggestion.

### -field Result:1
The suggestion is a result suggestion.

### -field Separator:2
Represents a separator between search suggestions that's useful for grouping.


## -remarks
Use result suggestions instead of query suggestions only to display high-confidence results that take the user directly to the item instead of to a view that shows search results.

Suggested results include an image and optional detail text to display with the suggestion in the search pane. The image signals to the user that they are seeing results and not query suggestions. If an image for the result doesn't exist, you can use a generic image or icon that represents the result or result type.

Handle the [SuggestionsRequested](searchsuggestionmanager_suggestionsrequested.md) event to provide result suggestions.

### Types of search suggestions

There are two types of suggestions your app can display: suggestions that help users refine a query (query suggestions), and suggestions that are actual results of a query (result suggestions). You may choose to display either or both types of suggestions.

If you provide query suggestions and the user selects one, your app should respond by displaying results for the selected, refined query in your app's search results page.

If you provide result suggestions, you must also register a [ResultSuggestionChosen](../windows.ui.xaml.controls/searchbox_resultsuggestionchosen.md) event handler so that you can respond when the user selects one of your result suggestions and you can display the result to the user.



## -examples

## -see-also
[SuggestionsRequested](searchsuggestionmanager_suggestionsrequested.md), [SearchBox](../windows.ui.xaml.controls/searchbox.md)