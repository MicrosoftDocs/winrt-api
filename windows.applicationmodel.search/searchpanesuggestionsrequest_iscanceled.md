---
-api-id: P:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest.IsCanceled
-api-type: winrt property
---

<!-- Property syntax
public bool IsCanceled { get; }
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest.IsCanceled

## -description
Indicates whether the request for suggestions to display is canceled.

## -property-value
True if the request was canceled, otherwise false. The default value is false.

## -remarks
A request for search pane suggestions is valid if it is still tied to the most recent [suggestionsrequested](searchpane_suggestionsrequested.md) event; that is, if the user has not changed the search query.

## -examples

## -see-also
[SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md)