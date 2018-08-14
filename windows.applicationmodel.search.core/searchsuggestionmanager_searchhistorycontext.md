---
-api-id: P:Windows.ApplicationModel.Search.Core.SearchSuggestionManager.SearchHistoryContext
-api-type: winrt property
---

<!-- Property syntax
public string SearchHistoryContext { get;  set; }
-->

# Windows.ApplicationModel.Search.Core.SearchSuggestionManager.SearchHistoryContext

## -description
Identifies the context of the search and is used to store the user's search history with the app.

## -property-value
The search history context string.

## -remarks
The search history context string is used as a secondary key for storing search history. The primary key is the AppId. An app can use the search history context string to store different search histories based on the context of the application.

Changing the value of the [SearchHistoryContext](searchsuggestionmanager_searchhistorycontext.md) property doesn't immediately update the suggestions in the [Suggestions](searchsuggestionmanager_suggestions.md) property. Call [SetQuery](searchsuggestionmanager_setquery_1931070342.md) to update the [Suggestions](searchsuggestionmanager_suggestions.md) property.

If you don't set this property, Windows assumes that all searches in your app occur in the same context.

## -examples

## -see-also
[SearchBox](../windows.ui.xaml.controls/searchbox.md)