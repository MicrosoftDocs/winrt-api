---
-api-id: M:Windows.ApplicationModel.Search.Core.SearchSuggestionManager.SetQuery(System.String,System.String,Windows.ApplicationModel.Search.SearchQueryLinguisticDetails)
-api-type: winrt method
---

<!-- Method syntax
public void SetQuery(System.String queryText, System.String language, Windows.ApplicationModel.Search.SearchQueryLinguisticDetails linguisticDetails)
-->

# Windows.ApplicationModel.Search.Core.SearchSuggestionManager.SetQuery

## -description
Assigns the current search query with the specified input language and Input Method Editor (IME) info.

## -parameters
### -param queryText
The query.

### -param language
The input language.

### -param linguisticDetails
Info about the query text that the user enters through an Input Method Editor (IME).

## -remarks
The [SearchBox](../windows.ui.xaml.controls/searchbox.md) control calls the [SetQuery](searchsuggestionmanager_setquery_1931070342.md) method when the query text changes.

## -examples

## -see-also
[SearchBox](../windows.ui.xaml.controls/searchbox.md), [SetQuery(String)](searchsuggestionmanager_setquery_2037893158.md), [SetQuery(String, String)](searchsuggestionmanager_setquery_898352538.md)