---
-api-id: M:Windows.ApplicationModel.Search.Core.SearchSuggestionManager.AddToHistory(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void AddToHistory(System.String queryText)
-->

# Windows.ApplicationModel.Search.Core.SearchSuggestionManager.AddToHistory

## -description
Stores the specified query in the search history.

## -parameters
### -param queryText
The query.

## -remarks
The [SearchBox](../windows.ui.xaml.controls/searchbox.md) control calls the [AddToHistory](searchsuggestionmanager_addtohistory_2021265072.md) method when the query entry is committed, to add it to the current history context.

Calling the [AddToHistory](searchsuggestionmanager_addtohistory_2021265072.md) method doesn't immediately update the suggestions in the [Suggestions](searchsuggestionmanager_suggestions.md) property. Call [SetQuery](searchsuggestionmanager_setquery_1931070342.md) to update the [Suggestions](searchsuggestionmanager_suggestions.md) property.

## -examples

## -see-also
[SearchBox](../windows.ui.xaml.controls/searchbox.md), [AddToHistory(String, String)](searchsuggestionmanager_addtohistory_2021265072.md)