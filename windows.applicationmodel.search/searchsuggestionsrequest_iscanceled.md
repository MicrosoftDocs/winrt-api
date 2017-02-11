---
-api-id: P:Windows.ApplicationModel.Search.SearchSuggestionsRequest.IsCanceled
-api-type: winrt property
---

<!-- Property syntax
public bool IsCanceled { get; }
-->

# Windows.ApplicationModel.Search.SearchSuggestionsRequest.IsCanceled

## -description
Indicates whether the request for suggestions to display is canceled.

## -property-value
**True** if the request was canceled, otherwise **false**. The default value is **false**.

## -remarks
A request for search pane or in-app search box suggestions is valid if it's still tied to the most recent [SuggestionsRequested](../windows.ui.xaml.controls/searchbox_suggestionsrequested.md) event, which means that the user hasn't changed the search query.

## -examples

## -see-also
