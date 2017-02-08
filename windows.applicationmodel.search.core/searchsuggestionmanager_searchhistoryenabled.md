---
-api-id: P:Windows.ApplicationModel.Search.Core.SearchSuggestionManager.SearchHistoryEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool SearchHistoryEnabled { get;  set; }
-->

# Windows.ApplicationModel.Search.Core.SearchSuggestionManager.SearchHistoryEnabled

## -description
Indicates whether the user's previous searches with the app are automatically tracked and used to provide suggestions.

## -property-value
**True** if the user's search history is automatically tracked and used to provide suggestions; otherwise **false**. The default value is **true**.

## -remarks
Set the [SearchHistoryEnabled](searchsuggestionmanager_searchhistoryenabled.md) property to **false** to opt out of automatic suggestions, so your app can optionally provide its own suggestions instead. If you decide to have your app track its own search history, you should also give the user some control over their history through the Settings charm, like the ability to clear the history.

Changing the value of the [SearchHistoryEnabled](searchsuggestionmanager_searchhistoryenabled.md) property doesn't immediately update the suggestions in the [Suggestions](searchsuggestionmanager_suggestions.md) property. Call [SetQuery](searchsuggestionmanager_setquery.md) to update the [Suggestions](searchsuggestionmanager_suggestions.md) property.



## -examples

## -see-also
[SearchBox](../windows.ui.xaml.controls/searchbox.md)