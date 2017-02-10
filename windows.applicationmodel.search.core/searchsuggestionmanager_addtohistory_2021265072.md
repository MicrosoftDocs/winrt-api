---
-api-id: M:Windows.ApplicationModel.Search.Core.SearchSuggestionManager.AddToHistory(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void AddToHistory(System.String queryText, System.String language)
-->

# Windows.ApplicationModel.Search.Core.SearchSuggestionManager.AddToHistory

## -description
Stores the specified query and input language in the search history.

## -parameters
### -param queryText
The query.

### -param language
The input language. The input language ensures that the query string is displayed in the search history for the correct language.

## -remarks
The [SearchBox](../windows.ui.xaml.controls/searchbox.md) control calls the [AddToHistory](searchsuggestionmanager_addtohistory.md) method when the query entry is committed, to add it to the current history context.

Calling the [AddToHistory](searchsuggestionmanager_addtohistory.md) method doesn't immediately update the suggestions in the [Suggestions](searchsuggestionmanager_suggestions.md) property. Call [SetQuery](searchsuggestionmanager_setquery.md) to update the [Suggestions](searchsuggestionmanager_suggestions.md) property.

## -examples

## -see-also
[SearchBox](../windows.ui.xaml.controls/searchbox.md), [AddToHistory(String)](searchsuggestionmanager_addtohistory_881197840.md)