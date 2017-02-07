---
-api-id: P:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs.QueryText
-api-type: winrt property
---

<!-- Property syntax
public string QueryText { get; }
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs.QueryText

## -description
The text that the app should provide suggestions for and that was in the search box when the [suggestionsrequested](searchpane_suggestionsrequested.md) event fired.

## -property-value
The query text that the app should provide suggestions for.

## -remarks
Generally, this is the current text in the search box, but if the user types quickly or the app processes slowly, it may not be.

## -examples

## -see-also
[SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md)