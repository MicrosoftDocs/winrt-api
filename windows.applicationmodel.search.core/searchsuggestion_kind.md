---
-api-id: P:Windows.ApplicationModel.Search.Core.SearchSuggestion.Kind
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Search.Core.SearchSuggestionKind Kind { get; }
-->

# Windows.ApplicationModel.Search.Core.SearchSuggestion.Kind

## -description
Gets the type of suggestion.

## -property-value
The type of suggestion.

## -remarks
If the suggestion was supplied by the system, it has a [SearchSuggestionKind](searchsuggestionkind.md) of **Query**. If the suggestion was supplied by the application, in response to a [SuggestionsRequested](searchsuggestionmanager_suggestionsrequested.md) event, the kind is determined by the method of [SearchSuggestionCollection](../windows.applicationmodel.search/searchsuggestioncollection.md) that was used to add the suggestion.

<table>
   <tr><th>SearchSuggestionCollection method</th><th>SearchSuggestionKind</th></tr>
   <tr><td><a href="../windows.applicationmodel.search/searchsuggestioncollection_appendquerysuggestion_1406009690.md">AppendQuerySuggestion</a></td><td>**Query**</td></tr>
   <tr><td><a href="../windows.applicationmodel.search/searchsuggestioncollection_appendquerysuggestions_81953608.md">AppendQuerySuggestions</a></td><td>**Query**</td></tr>
   <tr><td><a href="../windows.applicationmodel.search/searchsuggestioncollection_appendresultsuggestion_603544202.md">AppendResultSuggestion</a></td><td>**Result**</td></tr>
   <tr><td><a href="../windows.applicationmodel.search/searchsuggestioncollection_appendsearchseparator_842802100.md">AppendSearchSeparator</a></td><td>**Separator**</td></tr>
   <tr><td><a href="../windows.applicationmodel.search/searchsuggestioncollection_appendstoragefilesuggestion.md">AppendStorageFile</a></td><td>**StorageFile**</td></tr>
</table>

## -examples

## -see-also
[SearchBox](../windows.ui.xaml.controls/searchbox.md), [SearchSuggestionCollection](../windows.applicationmodel.search/searchsuggestioncollection.md), [SearchSuggestionKind](searchsuggestionkind.md), [SearchSuggestionManager](searchsuggestionmanager.md)